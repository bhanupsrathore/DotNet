using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;

namespace RichClientApp
{
    public class Product
    {
        public int Id { get; set; }

        public double Price { get; set; }

        public int Stock { get; set; }
    }

    public class ProductModel
    {
        const string serviceUri = "http://localhost:8086/api/products/";
        readonly HttpClient client = new HttpClient();

        public List<Product> ReadProducts()
        {
            var task = client.GetFromJsonAsync<List<Product>>(serviceUri);
            return task?.Result ?? new List<Product>();
        }

        public async Task<bool> WriteProduct(Product input)
        {
            var response = await client.PutAsJsonAsync(serviceUri, input);
            return response.IsSuccessStatusCode;
        }
    }
}
