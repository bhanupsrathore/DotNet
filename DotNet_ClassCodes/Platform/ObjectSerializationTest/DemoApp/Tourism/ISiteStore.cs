namespace Tourism;

public interface ISiteStore
{
    bool Save(Site site);

    Site Load(string name);
}
