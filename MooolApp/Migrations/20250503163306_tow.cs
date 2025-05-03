using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MooolApp.Migrations
{
    public partial class tow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addressess_Mool_MoolId",
                table: "Addressess");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Mool_MoolID",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mool",
                table: "Mool");

            migrationBuilder.RenameTable(
                name: "Mool",
                newName: "Mools");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mools",
                table: "Mools",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Addressess_Mools_MoolId",
                table: "Addressess",
                column: "MoolId",
                principalTable: "Mools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Mools_MoolID",
                table: "Items",
                column: "MoolID",
                principalTable: "Mools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addressess_Mools_MoolId",
                table: "Addressess");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Mools_MoolID",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mools",
                table: "Mools");

            migrationBuilder.RenameTable(
                name: "Mools",
                newName: "Mool");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mool",
                table: "Mool",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Addressess_Mool_MoolId",
                table: "Addressess",
                column: "MoolId",
                principalTable: "Mool",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Mool_MoolID",
                table: "Items",
                column: "MoolID",
                principalTable: "Mool",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
