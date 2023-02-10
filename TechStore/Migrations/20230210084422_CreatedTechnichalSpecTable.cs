using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TechStore.Migrations
{
    public partial class CreatedTechnichalSpecTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TechnicalSpecId",
                table: "Products",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TechnicalSpecs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Height = table.Column<string>(maxLength: 2550, nullable: false),
                    Material = table.Column<string>(maxLength: 2550, nullable: false),
                    Case = table.Column<string>(maxLength: 2550, nullable: false),
                    Depth = table.Column<string>(maxLength: 2550, nullable: false),
                    Width = table.Column<string>(maxLength: 2550, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechnicalSpecs", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_TechnicalSpecId",
                table: "Products",
                column: "TechnicalSpecId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_TechnicalSpecs_TechnicalSpecId",
                table: "Products",
                column: "TechnicalSpecId",
                principalTable: "TechnicalSpecs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_TechnicalSpecs_TechnicalSpecId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "TechnicalSpecs");

            migrationBuilder.DropIndex(
                name: "IX_Products_TechnicalSpecId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TechnicalSpecId",
                table: "Products");
        }
    }
}
