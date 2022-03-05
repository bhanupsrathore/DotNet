record Item(string Name, string Brand);

record Customer(string Id, double Purchase, int Rating);

class Program
{
    static void PrintAsXml(Item info)
    {
        Console.WriteLine("<Item>");
        Console.WriteLine("  <Name>{0}</Name>", info.Name);
        Console.WriteLine("  <Brand>{0}</Brand>", info.Brand);
        Console.WriteLine("</Item>");
        Console.WriteLine();
    }

    static void PrintAsXml(Customer info)
    {
        Console.WriteLine("<Customer>");
        Console.WriteLine("  <Id>{0}</Id>", info.Id);
        Console.WriteLine("  <Purchase>{0}</Purchase>", info.Purchase);
        Console.WriteLine("  <Rating>{0}</Rating>", info.Rating);
        Console.WriteLine("</Customer>");
        Console.WriteLine();
    }
    
    static void Main(string[] args)
    {
        PrintAsXml(new Item("cpu", "Intel"));
        PrintAsXml(new Item("ssd", "Samsung"));
        PrintAsXml(new Customer("Jack", 23000, 4));
    }
}