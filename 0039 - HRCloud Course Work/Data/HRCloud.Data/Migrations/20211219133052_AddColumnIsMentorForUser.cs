using Microsoft.EntityFrameworkCore.Migrations;

namespace HRCloud.Data.Migrations
{
    public partial class AddColumnIsMentorForUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsMentor",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMentor",
                table: "AspNetUsers");
        }
    }
}
