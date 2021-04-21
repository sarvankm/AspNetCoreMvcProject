using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCoreMvcProject.Migrations
{
    public partial class RemovedStartDateMonth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StartDateDay",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "StartDateMonths",
                table: "Events");

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDateDayMonth",
                table: "Events",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StartDateDayMonth",
                table: "Events");

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDateDay",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDateMonths",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
