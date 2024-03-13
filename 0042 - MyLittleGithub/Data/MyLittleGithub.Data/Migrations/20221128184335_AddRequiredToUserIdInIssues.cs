using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyLittleGithub.Data.Migrations
{
    public partial class AddRequiredToUserIdInIssues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Issues_AspNetUsers_ApplicationUserId",
                table: "Issues");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "Issues",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: string.Empty,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Issues_AspNetUsers_ApplicationUserId",
                table: "Issues",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Issues_AspNetUsers_ApplicationUserId",
                table: "Issues");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "Issues",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Issues_AspNetUsers_ApplicationUserId",
                table: "Issues",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
