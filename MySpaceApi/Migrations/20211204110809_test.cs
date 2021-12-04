using Microsoft.EntityFrameworkCore.Migrations;

namespace MySpaceApi.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Section");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Note");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "Section",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "Note",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
