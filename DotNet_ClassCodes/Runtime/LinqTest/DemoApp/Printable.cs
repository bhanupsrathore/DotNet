static class Printable
{
    public static IEnumerable<E> PrintEach<E>(this IEnumerable<E> source)
    {
        foreach(var item in source)
            Console.WriteLine(item);
        Console.WriteLine("-----------------------");
        return source;
    }
}
