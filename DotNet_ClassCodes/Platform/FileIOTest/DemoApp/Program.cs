if(args.Length > 1) //stream i/o
{
    using var input = new FileStream(args[0], FileMode.Open);
    using var output = new FileStream(args[1], FileMode.CreateNew);
    byte[] data = new byte[80];
    while(input.Position < input.Length)
    {
        int n = input.Read(data, 0, data.Length);
        Transformer.Encode(data, n);
        output.Write(data, 0, n);
    }
}
else //memory mapped i/o
{
    var fi = new FileInfo(args[0]);
    using var mapping = System.IO.MemoryMappedFiles.MemoryMappedFile.CreateFromFile(fi.FullName);
    using var view = mapping.CreateViewAccessor(0, fi.Length);
    Transformer.Reverse(view);
}
