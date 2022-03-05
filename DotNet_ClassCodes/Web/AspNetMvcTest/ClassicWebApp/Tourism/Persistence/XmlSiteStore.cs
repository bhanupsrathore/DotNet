using System.Xml;
using System.Xml.Serialization;

namespace Tourism.Persistence;

public class XmlSiteStore : ISiteStore
{
    //XmlSerializer will serialize/deserialize object of the specified type
    //if it supports parameter-less constructor
    private static XmlSerializer serializer = new XmlSerializer(typeof(Site));

    public bool Save(Site site)
    {
        string doc = site.Id + ".xml";
        try
        {
            using var writer = XmlWriter.Create(doc, new XmlWriterSettings { Indent = true});
            //serializer will accumulate data from public instance fields and properties which
            //are not defined with XmlIgnoreAttribute
            serializer.Serialize(writer, site);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public Site Load(string name)
    {
        string doc = name + ".xml";
        try
        {
            using var reader = XmlReader.Create(doc);
            return (Site)serializer.Deserialize(reader);
        }
        catch
        {
            return new Site { Id = name };
        }
    }

}
