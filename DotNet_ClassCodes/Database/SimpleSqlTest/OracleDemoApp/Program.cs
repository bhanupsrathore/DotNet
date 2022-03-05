﻿using var connection = new Oracle.ManagedDataAccess.Client.OracleConnection();
connection.ConnectionString = "Data Source=localhost/xe;User Id=scott;Password=tiger";
connection.Open();
using var command = connection.CreateCommand();
if(args.Length == 0)
{
    command.CommandText = "SELECT ProductNo, Price, Stock FROM ProductInfo";
    using var reader = command.ExecuteReader();
    while(reader.Read())
        Console.WriteLine("{0, -6}{1, 12:0.00}{2, 8}", reader.GetInt32(0), reader.GetDecimal(1), reader.GetInt32(2));
}
else
{
    int id = int.Parse(args[0]);
    command.CommandText = $"UPDATE ProductInfo SET Stock=Stock+5 WHERE ProductNo={id}";
    int n = command.ExecuteNonQuery();
    if(n == 0)
        Console.WriteLine("No such product!");
}
