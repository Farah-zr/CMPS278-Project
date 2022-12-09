using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMPS278Project.Migrations
{
    public partial class MenuItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brownies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<int>(type: "INTEGER", nullable: false)
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
                    Price = table.Column<int>(type: "INTEGER", nullable: false)
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
                    Price = table.Column<int>(type: "INTEGER", nullable: false)
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
                    Price = table.Column<int>(type: "INTEGER", nullable: false)
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
                    Price = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cupcakes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Brownies",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 10, "the moist chewy interior bursting with cookie butter flavor topped with biscoff spread and a lotus biscuit", "Biscoff Blondies", 73000 });

            migrationBuilder.InsertData(
                table: "Brownies",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 11, "three layer brownie, with a layer of nutella brownie, layer edible cookie dough and layer chocolate chip cookie topped with nutella", "Brookie", 75000 });

            migrationBuilder.InsertData(
                table: "Brownies",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 12, "", "Nutella Brownies", 70000 });

            migrationBuilder.InsertData(
                table: "Brownies",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 13, "", "Caramel Twix Brownies", 70000 });

            migrationBuilder.InsertData(
                table: "CakePops",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 1, "moist and fudgy chocolate cake pop filled with caramel toffee dipped in chocolate and topped with salted crushed pretzels", "Chocolate Caramel", 50000 });

            migrationBuilder.InsertData(
                table: "CakePops",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 2, "moist and fudgy chocolate cake pop filled with peanut butter dipped in chocolate and topped with caramelized peanut brittle", "The Peanut Butter Chocolate", 50000 });

            migrationBuilder.InsertData(
                table: "CakePops",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 3, "", "Rainbow Cake Pop", 50000 });

            migrationBuilder.InsertData(
                table: "CakePops",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 4, "chocolate cake pop dipped in milk chocolate", "Chocolate", 45000 });

            migrationBuilder.InsertData(
                table: "CakePops",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 5, "vanilla cake pop dipped in white chocolate", "Vanilla", 45000 });

            migrationBuilder.InsertData(
                table: "CakePops",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 6, "cookie dough cake pop filled with nutella dipped in milk chocolate", "Cookie Dough Nutella", 55000 });

            migrationBuilder.InsertData(
                table: "CakePops",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 7, "red velvet cake pop dipped in milk chocolate", "Red Velvet", 45000 });

            migrationBuilder.InsertData(
                table: "CakePops",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 8, "cookie dough cake pop dipped in milk chocolate", "Cookie Dough", 46000 });

            migrationBuilder.InsertData(
                table: "CakePops",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 9, "red velvet cake pop filled with nutella dipped in milk chocolate", "Red Velvet Nutella", 55000 });

            migrationBuilder.InsertData(
                table: "CinnamonRolls",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 14, "", "Oreo Cinnamon Roll", 105000 });

            migrationBuilder.InsertData(
                table: "CinnamonRolls",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 15, "", "Red Velvet Cinnamon Roll", 105000 });

            migrationBuilder.InsertData(
                table: "CinnamonRolls",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 16, "", "Lotus Cinnamon Roll", 105000 });

            migrationBuilder.InsertData(
                table: "CinnamonRolls",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 17, "", "Nutella Cinnamon Roll", 105000 });

            migrationBuilder.InsertData(
                table: "Cookies",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 18, "churros based cookie dough stuffed with premium Belgian chocolate topped with cinnamon and sugar", "Churro Cookie", 70000 });

            migrationBuilder.InsertData(
                table: "Cookies",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 19, "chocolate chip cookie filled with red velvet cake pop", "Chocolate Chip with Cake Pop", 65000 });

            migrationBuilder.InsertData(
                table: "Cookies",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 20, "", "Half Chocolate Chip, Half Red Velvet Cookie", 65000 });

            migrationBuilder.InsertData(
                table: "Cookies",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 21, "plain soft red velvet cookie", "Red Velvet", 65000 });

            migrationBuilder.InsertData(
                table: "Cookies",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 22, "red velvet cookie filled with oreo", "Red Velvet Oreo", 65000 });

            migrationBuilder.InsertData(
                table: "Cookies",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 23, "red velvet cookie filled with nutella spread", "Red Velvet Nutella", 65000 });

            migrationBuilder.InsertData(
                table: "Cookies",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 24, "chocolate chip cookie filled with m&m's", "M&M's", 65000 });

            migrationBuilder.InsertData(
                table: "Cookies",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 25, "chocolate chip cookie filled with lotus spread", "Lotus", 65000 });

            migrationBuilder.InsertData(
                table: "Cookies",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 26, "chocolate chip cookie filled with snickers", "Snickers", 65000 });

            migrationBuilder.InsertData(
                table: "Cookies",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 27, "chocolate chip cookie filled with mars", "Mars", 65000 });

            migrationBuilder.InsertData(
                table: "Cookies",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 28, "chocolate chip cookie filled with kinder bueno", "Bueno", 65000 });

            migrationBuilder.InsertData(
                table: "Cookies",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 29, "chocolate chip cookie filled with twix", "Twix", 65000 });

            migrationBuilder.InsertData(
                table: "Cupcakes",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 30, "vanilla buttercream cupcake topped with candy", "Vanilla Buttercream Cupcake", 60000 });

            migrationBuilder.InsertData(
                table: "Cupcakes",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 31, "layered red velvet cupcake with raw edible cookie dough between the layers, topped with vanilla buttercream, chunks of cookie dough and drizzled with milk chocolate", "Layered Red Velvet Cookie Dough Cupcake", 60000 });

            migrationBuilder.InsertData(
                table: "Cupcakes",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 32, "layered red velvet cupcake with oreo truffle between the layers, topped with oreo truffle and our homemade chcoclate ganache and mini chocolate chips", "Layered Red Velvet Oreo Cupcake", 62000 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 1, 1, "moist and fudgy chocolate cake pop filled with caramel toffee dipped in chocolate and topped with salted crushed pretzels", "Chocolate Caramel", 50000 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 2, 1, "moist and fudgy chocolate cake pop filled with peanut butter dipped in chocolate and topped with caramelized peanut brittle", "The Peanut Butter Chocolate", 50000 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 3, 1, "", "Rainbow Cake Pop", 50000 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 4, 1, "chocolate cake pop dipped in milk chocolate", "Chocolate", 45000 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 5, 1, "vanilla cake pop dipped in white chocolate", "Vanilla", 45000 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 6, 1, "cookie dough cake pop filled with nutella dipped in milk chocolate", "Cookie Dough Nutella", 55000 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 7, 1, "red velvet cake pop dipped in milk chocolate", "Red Velvet", 45000 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 8, 1, "cookie dough cake pop dipped in milk chocolate", "Cookie Dough", 46000 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 9, 1, "red velvet cake pop filled with nutella dipped in milk chocolate", "Red Velvet Nutella", 55000 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 10, 2, "the moist chewy interior bursting with cookie butter flavor topped with biscoff spread and a lotus biscuit", "Biscoff Blondies", 73000 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 11, 2, "three layer brownie, with a layer of nutella brownie, layer edible cookie dough and layer chocolate chip cookie topped with nutella", "Brookie", 75000 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 12, 2, "", "Nutella Brownies", 70000 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 13, 2, "", "Caramel Twix Brownies", 70000 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 14, 3, "", "Oreo Cinnamon Roll", 105000 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 15, 3, "", "Red Velvet Cinnamon Roll", 105000 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 16, 3, "", "Lotus Cinnamon Roll", 105000 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 17, 3, "", "Nutella Cinnamon Roll", 105000 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 18, 4, "churros based cookie dough stuffed with premium Belgian chocolate topped with cinnamon and sugar", "Churro Cookie", 70000 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 19, 4, "chocolate chip cookie filled with red velvet cake pop", "Chocolate Chip with Cake Pop", 65000 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 20, 4, "", "Half Chocolate Chip, Half Red Velvet Cookie", 65000 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 21, 4, "plain soft red velvet cookie", "Red Velvet", 65000 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 22, 4, "red velvet cookie filled with oreo", "Red Velvet Oreo", 65000 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 23, 4, "red velvet cookie filled with nutella spread", "Red Velvet Nutella", 65000 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 24, 4, "chocolate chip cookie filled with m&m's", "M&M's", 65000 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 25, 4, "chocolate chip cookie filled with lotus spread", "Lotus", 65000 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 26, 4, "chocolate chip cookie filled with snickers", "Snickers", 65000 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 27, 4, "chocolate chip cookie filled with mars", "Mars", 65000 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 28, 4, "chocolate chip cookie filled with kinder bueno", "Bueno", 65000 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 29, 4, "chocolate chip cookie filled with twix", "Twix", 65000 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 30, 5, "vanilla buttercream cupcake topped with candy", "Vanilla Buttercream Cupcake", 60000 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 31, 5, "layered red velvet cupcake with raw edible cookie dough between the layers, topped with vanilla buttercream, chunks of cookie dough and drizzled with milk chocolate", "Layered Red Velvet Cookie Dough Cupcake", 60000 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 32, 5, "layered red velvet cupcake with oreo truffle between the layers, topped with oreo truffle and our homemade chcoclate ganache and mini chocolate chips", "Layered Red Velvet Oreo Cupcake", 62000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "MenuItems");
        }
    }
}
