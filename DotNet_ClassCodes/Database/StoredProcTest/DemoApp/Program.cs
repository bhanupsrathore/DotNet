using System.Data;
using System.Data.Common;

string customerId = args[0].ToUpper();
int productNo = int.Parse(args[1]);
int quantity = int.Parse(args[2]);

using var connection = new Microsoft.Data.SqlClient.SqlConnection();
connection.ConnectionString = "Data Source=(localdb)\\SqlXE;Database=Shop";
connection.Open();
using var command = connection.CreateCommand();
command.CommandText = "PlaceOrder";
command.CommandType = CommandType.StoredProcedure;
command.Parameters.AddWithValue("@Customer", customerId);
command.Parameters.AddWithValue("@Product", productNo);
command.Parameters.AddWithValue("@Quantity", quantity);
var orderIdParam = command.Parameters.Add("@OrderId", SqlDbType.Int);
orderIdParam.Direction = ParameterDirection.Output;
try
{
    command.ExecuteNonQuery();
    Console.WriteLine("New Order Number: {0}", orderIdParam.Value);
}
catch(DbException ex)
{
    Console.WriteLine("Order Failed: {0}", ex.Message);
}

