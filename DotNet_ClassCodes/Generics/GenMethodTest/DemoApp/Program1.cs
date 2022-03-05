class Program
{
    static string Select(int choice, string first, string second)
    {
        if((choice % 2) == 1)
            return first;
        return second;
    }

    static double Select(int choice, double first, double second)
    {
        if((choice % 2) == 1)
            return first;
        return second;
    }

    static void Main(string[] args)
    {
        int s = int.Parse(args[0]);
        string ss = Select(s, "Monday", "Friday");
        Console.WriteLine("Selected string = {0}", ss);
        double sd = Select(s, 4.56, 6.54);
        Console.WriteLine("Selected double = {0}", sd);
        //Select(s, "Sunday", 12.3);
    }
}