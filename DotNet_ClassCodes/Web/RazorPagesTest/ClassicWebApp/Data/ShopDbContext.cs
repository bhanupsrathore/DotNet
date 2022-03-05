using Microsoft.EntityFrameworkCore;

namespace ClassicWebApp.Data;

public class ShopDbContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }

    public DbSet<Order> Orders { get; set; }

    public ShopDbContext(DbContextOptions options) : base(options)
    {   
    }
}