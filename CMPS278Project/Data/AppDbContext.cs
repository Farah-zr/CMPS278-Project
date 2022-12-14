using MenuItems.Models;
using CakePops.Models;
using Brownies.Models;
using CinnamonRolls.Models;
using Cookies.Models;
using Cupcakes.Models;
using CartItems.Models;
using Users.Models;
using CategoryEnum.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Menu.Data;

public class AppDbContext : IdentityDbContext<User>
{
    public AppDbContext(DbContextOptions options) : base(options) { }
    public DbSet<MenuItem> MenuItems { get; set; } = null!;
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
            new CakePop { Id = 1, Name = "Chocolate Caramel", Description = "moist and fudgy chocolate cake pop filled with caramel toffee dipped in chocolate and topped with salted crushed pretzels", Price = 50000 },
            new CakePop { Id = 2, Name = "The Peanut Butter Chocolate", Description = "moist and fudgy chocolate cake pop filled with peanut butter dipped in chocolate and topped with caramelized peanut brittle", Price = 50000 },
            new CakePop { Id = 3, Name = "Rainbow Cake Pop", Description = "", Price = 50000 },
            new CakePop { Id = 4, Name = "Chocolate", Description = "chocolate cake pop dipped in milk chocolate", Price = 45000 },
            new CakePop { Id = 5, Name = "Vanilla", Description = "vanilla cake pop dipped in white chocolate", Price = 45000 },
            new CakePop { Id = 6, Name = "Cookie Dough Nutella", Description = "cookie dough cake pop filled with nutella dipped in milk chocolate", Price = 55000 },
            new CakePop { Id = 7, Name = "Red Velvet", Description = "red velvet cake pop dipped in milk chocolate", Price = 45000 },
            new CakePop { Id = 8, Name = "Cookie Dough", Description = "cookie dough cake pop dipped in milk chocolate", Price = 46000 },
            new CakePop { Id = 9, Name = "Red Velvet Nutella", Description = "red velvet cake pop filled with nutella dipped in milk chocolate", Price = 55000 }
        );
        builder.Entity<Brownie>().ToTable("Brownies").HasData(
            new Brownie { Id = 10, Name = "Biscoff Blondies", Description = "the moist chewy interior bursting with cookie butter flavor topped with biscoff spread and a lotus biscuit", Price = 73000 },
            new Brownie { Id = 11, Name = "Brookie", Description = "three layer brownie, with a layer of nutella brownie, layer edible cookie dough and layer chocolate chip cookie topped with nutella", Price = 75000 },
            new Brownie { Id = 12, Name = "Nutella Brownies", Description = "", Price = 70000 },
            new Brownie { Id = 13, Name = "Caramel Twix Brownies", Description = "", Price = 70000 }
        );
        builder.Entity<CinnamonRoll>().ToTable("CinnamonRolls").HasData(
            new CinnamonRoll { Id = 14, Name = "Oreo Cinnamon Roll", Description = "", Price = 105000 },
            new CinnamonRoll { Id = 15, Name = "Red Velvet Cinnamon Roll", Description = "", Price = 105000 },
            new CinnamonRoll { Id = 16, Name = "Lotus Cinnamon Roll", Description = "", Price = 105000 },
            new CinnamonRoll { Id = 17, Name = "Nutella Cinnamon Roll", Description = "", Price = 105000 }
        );
        builder.Entity<Cookie>().ToTable("Cookies").HasData(
            new Cookie { Id = 18, Name = "Churro Cookie", Description = "churros based cookie dough stuffed with premium Belgian chocolate topped with cinnamon and sugar", Price = 70000 },
            new Cookie { Id = 19, Name = "Chocolate Chip with Cake Pop", Description = "chocolate chip cookie filled with red velvet cake pop", Price = 65000 },
            new Cookie { Id = 20, Name = "Half Chocolate Chip, Half Red Velvet Cookie", Description = "", Price = 65000 },
            new Cookie { Id = 21, Name = "Red Velvet", Description = "plain soft red velvet cookie", Price = 65000 },
            new Cookie { Id = 22, Name = "Red Velvet Oreo", Description = "red velvet cookie filled with oreo", Price = 65000 },
            new Cookie { Id = 23, Name = "Red Velvet Nutella", Description = "red velvet cookie filled with nutella spread", Price = 65000 },
            new Cookie { Id = 24, Name = "M&M's", Description = "chocolate chip cookie filled with m&m's", Price = 65000 },
            new Cookie { Id = 25, Name = "Lotus", Description = "chocolate chip cookie filled with lotus spread", Price = 65000 },
            new Cookie { Id = 26, Name = "Snickers", Description = "chocolate chip cookie filled with snickers", Price = 65000 },
            new Cookie { Id = 27, Name = "Mars", Description = "chocolate chip cookie filled with mars", Price = 65000 },
            new Cookie { Id = 28, Name = "Bueno", Description = "chocolate chip cookie filled with kinder bueno", Price = 65000 },
            new Cookie { Id = 29, Name = "Twix", Description = "chocolate chip cookie filled with twix", Price = 65000 }
        );
        builder.Entity<Cupcake>().ToTable("Cupcakes").HasData(
            new Cupcake { Id = 30, Name = "Vanilla Buttercream Cupcake", Description = "vanilla buttercream cupcake topped with candy", Price = 60000 },
            new Cupcake { Id = 31, Name = "Layered Red Velvet Cookie Dough Cupcake", Description = "layered red velvet cupcake with raw edible cookie dough between the layers, topped with vanilla buttercream, chunks of cookie dough and drizzled with milk chocolate", Price = 60000 },
            new Cupcake { Id = 32, Name = "Layered Red Velvet Oreo Cupcake", Description = "layered red velvet cupcake with oreo truffle between the layers, topped with oreo truffle and our homemade chcoclate ganache and mini chocolate chips", Price = 62000 }
        );
        builder.Entity<MenuItem>().ToTable("MenuItems").HasData(
            new MenuItem { Id = 1, Category = Category.CakePops, Name = "Chocolate Caramel", Description = "moist and fudgy chocolate cake pop filled with caramel toffee dipped in chocolate and topped with salted crushed pretzels", Price = 50000 },
            new MenuItem { Id = 2, Category = Category.CakePops, Name = "The Peanut Butter Chocolate", Description = "moist and fudgy chocolate cake pop filled with peanut butter dipped in chocolate and topped with caramelized peanut brittle", Price = 50000 },
            new MenuItem { Id = 3, Category = Category.CakePops, Name = "Rainbow Cake Pop", Description = "", Price = 50000 },
            new MenuItem { Id = 4, Category = Category.CakePops, Name = "Chocolate", Description = "chocolate cake pop dipped in milk chocolate", Price = 45000 },
            new MenuItem { Id = 5, Category = Category.CakePops, Name = "Vanilla", Description = "vanilla cake pop dipped in white chocolate", Price = 45000 },
            new MenuItem { Id = 6, Category = Category.CakePops, Name = "Cookie Dough Nutella", Description = "cookie dough cake pop filled with nutella dipped in milk chocolate", Price = 55000 },
            new MenuItem { Id = 7, Category = Category.CakePops, Name = "Red Velvet", Description = "red velvet cake pop dipped in milk chocolate", Price = 45000 },
            new MenuItem { Id = 8, Category = Category.CakePops, Name = "Cookie Dough", Description = "cookie dough cake pop dipped in milk chocolate", Price = 46000 },
            new MenuItem { Id = 9, Category = Category.CakePops, Name = "Red Velvet Nutella", Description = "red velvet cake pop filled with nutella dipped in milk chocolate", Price = 55000 },
            new MenuItem { Id = 10, Category = Category.Brownies, Name = "Biscoff Blondies", Description = "the moist chewy interior bursting with cookie butter flavor topped with biscoff spread and a lotus biscuit", Price = 73000 },
            new MenuItem { Id = 11, Category = Category.Brownies, Name = "Brookie", Description = "three layer brownie, with a layer of nutella brownie, layer edible cookie dough and layer chocolate chip cookie topped with nutella", Price = 75000 },
            new MenuItem { Id = 12, Category = Category.Brownies, Name = "Nutella Brownies", Description = "", Price = 70000 },
            new MenuItem { Id = 13, Category = Category.Brownies, Name = "Caramel Twix Brownies", Description = "", Price = 70000 },
            new MenuItem { Id = 14, Category = Category.CinnamonRolls, Name = "Oreo Cinnamon Roll", Description = "", Price = 105000 },
            new MenuItem { Id = 15, Category = Category.CinnamonRolls, Name = "Red Velvet Cinnamon Roll", Description = "", Price = 105000 },
            new MenuItem { Id = 16, Category = Category.CinnamonRolls, Name = "Lotus Cinnamon Roll", Description = "", Price = 105000 },
            new MenuItem { Id = 17, Category = Category.CinnamonRolls, Name = "Nutella Cinnamon Roll", Description = "", Price = 105000 },
            new MenuItem { Id = 18, Category = Category.Cookies, Name = "Churro Cookie", Description = "churros based cookie dough stuffed with premium Belgian chocolate topped with cinnamon and sugar", Price = 70000 },
            new MenuItem { Id = 19, Category = Category.Cookies, Name = "Chocolate Chip with Cake Pop", Description = "chocolate chip cookie filled with red velvet cake pop", Price = 65000 },
            new MenuItem { Id = 20, Category = Category.Cookies, Name = "Half Chocolate Chip, Half Red Velvet Cookie", Description = "", Price = 65000 },
            new MenuItem { Id = 21, Category = Category.Cookies, Name = "Red Velvet", Description = "plain soft red velvet cookie", Price = 65000 },
            new MenuItem { Id = 22, Category = Category.Cookies, Name = "Red Velvet Oreo", Description = "red velvet cookie filled with oreo", Price = 65000 },
            new MenuItem { Id = 23, Category = Category.Cookies, Name = "Red Velvet Nutella", Description = "red velvet cookie filled with nutella spread", Price = 65000 },
            new MenuItem { Id = 24, Category = Category.Cookies, Name = "M&M's", Description = "chocolate chip cookie filled with m&m's", Price = 65000 },
            new MenuItem { Id = 25, Category = Category.Cookies, Name = "Lotus", Description = "chocolate chip cookie filled with lotus spread", Price = 65000 },
            new MenuItem { Id = 26, Category = Category.Cookies, Name = "Snickers", Description = "chocolate chip cookie filled with snickers", Price = 65000 },
            new MenuItem { Id = 27, Category = Category.Cookies, Name = "Mars", Description = "chocolate chip cookie filled with mars", Price = 65000 },
            new MenuItem { Id = 28, Category = Category.Cookies, Name = "Bueno", Description = "chocolate chip cookie filled with kinder bueno", Price = 65000 },
            new MenuItem { Id = 29, Category = Category.Cookies, Name = "Twix", Description = "chocolate chip cookie filled with twix", Price = 65000 },
            new MenuItem { Id = 30, Category = Category.Cupcakes, Name = "Vanilla Buttercream Cupcake", Description = "vanilla buttercream cupcake topped with candy", Price = 60000 },
            new MenuItem { Id = 31, Category = Category.Cupcakes, Name = "Layered Red Velvet Cookie Dough Cupcake", Description = "layered red velvet cupcake with raw edible cookie dough between the layers, topped with vanilla buttercream, chunks of cookie dough and drizzled with milk chocolate", Price = 60000 },
            new MenuItem { Id = 32, Category = Category.Cupcakes, Name = "Layered Red Velvet Oreo Cupcake", Description = "layered red velvet cupcake with oreo truffle between the layers, topped with oreo truffle and our homemade chcoclate ganache and mini chocolate chips", Price = 62000 }
        );
    }
}