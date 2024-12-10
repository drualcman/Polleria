using BlazingPolleria.Model;
using Microsoft.EntityFrameworkCore;

namespace BlazingPolleria.Data;

public class PolloStoreContext : DbContext
{
    public PolloStoreContext(
        DbContextOptions options) : base(options)
    {
    }

    public DbSet<Order> Orders { get; set; }

    public DbSet<Pollo> Pollos { get; set; }

    public DbSet<PolloSpecial> Specials { get; set; }

    public DbSet<Topping> Toppings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configuring a many-to-many special -> topping relationship that is friendly for serialization
        modelBuilder.Entity<PolloTopping>().HasKey(pst => new { pst.PolloId, pst.ToppingId });
        modelBuilder.Entity<PolloTopping>().HasOne<Pollo>().WithMany(ps => ps.Toppings);
        modelBuilder.Entity<PolloTopping>().HasOne(pst => pst.Topping).WithMany();
    }

}


