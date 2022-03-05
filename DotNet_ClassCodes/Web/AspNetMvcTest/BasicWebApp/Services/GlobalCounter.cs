namespace BasicWebApp.Services;

public class GlobalCounter : ICounter
{
    private int count = 0;

    public int CountNext(string id)
    {
        return Interlocked.Increment(ref count);
    }
}
