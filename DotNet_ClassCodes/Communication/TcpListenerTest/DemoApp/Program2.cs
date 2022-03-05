using System.Net;
using System.Net.Sockets;

//Step 1 - start listener on a well-known local endpoint
var listener = new TcpListener(IPAddress.Any, 4000);
listener.Start(); //open a TCP socket on local endpoint 0.0.0.0:4000

for(int i = 0; i < 3; ++i)
{
    var servant = new Thread(() => Service(listener));
    servant.Start();
}   

void Service(TcpListener server)
{
    Shop shop = Shop.Open("store.xml");
    for(;;)
    {
        //Step 2 - accept client's connection request
        using var client = server.AcceptTcpClient();
        client.ReceiveTimeout = 60000;
        
        //Step 3 - exchange data with the client using streams
        using var channel = client.GetStream();
        using var reader = new StreamReader(channel);
        using var writer = new StreamWriter(channel);
        writer.AutoFlush = true;
        try
        {
            writer.WriteLine("Welcome to CitiTek");
            string item = reader.ReadLine();
            string info = shop.GetItemInfo(item);
            if(info is not null)
                writer.WriteLine(info);
        }
        catch(Exception ex)
        {
            Console.WriteLine("Communication Fault: {0}", ex);
        }

        //Step 4 - close connection and streams
        //Step 5 - go to step 2
    }
}