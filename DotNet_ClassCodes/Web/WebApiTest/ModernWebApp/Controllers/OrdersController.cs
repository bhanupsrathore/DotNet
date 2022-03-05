using Sales;
using Grpc.Core;
using Microsoft.AspNetCore.Mvc;

namespace ModernWebApp.Controllers;

[ApiController, Route("api/orders")]
public class OrdersController : ControllerBase
{
    private readonly OrderManager.OrderManagerClient _client;

    public OrdersController(OrderManager.OrderManagerClient client)
    {
        _client = client;
    }

    [HttpGet("{id}")] // GET /api/orders/CU201
    public async Task<ActionResult<List<OrderResource>>> ReadOrders(string id)
    {
        try
        {
            var orders = new List<OrderResource>();
            var request = new CustomerInput { CustomerId = id };
            using var reply = _client.FetchInvoice(request);
            await foreach(var entry in reply.ResponseStream.ReadAllAsync())
            {
                orders.Add(new OrderResource
                {
                    ProductNo = entry.ProductId,
                    Quantity = entry.Quantity,
                    OrderDate = entry.DateOfOrder
                });
            }
            if(orders.Count == 0)
                return NotFound();
            return orders;
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex);
            return StatusCode(500);
        }
    }

    [HttpPost] // POST /api/orders
    public async Task<ActionResult<OrderResource>> CreateOrder([FromBody] OrderResource resource)
    {
        try
        {
            var request = new OrderInput 
            {
                CustomerId = resource.CustomerId,
                ProductId = resource.ProductNo,
                Quantity = resource.Quantity
            };
            var reply = await _client.PlaceOrderAsync(request);
            resource.OrderNo = reply.OrderId;
            return resource;
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex);
            return StatusCode(500);
        }
    }
}