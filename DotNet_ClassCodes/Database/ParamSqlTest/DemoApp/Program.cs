using System.Data.Common;

string customerId = args[0].ToUpper();
int productNo = int.Parse(args[1]);
int quantity = int.Parse(args[2]);

using var connection = new MySql.Data.MySqlClient.MySqlConnection();
connection.ConnectionString = "Data Source=localhost;Database=shop;User Id=dbpro;Password=Dbpro@789";
connection.Open();
using var command = connection.CreateCommand();
command.Transaction = connection.BeginTransaction();
try
{
    command.CommandText = "UPDATE Counters SET CurrentValue=CurrentValue+1 WHERE Id='order'";
    command.ExecuteNonQuery();
    command.CommandText = "SELECT CurrentValue+SeedValue FROM Counters WHERE Id='order'";
    long orderNo = (long) command.ExecuteScalar();
    command.CommandText = "INSERT INTO OrderDetail VALUES(@ordid, @orddt, @custid, @pno, @qty)";
    command.Parameters.AddWithValue("@ordid", orderNo);
    command.Parameters.AddWithValue("@orddt", DateTime.Today);
    command.Parameters.AddWithValue("@custid", customerId);
    command.Parameters.AddWithValue("@pno", productNo);
    command.Parameters.AddWithValue("@qty", quantity);
    command.ExecuteNonQuery();
    //command.Parameters.Clear();
    command.Transaction.Commit();
    Console.WriteLine("New Order Number: {0}", orderNo);
}
catch(DbException ex)
{
    command.Transaction.Rollback();
    Console.WriteLine("Order Failed: {0}", ex.Message);
}
