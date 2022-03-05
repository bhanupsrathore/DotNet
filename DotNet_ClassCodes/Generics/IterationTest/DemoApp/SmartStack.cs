//In order to enable for-each iteration on its object a class must include
//a public definition of GetEnumerator method whose return type 
//supports MoveNext method and Current property as defined in 
//System.Collections.Generic.IEnumerator<V> interface
class SmartStack<V>
{
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

    public IEnumerator<V> GetEnumerator()
    {
        for(Node n = top; n != null; n = n.Below)
        {
            //the value is returned through auto-generated implementation of IEnumerator<V>
            yield return n.Value;
        }
    }
}