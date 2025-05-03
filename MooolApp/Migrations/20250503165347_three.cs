using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MooolApp.Migrations
{
    public partial class three : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addressess_Mools_MoolId",
                table: "Addressess");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addressess",
                table: "Addressess");

            migrationBuilder.RenameTable(
                name: "Addressess",
                newName: "Address");

            migrationBuilder.RenameIndex(
                name: "IX_Addressess_MoolId",
                table: "Address",
                newName: "IX_Address_MoolId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Mools_MoolId",
                table: "Address",
                column: "MoolId",
                principalTable: "Mools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Mools_MoolId",
                table: "Address");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Addressess");

            migrationBuilder.RenameIndex(
                name: "IX_Address_MoolId",
                table: "Addressess",
                newName: "IX_Addressess_MoolId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addressess",
                table: "Addressess",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Addressess_Mools_MoolId",
                table: "Addressess",
                column: "MoolId",
                principalTable: "Mools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
