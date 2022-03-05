using Sales;
using Grpc.Core;

namespace Shopping;

public class OrderManagerService : OrderManager.OrderManagerBase
{
    public override async Task<OrderStatus> PlaceOrder(OrderInput request, ServerCallContext context)
    {
        var shop = new ShopDbContext();
        var result = new OrderStatus();
        try
        {
            var counter = shop.Counters.Find("order");
            var order = new Order 
            {
                Id = ++counter.CurrentValue + counter.SeedValue,
                OrderDate = DateTime.Today,
                CustomerId = request.CustomerId,
                ProductNo = request.ProductId,
                Quantity = request.Quantity
            };
            shop.Orders.Add(order);
            await shop.SaveChangesAsync();
            result.OrderId = order.Id;
        }
        catch(Exception ex)
        {
            context.Status = new Status(StatusCode.Internal, ex.InnerException.Message);
        }

        return result;
    }

    public override async Task FetchInvoice(CustomerInput request, IServerStreamWriter<InvoiceEntry> responseStream, ServerCallContext context)
    {
        var shop = new ShopDbContext();
        var selection = from e in shop.Orders
                        where e.CustomerId == request.CustomerId
                        select new InvoiceEntry
                        {
                            ProductId = e.ProductNo,
                            Quantity = e.Quantity,
                            DateOfOrder = e.OrderDate.ToShortDateString()
                        };
        foreach(var entry in selection)
            await responseStream.WriteAsync(entry);
    }

}
