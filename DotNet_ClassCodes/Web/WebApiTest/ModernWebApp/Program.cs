var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddGrpcClient<Sales.OrderManager.OrderManagerClient>(options => 
{
    options.Address = new Uri("http://localhost:4000");
});

var app = builder.Build();
app.UseStaticFiles();
app.MapControllers();
app.Run("http://localhost:5000");
