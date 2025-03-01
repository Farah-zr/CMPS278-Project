using CartItems.Models;
using Users.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using CakePops.Models;
using Brownies.Models;
using CinnamonRolls.Models;
using Cookies.Models;
using Cupcakes.Models;

namespace Menu.Data;

public class AppDbContext : IdentityDbContext<User>
{
    public AppDbContext(DbContextOptions options) : base(options) { }
    public DbSet<CakePop> CakePops { get; set; } = null!;
    public DbSet<Brownie> Brownies { get; set; } = null!;
    public DbSet<CinnamonRoll> CinnamonRolls { get; set; } = null!;
    public DbSet<Cookie> Cookies { get; set; } = null!;
    public DbSet<Cupcake> Cupcakes { get; set; } = null!;
    public DbSet<CartItem> CartItems { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<CakePop>().ToTable("CakePops").HasData(
            new CakePop { Id = 1, Name = "Chocolate Caramel Cake Pop", Description = "moist and fudgy chocolate cake pop filled with caramel toffee dipped in chocolate and topped with salted crushed pretzels", Price = 0.65 },
            new CakePop { Id = 2, Name = "Peanut Butter Chocolate Cake Pop", Description = "moist and fudgy chocolate cake pop filled with peanut butter dipped in chocolate and topped with caramelized peanut brittle", Price = 0.65 },
            new CakePop { Id = 3, Name = "Chocolate Cake Pop", Description = "chocolate cake pop dipped in milk chocolate", Price = 0.5 },
            new CakePop { Id = 4, Name = "Vanilla Cake Pop", Description = "vanilla cake pop dipped in white chocolate", Price = 0.5 },
            new CakePop { Id = 5, Name = "Cookie Dough Nutella Cake Pop", Description = "cookie dough cake pop filled with nutella dipped in milk chocolate", Price = 0.7 },
            new CakePop { Id = 6, Name = "Red Velvet Cake Pop", Description = "red velvet cake pop dipped in milk chocolate", Price = 0.5 },
            new CakePop { Id = 7, Name = "Cookie Dough Cake Pop", Description = "cookie dough cake pop dipped in milk chocolate", Price = 0.65 },
            new CakePop { Id = 8, Name = "Red Velvet Nutella Cake Pop", Description = "red velvet cake pop filled with nutella dipped in milk chocolate", Price = 0.7 }
        );
        builder.Entity<Brownie>().ToTable("Brownies").HasData(
            new Brownie { Id = 1, Name = "Biscoff Brownies", Description = "the moist chewy interior filled with biscoff spread, and topped with biscoff cookies", Price = 5.5 },
            new Brownie { Id = 2, Name = "Fudgy Oreo Brownies", Description = "loaded with oreo pieces and chocolate chunks", Price = 5.5 },
            new Brownie { Id = 3, Name = "Dulce De Leche Brownies", Description = "made with our favorite fudgy brownies recipe and swirled with caramel-like dulce de leche.", Price = 6 },
            new Brownie { Id = 4, Name = "Fudgy Brownies with Chocolate Chunks", Description = "chewy and fudgy brownies loaded with chocolate chunks, melted chocolate, and cocoa powder", Price = 5 }
        );
        builder.Entity<CinnamonRoll>().ToTable("CinnamonRolls").HasData(
            new CinnamonRoll { Id = 1, Name = "Classic Cinnamon Roll", Description = "", Price = 7 },
            new CinnamonRoll { Id = 2, Name = "Confetti Cinnamon Roll", Description = "", Price = 7 },
            new CinnamonRoll { Id = 3, Name = "Nutella Cinnamon Roll", Description = "", Price = 8 },
            new CinnamonRoll { Id = 4, Name = "Oreo Cinnamon Roll", Description = "", Price = 8 },
            new CinnamonRoll { Id = 5, Name = "Caramel Cinnamon Roll", Description = "", Price = 8 }

        );
        builder.Entity<Cookie>().ToTable("Cookies").HasData(
            new Cookie { Id = 1, Name = "Almond Cookie", Description = "", Price = 6 },
            new Cookie { Id = 2, Name = "Chocolate Chip Cookie", Description = "", Price = 6 },
            new Cookie { Id = 3, Name = "Biscoff Cookie", Description = "", Price = 6.5 },
            new Cookie { Id = 4, Name = "Blueberry Cookie", Description = "", Price = 6.5 },
            new Cookie { Id = 5, Name = "Brownie Cookie", Description = "", Price = 6.5 },
            new Cookie { Id = 6, Name = "Coconut Cookie", Description = "", Price = 6 }
        );
        builder.Entity<Cupcake>().ToTable("Cupcakes").HasData(
            new Cupcake { Id = 1, Name = "Vanilla Buttercream Cupcake", Description = "vanilla buttercream cupcake topped with candy", Price = 6.5 },
            new Cupcake { Id = 2, Name = "Strawberry Filled Cupcake", Description = "", Price = 6 },
            new Cupcake { Id = 3, Name = "Nutella Cupcake", Description = "", Price = 7 }
        );
    }
}