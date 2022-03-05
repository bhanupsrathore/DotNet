//ISet<Interval> store = new HashSet<Interval>();
//ISet<Interval> store = new SortedSet<Interval>();
ISet<Interval> store = new SortedSet<Interval>(new SecondsComparer());
store.Add(new Interval(4, 31));
store.Add(new Interval(5, 12));
store.Add(new Interval(7, 23));
store.Add(new Interval(6, 54));
store.Add(new Interval(3, 45));
store.Add(new Interval(2, 151));
foreach(var i in store)
    Console.WriteLine(i);
