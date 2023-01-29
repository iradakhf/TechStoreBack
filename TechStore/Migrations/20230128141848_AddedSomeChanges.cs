using Microsoft.EntityFrameworkCore.Migrations;

namespace TechStore.Migrations
{
    public partial class AddedSomeChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Banners",
                maxLength: 2550,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2550)",
                oldMaxLength: 2550);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Banners",
                type: "nvarchar(2550)",
                maxLength: 2550,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 2550,
                oldNullable: true);
        }
    }
}
