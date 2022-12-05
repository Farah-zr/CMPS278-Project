﻿// <auto-generated />
using Menu.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CMPS278Project.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.11");

            modelBuilder.Entity("Brownies.Models.Brownie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Brownies", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 10,
                            Description = "the moist chewy interior bursting with cookie butter flavor topped with biscoff spread and a lotus biscuit",
                            Name = "Biscoff Blondies",
                            Price = 73000
                        },
                        new
                        {
                            Id = 11,
                            Description = "three layer brownie, with a layer of nutella brownie, layer edible cookie dough and layer chocolate chip cookie topped with nutella",
                            Name = "Brookie",
                            Price = 75000
                        },
                        new
                        {
                            Id = 12,
                            Description = "",
                            Name = "Nutella Brownies",
                            Price = 70000
                        },
                        new
                        {
                            Id = 13,
                            Description = "",
                            Name = "Caramel Twix Brownies",
                            Price = 70000
                        });
                });

            modelBuilder.Entity("CakePops.Models.CakePop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("CakePops", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "moist and fudgy chocolate cake pop filled with caramel toffee dipped in chocolate and topped with salted crushed pretzels",
                            Name = "Chocolate Caramel",
                            Price = 50000
                        },
                        new
                        {
                            Id = 2,
                            Description = "moist and fudgy chocolate cake pop filled with peanut butter dipped in chocolate and topped with caramelized peanut brittle",
                            Name = "The Peanut Butter Chocolate",
                            Price = 50000
                        },
                        new
                        {
                            Id = 3,
                            Description = "",
                            Name = "Rainbow Cake Pop",
                            Price = 50000
                        },
                        new
                        {
                            Id = 4,
                            Description = "chocolate cake pop dipped in milk chocolate",
                            Name = "Chocolate",
                            Price = 45000
                        },
                        new
                        {
                            Id = 5,
                            Description = "vanilla cake pop dipped in white chocolate",
                            Name = "Vanilla",
                            Price = 45000
                        },
                        new
                        {
                            Id = 6,
                            Description = "cookie dough cake pop filled with nutella dipped in milk chocolate",
                            Name = "Cookie Dough Nutella",
                            Price = 55000
                        },
                        new
                        {
                            Id = 7,
                            Description = "red velvet cake pop dipped in milk chocolate",
                            Name = "Red Velvet",
                            Price = 45000
                        },
                        new
                        {
                            Id = 8,
                            Description = "cookie dough cake pop dipped in milk chocolate",
                            Name = "Cookie Dough",
                            Price = 46000
                        },
                        new
                        {
                            Id = 9,
                            Description = "red velvet cake pop filled with nutella dipped in milk chocolate",
                            Name = "Red Velvet Nutella",
                            Price = 55000
                        });
                });

            modelBuilder.Entity("CinnamonRolls.Models.CinnamonRoll", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("CinnamonRolls", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 14,
                            Description = "",
                            Name = "Oreo Cinnamon Roll",
                            Price = 105000
                        },
                        new
                        {
                            Id = 15,
                            Description = "",
                            Name = "Red Velvet Cinnamon Roll",
                            Price = 105000
                        },
                        new
                        {
                            Id = 16,
                            Description = "",
                            Name = "Lotus Cinnamon Roll",
                            Price = 105000
                        },
                        new
                        {
                            Id = 17,
                            Description = "",
                            Name = "Nutella Cinnamon Roll",
                            Price = 105000
                        });
                });

            modelBuilder.Entity("Cookies.Models.Cookie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Cookies", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 18,
                            Description = "churros based cookie dough stuffed with premium Belgian chocolate topped with cinnamon and sugar",
                            Name = "Churro Cookie",
                            Price = 70000
                        },
                        new
                        {
                            Id = 19,
                            Description = "chocolate chip cookie filled with red velvet cake pop",
                            Name = "Chocolate Chip with Cake Pop",
                            Price = 65000
                        },
                        new
                        {
                            Id = 20,
                            Description = "",
                            Name = "Half Chocolate Chip, Half Red Velvet Cookie",
                            Price = 65000
                        },
                        new
                        {
                            Id = 21,
                            Description = "plain soft red velvet cookie",
                            Name = "Red Velvet",
                            Price = 65000
                        },
                        new
                        {
                            Id = 22,
                            Description = "red velvet cookie filled with oreo",
                            Name = "Red Velvet Oreo",
                            Price = 65000
                        },
                        new
                        {
                            Id = 23,
                            Description = "red velvet cookie filled with nutella spread",
                            Name = "Red Velvet Nutella",
                            Price = 65000
                        },
                        new
                        {
                            Id = 24,
                            Description = "chocolate chip cookie filled with m&m's",
                            Name = "M&M's",
                            Price = 65000
                        },
                        new
                        {
                            Id = 25,
                            Description = "chocolate chip cookie filled with lotus spread",
                            Name = "Lotus",
                            Price = 65000
                        },
                        new
                        {
                            Id = 26,
                            Description = "chocolate chip cookie filled with snickers",
                            Name = "Snickers",
                            Price = 65000
                        },
                        new
                        {
                            Id = 27,
                            Description = "chocolate chip cookie filled with mars",
                            Name = "Mars",
                            Price = 65000
                        },
                        new
                        {
                            Id = 28,
                            Description = "chocolate chip cookie filled with kinder bueno",
                            Name = "Bueno",
                            Price = 65000
                        },
                        new
                        {
                            Id = 29,
                            Description = "chocolate chip cookie filled with twix",
                            Name = "Twix",
                            Price = 65000
                        });
                });

            modelBuilder.Entity("Cupcakes.Models.Cupcake", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Cupcakes", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 30,
                            Description = "vanilla buttercream cupcake topped with candy",
                            Name = "Vanilla Buttercream Cupcake",
                            Price = 60000
                        },
                        new
                        {
                            Id = 31,
                            Description = "layered red velvet cupcake with raw edible cookie dough between the layers, topped with vanilla buttercream, chunks of cookie dough and drizzled with milk chocolate",
                            Name = "Layered Red Velvet Cookie Dough Cupcake",
                            Price = 60000
                        },
                        new
                        {
                            Id = 32,
                            Description = "layered red velvet cupcake with oreo truffle between the layers, topped with oreo truffle and our homemade chcoclate ganache and mini chocolate chips",
                            Name = "Layered Red Velvet Oreo Cupcake",
                            Price = 62000
                        });
                });

            modelBuilder.Entity("MenuItems.Models.MenuItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Category")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("MenuItems", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = 1,
                            Description = "moist and fudgy chocolate cake pop filled with caramel toffee dipped in chocolate and topped with salted crushed pretzels",
                            Name = "Chocolate Caramel",
                            Price = 50000
                        },
                        new
                        {
                            Id = 2,
                            Category = 1,
                            Description = "moist and fudgy chocolate cake pop filled with peanut butter dipped in chocolate and topped with caramelized peanut brittle",
                            Name = "The Peanut Butter Chocolate",
                            Price = 50000
                        },
                        new
                        {
                            Id = 3,
                            Category = 1,
                            Description = "",
                            Name = "Rainbow Cake Pop",
                            Price = 50000
                        },
                        new
                        {
                            Id = 4,
                            Category = 1,
                            Description = "chocolate cake pop dipped in milk chocolate",
                            Name = "Chocolate",
                            Price = 45000
                        },
                        new
                        {
                            Id = 5,
                            Category = 1,
                            Description = "vanilla cake pop dipped in white chocolate",
                            Name = "Vanilla",
                            Price = 45000
                        },
                        new
                        {
                            Id = 6,
                            Category = 1,
                            Description = "cookie dough cake pop filled with nutella dipped in milk chocolate",
                            Name = "Cookie Dough Nutella",
                            Price = 55000
                        },
                        new
                        {
                            Id = 7,
                            Category = 1,
                            Description = "red velvet cake pop dipped in milk chocolate",
                            Name = "Red Velvet",
                            Price = 45000
                        },
                        new
                        {
                            Id = 8,
                            Category = 1,
                            Description = "cookie dough cake pop dipped in milk chocolate",
                            Name = "Cookie Dough",
                            Price = 46000
                        },
                        new
                        {
                            Id = 9,
                            Category = 1,
                            Description = "red velvet cake pop filled with nutella dipped in milk chocolate",
                            Name = "Red Velvet Nutella",
                            Price = 55000
                        },
                        new
                        {
                            Id = 10,
                            Category = 2,
                            Description = "the moist chewy interior bursting with cookie butter flavor topped with biscoff spread and a lotus biscuit",
                            Name = "Biscoff Blondies",
                            Price = 73000
                        },
                        new
                        {
                            Id = 11,
                            Category = 2,
                            Description = "three layer brownie, with a layer of nutella brownie, layer edible cookie dough and layer chocolate chip cookie topped with nutella",
                            Name = "Brookie",
                            Price = 75000
                        },
                        new
                        {
                            Id = 12,
                            Category = 2,
                            Description = "",
                            Name = "Nutella Brownies",
                            Price = 70000
                        },
                        new
                        {
                            Id = 13,
                            Category = 2,
                            Description = "",
                            Name = "Caramel Twix Brownies",
                            Price = 70000
                        },
                        new
                        {
                            Id = 14,
                            Category = 3,
                            Description = "",
                            Name = "Oreo Cinnamon Roll",
                            Price = 105000
                        },
                        new
                        {
                            Id = 15,
                            Category = 3,
                            Description = "",
                            Name = "Red Velvet Cinnamon Roll",
                            Price = 105000
                        },
                        new
                        {
                            Id = 16,
                            Category = 3,
                            Description = "",
                            Name = "Lotus Cinnamon Roll",
                            Price = 105000
                        },
                        new
                        {
                            Id = 17,
                            Category = 3,
                            Description = "",
                            Name = "Nutella Cinnamon Roll",
                            Price = 105000
                        },
                        new
                        {
                            Id = 18,
                            Category = 4,
                            Description = "churros based cookie dough stuffed with premium Belgian chocolate topped with cinnamon and sugar",
                            Name = "Churro Cookie",
                            Price = 70000
                        },
                        new
                        {
                            Id = 19,
                            Category = 4,
                            Description = "chocolate chip cookie filled with red velvet cake pop",
                            Name = "Chocolate Chip with Cake Pop",
                            Price = 65000
                        },
                        new
                        {
                            Id = 20,
                            Category = 4,
                            Description = "",
                            Name = "Half Chocolate Chip, Half Red Velvet Cookie",
                            Price = 65000
                        },
                        new
                        {
                            Id = 21,
                            Category = 4,
                            Description = "plain soft red velvet cookie",
                            Name = "Red Velvet",
                            Price = 65000
                        },
                        new
                        {
                            Id = 22,
                            Category = 4,
                            Description = "red velvet cookie filled with oreo",
                            Name = "Red Velvet Oreo",
                            Price = 65000
                        },
                        new
                        {
                            Id = 23,
                            Category = 4,
                            Description = "red velvet cookie filled with nutella spread",
                            Name = "Red Velvet Nutella",
                            Price = 65000
                        },
                        new
                        {
                            Id = 24,
                            Category = 4,
                            Description = "chocolate chip cookie filled with m&m's",
                            Name = "M&M's",
                            Price = 65000
                        },
                        new
                        {
                            Id = 25,
                            Category = 4,
                            Description = "chocolate chip cookie filled with lotus spread",
                            Name = "Lotus",
                            Price = 65000
                        },
                        new
                        {
                            Id = 26,
                            Category = 4,
                            Description = "chocolate chip cookie filled with snickers",
                            Name = "Snickers",
                            Price = 65000
                        },
                        new
                        {
                            Id = 27,
                            Category = 4,
                            Description = "chocolate chip cookie filled with mars",
                            Name = "Mars",
                            Price = 65000
                        },
                        new
                        {
                            Id = 28,
                            Category = 4,
                            Description = "chocolate chip cookie filled with kinder bueno",
                            Name = "Bueno",
                            Price = 65000
                        },
                        new
                        {
                            Id = 29,
                            Category = 4,
                            Description = "chocolate chip cookie filled with twix",
                            Name = "Twix",
                            Price = 65000
                        },
                        new
                        {
                            Id = 30,
                            Category = 5,
                            Description = "vanilla buttercream cupcake topped with candy",
                            Name = "Vanilla Buttercream Cupcake",
                            Price = 60000
                        },
                        new
                        {
                            Id = 31,
                            Category = 5,
                            Description = "layered red velvet cupcake with raw edible cookie dough between the layers, topped with vanilla buttercream, chunks of cookie dough and drizzled with milk chocolate",
                            Name = "Layered Red Velvet Cookie Dough Cupcake",
                            Price = 60000
                        },
                        new
                        {
                            Id = 32,
                            Category = 5,
                            Description = "layered red velvet cupcake with oreo truffle between the layers, topped with oreo truffle and our homemade chcoclate ganache and mini chocolate chips",
                            Name = "Layered Red Velvet Oreo Cupcake",
                            Price = 62000
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
