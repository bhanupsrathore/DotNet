using System.Net.Sockets;

string name = args[0].ToLower();
int quantity = int.Parse(args[1]);
string host = args.Length > 2 ? args[2] : "localhost";

using var client = new TcpClient(host, 4000); //connect to host on port 4000
using var channel = client.GetStream();
using var reader = new StreamReader(channel);
using var writer = new StreamWriter(channel);

Console.WriteLine(reader.ReadLine());
writer.WriteLine(name);
writer.Flush();
string? info = reader.ReadLine();
if(info is not null)
{
    Item item = Item.Parse(info);
    if(quantity <= item.Stock)
        Console.WriteLine("Total Payment: {0:0.00}", quantity * item.Price);
    else
        Console.WriteLine("Out of stock!");
}
else
    Console.WriteLine("Not sold!");
