using System.Xml.Linq;

class Shop
{
    private XElement doc;

    private Shop(string source) => doc = XElement.Load(source);

    public static Shop Open(string source) => new Shop(source);

    public string GetItemInfo(string name)
    {
        return doc.Elements("entry")
                .Where(e => (string)e.Attribute("key") == name)
                .Select(e => e.Value)
                .FirstOrDefault();
    }
}