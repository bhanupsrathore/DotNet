partial class Interval
{
    public static Interval operator+(Interval lhs, Interval rhs)
    {
        return new Interval(lhs.Minutes + rhs.Minutes, lhs.Seconds + rhs.Seconds);
    }
}

class Program
{
    static void PrintInfo(string label, object source)
    {
        Console.WriteLine("{0} = {1}", label, source.ToString());
    }

    static void Main(string[] args)
    {
        Interval a = new Interval(4, 5);
        var b = new Interval(6, 50); //type inference for local variable
        Interval c = new (3, 65);
        var d = b;

        PrintInfo("Interval a", a);
        PrintInfo("Interval b", b);
        PrintInfo("Interval c", c);
        PrintInfo("Interval d", d);
        PrintInfo("Total", a + b + c + d);

        Console.WriteLine("a is identical to b: {0}", ReferenceEquals(a, b));
        Console.WriteLine("a is identical to c: {0}", ReferenceEquals(a, c));
        Console.WriteLine("d is identical to b: {0}", ReferenceEquals(d, b));

        Console.WriteLine("a is equal to b: {0}", a.GetHashCode() == b.GetHashCode() && a.Equals(b));
        Console.WriteLine("a is equal to c: {0}", a.GetHashCode() == c.GetHashCode() && a.Equals(c));
        Console.WriteLine("d is equal to b: {0}", d.GetHashCode() == b.GetHashCode() && d.Equals(b));

        if(args.Length > 1)
        {
            Rectangle frame;
            frame.Length = float.Parse(args[0]);
            frame.Breadth = float.Parse(args[1]);
            PrintInfo("Your Rectangle", frame); //converting value type to reference type through boxing
        }
    }
}