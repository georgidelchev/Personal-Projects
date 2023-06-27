using Microsoft.EntityFrameworkCore.Migrations;

namespace HRCloud.Data.Migrations
{
    public partial class AddWelcomeCardUrlFieldToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WelcomeCardUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: string.Empty);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WelcomeCardUrl",
                table: "AspNetUsers");
        }
    }
}
