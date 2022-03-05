using Microsoft.EntityFrameworkCore;

namespace Tourism.Persistence;

public class DbSiteStore : DbContext, ISiteStore
{
    public DbSet<Site> Sites { get; set; }

    public DbSiteStore()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=tour.db");
    }

    public Site Load(string name)
    {
        var site = Sites.Find(name);
        if(site is null)
        {
            site = new Site {Id = name};
            Sites.Add(site);
        }
        else
        {
            Entry(site).Collection(c => c.Visitors).Load(); //explicit loading
        }
        return site;
    }

    public bool Save(Site site)
    {
        SaveChanges();
        return true;
    }
}