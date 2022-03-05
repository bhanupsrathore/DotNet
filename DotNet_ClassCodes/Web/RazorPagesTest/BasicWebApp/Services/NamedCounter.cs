namespace BasicWebApp.Services;

public class NamedCounter : ICounter
{
    private readonly Dictionary<string, int> _store = new();

    public int CountNext(string id)
    {
        lock(_store)
        {
            _store.TryGetValue(id, out int count);
            _store[id] = ++count;
            return count;
        }
    }
}