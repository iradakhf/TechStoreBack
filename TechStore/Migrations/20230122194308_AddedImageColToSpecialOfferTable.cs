using Microsoft.EntityFrameworkCore.Migrations;

namespace TechStore.Migrations
{
    public partial class AddedImageColToSpecialOfferTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "SpecialOffers",
                maxLength: 500,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "SpecialOffers");
        }
    }
}
