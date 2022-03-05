using System.Net;
using System.Net.Http.Json;

var client = new HttpClient();

if(args.Length < 3)
{
    string customerId = args[0].ToUpper();
    try
    {
        var orders = await client.GetFromJsonAsync<List<OrderResource>>($"http://localhost:5000/api/orders/{customerId}");
        foreach(var entry in orders)
            Console.WriteLine("{0}\t{1}\t{2}", entry.ProductNo, entry.Quantity, entry.OrderDate);
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
else
{
    var resource = new OrderResource
    {
        CustomerId = args[0].ToUpper(),
        ProductNo = int.Parse(args[1]),
        Quantity = int.Parse(args[2])
    };
    var response = await client.PostAsJsonAsync("http://localhost:5000/api/orders", resource);
    if(response.StatusCode == HttpStatusCode.OK)
    {
        var order = await response.Content.ReadFromJsonAsync<OrderResource>();
        Console.WriteLine("New Order Number: {0}", order.OrderNo);
    }
    else
        Console.WriteLine("Order Failed!");

}
