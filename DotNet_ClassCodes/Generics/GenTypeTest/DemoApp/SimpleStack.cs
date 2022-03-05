interface IStackReader<out V> //IStackReader<Derived> ---> IStackReader<Base>
{
    V Pop();
    bool Empty();
}

interface IStackWriter<in V> //IStackReader<Base> ---> IStackReader<Derived>
{
    void Push(V item);
    int Count();
}

class SimpleStack<V> : IStackReader<V> 
{
    //nested class - can only refer to static member of outer class
    class Node
    {
        internal V Value;
        internal Node Below;
    }

    private Node top;

    public void Push(V item)
    {
        top = new Node {Value = item, Below = top};
    }

    public V Pop()
    {
        V item = top.Value;
        top = top.Below;
        return item;
    }

    public bool Empty()
    {
        return top is null;
    }
}