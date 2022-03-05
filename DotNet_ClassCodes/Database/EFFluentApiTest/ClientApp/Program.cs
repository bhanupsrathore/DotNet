using Sales;
using Grpc.Core;
using Grpc.Net.Client;

var channel = GrpcChannel.ForAddress("http://localhost:4000");
var stub = new OrderManager.OrderManagerClient(channel);

if(args.Length > 2)
{
    var request = new OrderInput 
    {
        CustomerId = args[0].ToUpper(),
        ProductId = int.Parse(args[1]),
        Quantity = int.Parse(args[2])
    };
    try
    {
        var reply = stub.PlaceOrder(request);
        Console.WriteLine("New Order Number: {0}", reply.OrderId);
    }
    catch(RpcException ex)
    {
        Console.WriteLine("Order Failed: {0}", ex.Status.Detail);
    }
}
else
{
    var request = new CustomerInput 
    {
        CustomerId = args[0].ToUpper()    
    };
    using var reply = stub.FetchInvoice(request);
    while(await reply.ResponseStream.MoveNext())
    {
        var entry = reply.ResponseStream.Current;
        Console.WriteLine("{0}\t{1}\t{2}", entry.ProductId, entry.Quantity, entry.DateOfOrder);
    }
}

await channel.ShutdownAsync();
