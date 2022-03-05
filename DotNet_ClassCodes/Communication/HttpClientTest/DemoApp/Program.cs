if(args.Length == 0)
    Server.Run();

string name = args[0].ToLower();
int quantity = int.Parse(args[1]);
string url = $"http://localhost:5000/shop/{name}";
var client = new HttpClient();
try
{
    var response =  await client.GetStringAsync(url);
    Item item = Item.Parse(response);
    //var response =  client.GetStringAsync(url);
    //Item item = Item.Parse(response.Result); 
    if(quantity <= item.Stock)
        Console.WriteLine("Total Payment: {0:0.00}", quantity * item.Price);
    else
        Console.WriteLine("Out of stock!");
}
catch(HttpRequestException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
{
    Console.WriteLine("Not sold!");
}