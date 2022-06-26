using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sarafi.DataAccess.Migrations
{
    public partial class applicationuserLocations2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "LocationId",
                table: "AspNetUsers",
                type: "tinyint",
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
                principalColumn: "LocationID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_zLocation_LocationId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_LocationId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "AspNetUsers");
        }
    }
}
