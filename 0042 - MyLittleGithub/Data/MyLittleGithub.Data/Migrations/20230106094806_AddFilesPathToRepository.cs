using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyLittleGithub.Data.Migrations
{
    public partial class AddFilesPathToRepository : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FilesPath",
                table: "Repositories",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FilesPath",
                table: "Repositories");
        }
    }
}
