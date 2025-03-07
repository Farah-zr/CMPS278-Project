﻿// <auto-generated />
using System;
using Menu.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CMPS278Project.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250307115554_UpdateData")]
    partial class UpdateData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Brownies", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "the moist chewy interior filled with biscoff spread, and topped with biscoff cookies",
                            Name = "Biscoff Brownies",
                            Price = 5.5
                        },
                        new
                        {
                            Id = 2,
                            Description = "loaded with oreo pieces and chocolate chunks",
                            Name = "Fudgy Oreo Brownies",
                            Price = 5.5
                        },
                        new
                        {
                            Id = 3,
                            Description = "made with our favorite fudgy brownies recipe and swirled with caramel-like dulce de leche.",
                            Name = "Dulce De Leche Brownies",
                            Price = 6.0
                        },
                        new
                        {
                            Id = 4,
                            Description = "chewy and fudgy brownies loaded with chocolate chunks, melted chocolate, and cocoa powder",
                            Name = "Fudgy Brownies with Chocolate Chunks",
                            Price = 5.0
                        },
                        new
                        {
                            Id = 5,
                            Description = "",
                            Name = "Sprinkle Brownies",
                            Price = 5.0
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

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("CakePops", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "moist and fudgy chocolate cake pop filled with caramel toffee dipped in chocolate and topped with salted crushed pretzels",
                            Name = "Chocolate Caramel Cake Pop",
                            Price = 0.65000000000000002
                        },
                        new
                        {
                            Id = 2,
                            Description = "moist and fudgy chocolate cake pop filled with peanut butter dipped in chocolate and topped with caramelized peanut brittle",
                            Name = "Peanut Butter Chocolate Cake Pop",
                            Price = 0.65000000000000002
                        },
                        new
                        {
                            Id = 3,
                            Description = "chocolate cake pop dipped in milk chocolate",
                            Name = "Chocolate Cake Pop",
                            Price = 0.5
                        },
                        new
                        {
                            Id = 4,
                            Description = "vanilla cake pop dipped in white chocolate",
                            Name = "Vanilla Cake Pop",
                            Price = 0.5
                        },
                        new
                        {
                            Id = 5,
                            Description = "cookie dough cake pop filled with nutella dipped in milk chocolate",
                            Name = "Cookie Dough Nutella Cake Pop",
                            Price = 0.69999999999999996
                        },
                        new
                        {
                            Id = 6,
                            Description = "red velvet cake pop dipped in milk chocolate",
                            Name = "Red Velvet Cake Pop",
                            Price = 0.5
                        },
                        new
                        {
                            Id = 7,
                            Description = "cookie dough cake pop dipped in milk chocolate",
                            Name = "Cookie Dough Cake Pop",
                            Price = 0.65000000000000002
                        },
                        new
                        {
                            Id = 8,
                            Description = "red velvet cake pop filled with nutella dipped in milk chocolate",
                            Name = "Red Velvet Nutella Cake Pop",
                            Price = 0.69999999999999996
                        });
                });

            modelBuilder.Entity("CartItems.Models.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("MenuItemId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("CartItems");
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

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("CinnamonRolls", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "",
                            Name = "Classic Cinnamon Roll",
                            Price = 7.0
                        },
                        new
                        {
                            Id = 2,
                            Description = "",
                            Name = "Confetti Cinnamon Roll",
                            Price = 7.0
                        },
                        new
                        {
                            Id = 3,
                            Description = "",
                            Name = "Nutella Cinnamon Roll",
                            Price = 8.0
                        },
                        new
                        {
                            Id = 4,
                            Description = "",
                            Name = "Oreo Cinnamon Roll",
                            Price = 8.0
                        },
                        new
                        {
                            Id = 5,
                            Description = "",
                            Name = "Caramel Cinnamon Roll",
                            Price = 8.0
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

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Cookies", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "",
                            Name = "Almond Cookie",
                            Price = 6.0
                        },
                        new
                        {
                            Id = 2,
                            Description = "",
                            Name = "Chocolate Chip Cookie",
                            Price = 6.0
                        },
                        new
                        {
                            Id = 3,
                            Description = "",
                            Name = "Biscoff Cookie",
                            Price = 6.5
                        },
                        new
                        {
                            Id = 4,
                            Description = "",
                            Name = "Blueberry Cookie",
                            Price = 6.5
                        },
                        new
                        {
                            Id = 5,
                            Description = "",
                            Name = "Brownie Cookie",
                            Price = 6.5
                        },
                        new
                        {
                            Id = 6,
                            Description = "",
                            Name = "Coconut Cookie",
                            Price = 6.0
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

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Cupcakes", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "vanilla buttercream cupcake topped with candy",
                            Name = "Vanilla Buttercream Cupcake",
                            Price = 6.5
                        },
                        new
                        {
                            Id = 2,
                            Description = "",
                            Name = "Strawberry Filled Cupcake",
                            Price = 6.0
                        },
                        new
                        {
                            Id = 3,
                            Description = "",
                            Name = "Nutella Cupcake",
                            Price = 7.0
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Users.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Users.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Users.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Users.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Users.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
