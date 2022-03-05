List<Interval> store = new List<Interval>();
store.Add(new Interval(4, 31));
store.Add(new Interval(5, 12));
store.Add(new Interval(7, 23));
store.Add(new Interval(6, 54));
store.Add(new Interval(3, 45));
store.Add(new Interval(2, 151));
store.Sort();
foreach(var i in store)
    Console.WriteLine(i);
Console.WriteLine("Third Interval = {0}", store[2]);
