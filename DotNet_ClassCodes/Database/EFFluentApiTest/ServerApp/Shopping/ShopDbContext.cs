using Microsoft.EntityFrameworkCore;

namespace Shopping;

public class ShopDbContext : DbContext
{
    public DbSet<Order> Orders { get; set; }

    public DbSet<Counter> Counters { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=(localdb)\SqlXE;Database=Shop");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>()
            .ToTable("OrderDetail")
            .Property(p => p.Id)
            .HasColumnName("OrderNo");
    }
}
