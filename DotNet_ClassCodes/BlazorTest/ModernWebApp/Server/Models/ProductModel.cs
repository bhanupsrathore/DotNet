namespace ModernWebApp.Server.Models;

using Shared;

public class ProductModel
{
    public List<Product> Products { get; set; }

    public ProductModel()
    {
        var rdm = new Random();
        Products = new List<Product>();
        for(int i = 1; i <= 6; ++i)
        {
            Products.Add(new Product 
            {
                Id = 500 + i,
                Price = rdm.Next(100, 1000),
                Stock = rdm.Next(10, 100)
            });
        }
    }

    public bool Validate(Product info) => info.Price >= 100 && info.Stock >= 10;

    public void Save(Product info) {}
}
