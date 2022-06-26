using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sarafi.DataAccess.Migrations
{
    public partial class applicationuserLocations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_zLocation_ZLocationLocationId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ZLocationLocationId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LocationID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ZLocationLocationId",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationID",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

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
    }
}
