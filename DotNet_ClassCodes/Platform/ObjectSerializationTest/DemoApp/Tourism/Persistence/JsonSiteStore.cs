using System.Text.Json;

namespace Tourism.Persistence;

public class JsonSiteStore : ISiteStore
{
    public bool Save(Site site)
    {
        string doc = site.Id + ".json";
        try
        {
            using var writer = File.OpenWrite(doc);
            //serializer will accumulate data from public instance fields and properties
            //not define with JsonIgnoreAttribute
            JsonSerializer.Serialize(writer, site, new JsonSerializerOptions { WriteIndented = true});
            return true;
        }
        catch
        {
            return false;
        }
    }

    public Site Load(string name)
    {
        string doc = name + ".json";
        try
        {
            using var reader = File.OpenRead(doc);
            return JsonSerializer.Deserialize<Site>(reader);
        }
        catch
        {
            return new Site { Id = name };
        }
    }
}