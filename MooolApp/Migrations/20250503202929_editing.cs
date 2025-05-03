using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MooolApp.Migrations
{
    public partial class editing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Mools_MoolId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Mools_MoolID",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Address_MoolId",
                table: "Address");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mools",
                table: "Mools");

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Mools",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DropColumn(
                name: "MoolId",
                table: "Address");

            migrationBuilder.RenameTable(
                name: "Mools",
                newName: "Mool");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Mool",
                newName: "NAme");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Mool",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "2",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "AddressId",
                table: "Mool",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mool",
                table: "Mool",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Mool_AddressId",
                table: "Mool",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Mool_MoolID",
                table: "Items",
                column: "MoolID",
                principalTable: "Mool",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mool_Address_AddressId",
                table: "Mool",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Mool_MoolID",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Mool_Address_AddressId",
                table: "Mool");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mool",
                table: "Mool");

            migrationBuilder.DropIndex(
                name: "IX_Mool_AddressId",
                table: "Mool");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Mool");

            migrationBuilder.RenameTable(
                name: "Mool",
                newName: "Mools");

            migrationBuilder.RenameColumn(
                name: "NAme",
                table: "Mools",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "MoolId",
                table: "Address",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Mools",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mools",
                table: "Mools",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Mools",
                columns: new[] { "Id", "Name" },
                values: new object[] { "2", "kaseon" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "MoolID", "Name", "price" },
                values: new object[] { "1", "this is very nice", "2", "colths", 2440.0 });

            migrationBuilder.CreateIndex(
                name: "IX_Address_MoolId",
                table: "Address",
                column: "MoolId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Mools_MoolId",
                table: "Address",
                column: "MoolId",
                principalTable: "Mools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Mools_MoolID",
                table: "Items",
                column: "MoolID",
                principalTable: "Mools",
                principalColumn: "Id");
        }
    }
}
