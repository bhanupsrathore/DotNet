using System.ComponentModel;
using Microsoft.Data.SqlClient;

namespace DBClientApp.Data
{
    public class ProductStore : IDisposable
    {
        private readonly SqlCommand command;

        public ProductStore()
        {
            command = new SqlCommand();
            command.Connection = new SqlConnection("Data Source=(localdb)\\SqlXE;Database=Shop");
            command.Connection.Open();
        }

        public void LoadProducts(IBindingList products)
        {
            command.CommandText = "SELECT ProductNo, Price FROM ProductInfo";
            using var reader = command.ExecuteReader();
            while(reader.Read())
            {
                products.Add(new Product 
                {
                    ProductNo = reader.GetInt32(0),
                    Price = reader.GetDecimal(1)
                });
            }
        }

        public void UpdateProduct(Product product)
        {
            command.CommandText = $"UPDATE ProductInfo SET Price={product.Price} WHERE ProductNo={product.ProductNo}";
            command.ExecuteNonQuery();
        }

        public void LoadOrders(Product product, IBindingList orders)
        {
            command.CommandText = $"SELECT CustomerId, Quantity, OrderDate FROM OrderDetail WHERE ProductNo={product.ProductNo}";
            using var reader = command.ExecuteReader();
            while(reader.Read())
            {
                orders.Add(new ProductOrder 
                {
                    CustomerId = reader.GetString(0),
                    Quantity = reader.GetInt32(1),
                    OrderDate = reader.GetDateTime(2)
                });
            }
        }

        public void Dispose()
        {
            command.Connection.Close();
        }
    }
}
