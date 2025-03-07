using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMPS278Project.Migrations
{
    public partial class UpdateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brownies",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 5, "", "Sprinkle Brownies", 5.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brownies",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
