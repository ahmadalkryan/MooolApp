using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MooolApp.Migrations
{
    public partial class four1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Mools_MoolID",
                table: "Items");

            migrationBuilder.AlterColumn<string>(
                name: "MoolID",
                table: "Items",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Mools_MoolID",
                table: "Items",
                column: "MoolID",
                principalTable: "Mools",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Mools_MoolID",
                table: "Items");

            migrationBuilder.AlterColumn<string>(
                name: "MoolID",
                table: "Items",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Mools_MoolID",
                table: "Items",
                column: "MoolID",
                principalTable: "Mools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
