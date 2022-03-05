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

    public Task<long> ComputeAsync(int first, int last)
    {
        //running Compute as a separate task executed by a worker thread
        return Task<long>.Run(() => Compute(first, last));
    }
}

class Program
{
    //an async qualified method yields a task using await statement 
    static async Task DoComputation(int upper)
    {
        Console.Write("Computing...");
        var c = new Computation();
        var w = new System.Diagnostics.Stopwatch();
        w.Start();
        //await operator yields a task that continues execution 
        //of susequent code after its operand task is completed
        long r = await c.ComputeAsync(1, upper);
        w.Stop();
        Console.WriteLine("Done!");
        Console.WriteLine("Result = {0}, computed in {1:0.000} seconds", r, w.Elapsed.TotalSeconds);
    }

    static void Main(string[] args)
    {
        int n = args.Length > 0 ? int.Parse(args[0]) : 10;
        var job = DoComputation(n);
        while(!job.IsCompleted)
        {
            Console.Write(".");
            Thread.Sleep(500);
        }
    }
}