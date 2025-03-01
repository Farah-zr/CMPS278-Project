using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMPS278Project.Migrations
{
    public partial class UpdateSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brownies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brownies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CakePops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CakePops", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    MenuItemId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CinnamonRolls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CinnamonRolls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cookies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cookies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cupcakes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cupcakes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brownies",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 1, "the moist chewy interior filled with biscoff spread, and topped with biscoff cookies", "Biscoff Brownies", 5.5 });

            migrationBuilder.InsertData(
                table: "Brownies",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 2, "loaded with oreo pieces and chocolate chunks", "Fudgy Oreo Brownies", 5.5 });

            migrationBuilder.InsertData(
                table: "Brownies",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 3, "made with our favorite fudgy brownies recipe and swirled with caramel-like dulce de leche.", "Dulce De Leche Brownies", 6.0 });

            migrationBuilder.InsertData(
                table: "Brownies",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 4, "chewy and fudgy brownies loaded with chocolate chunks, melted chocolate, and cocoa powder", "Fudgy Brownies with Chocolate Chunks", 5.0 });

            migrationBuilder.InsertData(
                table: "CakePops",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 1, "moist and fudgy chocolate cake pop filled with caramel toffee dipped in chocolate and topped with salted crushed pretzels", "Chocolate Caramel Cake Pop", 0.65000000000000002 });

            migrationBuilder.InsertData(
                table: "CakePops",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 2, "moist and fudgy chocolate cake pop filled with peanut butter dipped in chocolate and topped with caramelized peanut brittle", "Peanut Butter Chocolate Cake Pop", 0.65000000000000002 });

            migrationBuilder.InsertData(
                table: "CakePops",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 3, "chocolate cake pop dipped in milk chocolate", "Chocolate Cake Pop", 0.5 });

            migrationBuilder.InsertData(
                table: "CakePops",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 4, "vanilla cake pop dipped in white chocolate", "Vanilla Cake Pop", 0.5 });

            migrationBuilder.InsertData(
                table: "CakePops",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 5, "cookie dough cake pop filled with nutella dipped in milk chocolate", "Cookie Dough Nutella Cake Pop", 0.69999999999999996 });

            migrationBuilder.InsertData(
                table: "CakePops",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 6, "red velvet cake pop dipped in milk chocolate", "Red Velvet Cake Pop", 0.5 });

            migrationBuilder.InsertData(
                table: "CakePops",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 7, "cookie dough cake pop dipped in milk chocolate", "Cookie Dough Cake Pop", 0.65000000000000002 });

            migrationBuilder.InsertData(
                table: "CakePops",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 8, "red velvet cake pop filled with nutella dipped in milk chocolate", "Red Velvet Nutella Cake Pop", 0.69999999999999996 });

            migrationBuilder.InsertData(
                table: "CinnamonRolls",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 1, "", "Classic Cinnamon Roll", 7.0 });

            migrationBuilder.InsertData(
                table: "CinnamonRolls",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 2, "", "Confetti Cinnamon Roll", 7.0 });

            migrationBuilder.InsertData(
                table: "CinnamonRolls",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 3, "", "Nutella Cinnamon Roll", 8.0 });

            migrationBuilder.InsertData(
                table: "CinnamonRolls",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 4, "", "Oreo Cinnamon Roll", 8.0 });

            migrationBuilder.InsertData(
                table: "CinnamonRolls",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 5, "", "Caramel Cinnamon Roll", 8.0 });

            migrationBuilder.InsertData(
                table: "Cookies",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 1, "", "Almond Cookie", 6.0 });

            migrationBuilder.InsertData(
                table: "Cookies",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 2, "", "Chocolate Chip Cookie", 6.0 });

            migrationBuilder.InsertData(
                table: "Cookies",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 3, "", "Biscoff Cookie", 6.5 });

            migrationBuilder.InsertData(
                table: "Cookies",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 4, "", "Blueberry Cookie", 6.5 });

            migrationBuilder.InsertData(
                table: "Cookies",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 5, "", "Brownie Cookie", 6.5 });

            migrationBuilder.InsertData(
                table: "Cookies",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 6, "", "Coconut Cookie", 6.0 });

            migrationBuilder.InsertData(
                table: "Cupcakes",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 1, "vanilla buttercream cupcake topped with candy", "Vanilla Buttercream Cupcake", 6.5 });

            migrationBuilder.InsertData(
                table: "Cupcakes",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 2, "", "Strawberry Filled Cupcake", 6.0 });

            migrationBuilder.InsertData(
                table: "Cupcakes",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 3, "", "Nutella Cupcake", 7.0 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Brownies");

            migrationBuilder.DropTable(
                name: "CakePops");

            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "CinnamonRolls");

            migrationBuilder.DropTable(
                name: "Cookies");

            migrationBuilder.DropTable(
                name: "Cupcakes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
