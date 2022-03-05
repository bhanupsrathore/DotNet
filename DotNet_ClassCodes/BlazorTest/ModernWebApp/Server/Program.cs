using ModernWebApp.Shared;
using ModernWebApp.Server.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<ProductModel>();

var app = builder.Build();
app.UseBlazorFrameworkFiles();
app.UseStaticFiles();
app.MapFallbackToFile("index.html");

app.MapGet("/Products", (ProductModel model) => model.Products);

app.MapPut("/Products", (Product input, ProductModel model) => 
{
    var product = model.Products.Find(entry => entry.Id == input.Id);
    if(product is null)
        return Results.NotFound();
    if(model.Validate(input))
    {
        product.Price = input.Price;
        product.Stock = input.Stock;
        model.Save(product);
        return Results.NoContent();
    }
    return Results.BadRequest();
});

app.Run();
