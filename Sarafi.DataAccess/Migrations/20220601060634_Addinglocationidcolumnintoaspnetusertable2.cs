using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sarafi.DataAccess.Migrations
{
    public partial class Addinglocationidcolumnintoaspnetusertable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_zLocation_LocationId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_LocationId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LocationID",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "AspNetUsers",
                newName: "LocationID");

            migrationBuilder.AlterColumn<int>(
                name: "LocationID",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "ZLocationLocationId",
                table: "AspNetUsers",
                type: "tinyint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ZLocationLocationId",
                table: "AspNetUsers",
                column: "ZLocationLocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_zLocation_ZLocationLocationId",
                table: "AspNetUsers",
                column: "ZLocationLocationId",
                principalTable: "zLocation",
                principalColumn: "LocationID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_zLocation_ZLocationLocationId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ZLocationLocationId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ZLocationLocationId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "LocationID",
                table: "AspNetUsers",
                newName: "LocationId");

            migrationBuilder.AlterColumn<byte>(
                name: "LocationId",
                table: "AspNetUsers",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationID",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_LocationId",
                table: "AspNetUsers",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_zLocation_LocationId",
                table: "AspNetUsers",
                column: "LocationId",
                principalTable: "zLocation",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
