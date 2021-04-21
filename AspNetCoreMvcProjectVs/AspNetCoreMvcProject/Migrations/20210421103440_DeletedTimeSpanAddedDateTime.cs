using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCoreMvcProject.Migrations
{
    public partial class DeletedTimeSpanAddedDateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Events",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Events",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "StartTime",
                table: "Events",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "EndTime",
                table: "Events",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime));
        }
    }
}
