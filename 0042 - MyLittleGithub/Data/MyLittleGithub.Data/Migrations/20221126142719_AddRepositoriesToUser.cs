using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyLittleGithub.Data.Migrations
{
    public partial class AddRepositoriesToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Repositories",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: string.Empty);

            migrationBuilder.CreateIndex(
                name: "IX_Repositories_ApplicationUserId",
                table: "Repositories",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Repositories_AspNetUsers_ApplicationUserId",
                table: "Repositories",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Repositories_AspNetUsers_ApplicationUserId",
                table: "Repositories");

            migrationBuilder.DropIndex(
                name: "IX_Repositories_ApplicationUserId",
                table: "Repositories");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Repositories");
        }
    }
}
