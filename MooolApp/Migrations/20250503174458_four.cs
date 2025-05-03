using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MooolApp.Migrations
{
    public partial class four : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Mools",
                columns: new[] { "Id", "Name" },
                values: new object[] { "2", "kaseon" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "MoolID", "Name", "price" },
                values: new object[] { "1", "this is very nice", "2", "colths", 2440.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Mools",
                keyColumn: "Id",
                keyValue: "2");
        }
    }
}
