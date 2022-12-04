using MenuItems.Models;
using Microsoft.EntityFrameworkCore;

namespace Menu.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options) { }

    public DbSet<MenuItem> MenuItems { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<MenuItem>().HasData(
            new MenuItem { Id = 1, Category = "Cake Pops", Name = "Chocolate Caramel", Description = "", Price = 50000 },
            new MenuItem { Id = 2, Category = "Cake Pops", Name = "Chocolate Caramel", Description = "", Price = 50000 },
            new MenuItem { Id = 3, Category = "Cake Pops", Name = "Chocolate Caramel", Description = "", Price = 50000 }

        );
    }
}