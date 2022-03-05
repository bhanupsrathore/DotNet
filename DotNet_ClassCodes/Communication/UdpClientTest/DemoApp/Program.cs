if(args.Length == 0)
    Server.Run();

int n = int.Parse(args[0]);
var group = IPAddress.Parse("230.0.0.1");
using var subscriber = new UdpClient(4001); //opens UDP socket on local port 4001
subscriber.JoinMulticastGroup(group);
IPEndPoint? remote = null;
for(int i = 0; i < n; ++i)
{
    byte[] data = subscriber.Receive(ref remote);
    string message = Encoding.UTF8.GetString(data);
    Console.WriteLine(message);
}
subscriber.DropMulticastGroup(group);
