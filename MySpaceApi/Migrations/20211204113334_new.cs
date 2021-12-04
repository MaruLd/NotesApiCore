using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MySpaceApi.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Note_Section_SectionID",
                table: "Note");

            migrationBuilder.DropIndex(
                name: "IX_Note_SectionID",
                table: "Note");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Section");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Note");

            migrationBuilder.DropColumn(
                name: "SectionID",
                table: "Note");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "Section",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "Note",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Section");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Note");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Section",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Note",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "SectionID",
                table: "Note",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Note_SectionID",
                table: "Note",
                column: "SectionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Note_Section_SectionID",
                table: "Note",
                column: "SectionID",
                principalTable: "Section",
                principalColumn: "SectionID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
