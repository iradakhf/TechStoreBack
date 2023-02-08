using Microsoft.EntityFrameworkCore.Migrations;

namespace TechStore.Migrations
{
    public partial class CreatedLeaveUsReplyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveUsReplies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 400, nullable: false),
                    Surname = table.Column<string>(maxLength: 400, nullable: false),
                    Subject = table.Column<string>(maxLength: 400, nullable: false),
                    Comment = table.Column<string>(maxLength: 2400, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveUsReplies", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveUsReplies");
        }
    }
}
