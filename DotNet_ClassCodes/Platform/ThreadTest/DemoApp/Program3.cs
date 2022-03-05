class Program
{
    static void DoWork(int count)
    {
        int t = Environment.TickCount + 100 * count;
        while(Environment.TickCount < t);
    }

    [ThreadStatic] //each thread will receive separate value for client
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
        Thread child = new Thread(() =>
        {
            client = "Jack";
            HandleJob(n);
        });
        child.IsBackground = n > 25;
        child.Start();
        client = "Jill";
        HandleJob(15);
    }
}