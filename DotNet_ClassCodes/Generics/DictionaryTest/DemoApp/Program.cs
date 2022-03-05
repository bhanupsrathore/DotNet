//IDictionary<string, Interval> store = new Dictionary<string, Interval>();
//IDictionary<string, Interval> store = new SortedDictionary<string, Interval>();
IDictionary<string, Interval> store = new SortedList<string, Interval>();
store.Add("monday", new Interval(4, 31));
store.Add("tuesday", new Interval(5, 12));
store.Add("wednesday", new Interval(7, 23));
store.Add("thursday", new Interval(6, 54));
store.Add("friday", new Interval(3, 45));

if(args.Length == 0)
{
    foreach(var i in store)
        Console.WriteLine("{0, -16}{1, 8}", i.Key, i.Value);
}
else
{
    string key = args[0].ToLower();
    if(store.TryGetValue(key, out Interval val))
        Console.WriteLine("Value = {0}", val);
    else
        Console.WriteLine("No such key!");
}
