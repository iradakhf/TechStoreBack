using Microsoft.EntityFrameworkCore.Migrations;

namespace TechStore.Migrations
{
    public partial class AddedOneToManyRelationToSpecialOfferAndProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "SpecialOffers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SpecialOffers_ProductId",
                table: "SpecialOffers",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_SpecialOffers_Products_ProductId",
                table: "SpecialOffers",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SpecialOffers_Products_ProductId",
                table: "SpecialOffers");

            migrationBuilder.DropIndex(
                name: "IX_SpecialOffers_ProductId",
                table: "SpecialOffers");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "SpecialOffers");
        }
    }
}
