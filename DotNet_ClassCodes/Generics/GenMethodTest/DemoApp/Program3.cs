class Program
{
    //generic Select method with type argument T
    static T Select<T>(int choice, T first, T second)
    {
        if((choice % 2) == 1)
            return first;
        return second;
    }

    static T Select<T>(T first, T second) where T: IComparable<T>
    {
        if(first.CompareTo(second) > 0)
            return first;
        return second;
    }

    static void Main(string[] args)
    {
        if(args.Length > 0)
        {
            int s = int.Parse(args[0]);
            string ss = Select(s, "Monday", "Friday");
            Console.WriteLine("Selected string = {0}", ss);
            double sd = Select(s, 4.56, 6.54); 
            Console.WriteLine("Selected double = {0}", sd);
            //Select(s, "Sunday", 12.3);
        }
        else
        {
            string ss = Select("Monday", "Friday");
            Console.WriteLine("Selected string = {0}", ss);
            double sd = Select(4.56, 6.54); 
            Console.WriteLine("Selected double = {0}", sd);
            Interval si = Select(new Interval(5, 40), new Interval(3, 45));
            Console.WriteLine("Selected Interval = {0}", si);
        }
    }
}