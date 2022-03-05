void PrintStack(IStackReader<object> items)
{
    for(int i = 0; !items.Empty(); ++i)
    {
        if(i > 0) Console.Write(", ");
        Console.Write(items.Pop());
    }
    Console.WriteLine();
}

SimpleStack<string> a = new SimpleStack<string>();
a.Push("Monday");
a.Push("Tuesday");
a.Push("Wednesday");
a.Push("Thursday");
a.Push("Friday");
PrintStack(a);
SimpleStack<Interval> b = new SimpleStack<Interval>();
b.Push(new Interval(4, 31));
b.Push(new Interval(7, 42));
b.Push(new Interval(6, 23));
b.Push(new Interval(5, 14));
PrintStack(b);
