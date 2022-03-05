class Computation
{
    private static long CalculatedValue(int count)
    {
        int t = Environment.TickCount + 100 * count;
        while(Environment.TickCount < t);
        return count * count;
    }

    public long Compute(int first, int last)
    {
        return Enumerable.Range(first, last)
                .Select(CalculatedValue)
                .Sum();
    }
}

class Program
{
    static void DoComputation(int upper)
    {
        Console.Write("Computing...");
        var c = new Computation();
        var w = new System.Diagnostics.Stopwatch();
        w.Start();
        long r = c.Compute(1, upper);
        w.Stop();
        Console.WriteLine("Done!");
        Console.WriteLine("Result = {0}, computed in {1:0.000} seconds", r, w.Elapsed.TotalSeconds);
    }

    static void Main(string[] args)
    {
        int n = args.Length > 0 ? int.Parse(args[0]) : 10;
        DoComputation(n);
    }
}