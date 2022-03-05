using System.Text;
using System.Runtime.InteropServices;

unsafe class Program
{
    [DllImport("legacy", EntryPoint="encrypt_buffer")] //pseudo attribute (translates to pinvokeimpl modifier)
    extern static long EncryptBuffer(byte[] bytes, int count, string key, delegate*<byte, byte, int> transform);

    static int XorTransform(byte a, byte b)
    {
        return a ^ b;
    }

    static void Main(string[] args)
    {
        byte[] buf = Encoding.UTF8.GetBytes(args[0]);
        EncryptBuffer(buf, buf.Length, args[1], &XorTransform);
        string text = Encoding.UTF8.GetString(buf);
        Console.WriteLine(text);
    }
}
