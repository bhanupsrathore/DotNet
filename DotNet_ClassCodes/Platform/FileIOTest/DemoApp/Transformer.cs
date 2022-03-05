class Transformer
{
    public static void Encode(byte[] buffer, int count)
    {
        for(int i = 0; i < count; ++i)
        {
            buffer[i] = (byte)(buffer[i] ^ '#');
        }
    }

    public static void Reverse(UnmanagedMemoryAccessor buffer)
    {
        for(long i = 0, j = buffer.Capacity - 1; i < j; ++i, j--)
        {
            byte ib = buffer.ReadByte(i);
            byte jb = buffer.ReadByte(j);
            buffer.Write(i, jb);
            buffer.Write(j, ib);
        }
    }
}