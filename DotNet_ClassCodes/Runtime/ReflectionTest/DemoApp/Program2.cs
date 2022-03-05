using System.Reflection;

record Item(string Name, string Brand);

record Customer(string Id, double Purchase, int Rating, string City="Mumba");

class Program
{
    static void PrintAsXml(object info)
    {
        Type t = info.GetType();
        Console.WriteLine("<{0}>", t.Name);
        foreach(PropertyInfo pi in t.GetProperties())
            Console.WriteLine("  <{0}>{1}</{0}>", pi.Name, pi.GetValue(info));
        Console.WriteLine("</{0}>", t.Name);
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        PrintAsXml(new Item("cpu", "Intel"));
        PrintAsXml(new Item("ssd", "Samsung"));
        PrintAsXml(new Customer("Jack", 23000, 4));
    }
}
