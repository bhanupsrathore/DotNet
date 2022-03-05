global using System.Text; //global using is applicable to all source files in this project
global using System.Net;
global using System.Net.Sockets;

class Server
{
    public static void Run()
    {
        string[] symbols = {"APPL", "GOGL", "INTC", "MSFT", "ORCL"};
        var rdm = new Random();
        var group = IPAddress.Parse("230.0.0.1"); //class D address: 224-239.*.*.*
        var publisher = new UdpClient(); //open UDP socket on random port
        var remote = new IPEndPoint(group, 4001);
        for(;;)
        {
            int i = rdm.Next(symbols.Length);
            double price = 0.01 * rdm.Next(1000, 10000);
            string message = $"{symbols[i]} : {price:0.00}";
            byte[] data = Encoding.UTF8.GetBytes(message);
            publisher.Send(data, data.Length, remote);
            Thread.Sleep(10000);
        }
    }
}