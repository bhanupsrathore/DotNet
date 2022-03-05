class Program
{
    static object Select(int choice, object first, object second)
    {
        if((choice % 2) == 1)
            return first;
        return second;
    }

    static void Main(string[] args)
    {
        int s = int.Parse(args[0]);
        string ss = (string)Select(s, "Monday", "Friday");
        Console.WriteLine("Selected string = {0}", ss);
        double sd = (double)Select(s, 4.56, 6.54); //unboxing double from object
        Console.WriteLine("Selected double = {0}", sd);
        Select(s, "Sunday", 12.3);
    }
}