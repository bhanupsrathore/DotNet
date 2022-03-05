SmartStack<string> a = new SmartStack<string>();
a.Push("Monday");
a.Push("Tuesday");
a.Push("Wednesday");
a.Push("Thursday");
a.Push("Friday");
for(var e = a.GetEnumerator(); e.MoveNext();)
    Console.WriteLine(e.Current);
//Console.WriteLine(a.Empty());
Console.WriteLine("----------------------");
SmartStack<Interval> b = new SmartStack<Interval>();
b.Push(new Interval(4, 31));
b.Push(new Interval(7, 42));
b.Push(new Interval(6, 23));
b.Push(new Interval(5, 14));
foreach(Interval i in b)
    Console.WriteLine(i);

