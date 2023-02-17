using Microsoft.EntityFrameworkCore.Migrations;

namespace TechStore.Migrations
{
    public partial class AddedSomeChages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wishlists_AspNetUsers_AppUserId",
                table: "Wishlists");

            migrationBuilder.DropIndex(
                name: "IX_Wishlists_AppUserId",
                table: "Wishlists");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Wishlists");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Wishlists",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Wishlists_AppUserId",
                table: "Wishlists",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Wishlists_AspNetUsers_AppUserId",
                table: "Wishlists",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
