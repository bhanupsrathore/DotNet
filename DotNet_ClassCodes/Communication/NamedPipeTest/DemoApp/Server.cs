global using System.IO.Pipes;

class Server
{
    public static void Run()
    {
        using var pipe = new NamedPipeServerStream("enc_channel", PipeDirection.InOut);
        byte[] data = new byte[80];
        for(;;)
        {
            pipe.WaitForConnection();
            int n = pipe.Read(data, 0, data.Length);
            Transformer.Encode(data, n);
            pipe.Write(data, 0, n);
            pipe.Disconnect();
        }
    }
}
