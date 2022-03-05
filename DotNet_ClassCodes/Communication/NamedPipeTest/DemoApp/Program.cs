using System.Text;

if(args.Length == 0)
    Server.Run();

byte[] request = Encoding.UTF8.GetBytes(args[0]);
using var pipe = new NamedPipeClientStream(".", "enc_channel", PipeDirection.InOut);
try
{
    pipe.Connect(5000); //wait for 5000 milliseconds maximum
    pipe.Write(request, 0, request.Length);
    byte[] response = new byte[80];
    int n = pipe.Read(response, 0, response.Length);
    string text = Encoding.UTF8.GetString(response, 0, n);
    Console.WriteLine(text);
}
catch(TimeoutException)
{
    Console.WriteLine("Server is not running!");
}
