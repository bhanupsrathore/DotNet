class Program
{
    static void DoWork(int count)
    {
        int t = Environment.TickCount + 100 * count;
        while(Environment.TickCount < t);
    }

    static string client;

    static void HandleJob(int jid)
    {
        Console.WriteLine("Thread<{0}> has accepted job<{1}> for user<{2}>", Thread.CurrentThread.ManagedThreadId, jid, client);
        DoWork(jid);
        Console.WriteLine("Thread<{0}> has finished job<{1}> for user<{2}>", Thread.CurrentThread.ManagedThreadId, jid, client);
    }

    static void Main(string[] args)
    {
        int n = args.Length > 0 ? int.Parse(args[0]) : 10;
        client = "Jack";
        HandleJob(n);
        client = "Jill";
        HandleJob(15);
    }
}