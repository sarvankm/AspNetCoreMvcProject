using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCoreMvcProject.Migrations
{
    public partial class UpdatedCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CourseContent",
                table: "CourseCards",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000);

            migrationBuilder.AddColumn<string>(
                name: "AboutCourse",
                table: "CourseCards",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Assesments",
                table: "CourseCards",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Certification",
                table: "CourseCards",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ClassDuration",
                table: "CourseCards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Duration",
                table: "CourseCards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "HowToApply",
                table: "CourseCards",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "CourseCards",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "CourseCards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SkillLevel",
                table: "CourseCards",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "CourseCards",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "StudentsCount",
                table: "CourseCards",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AboutCourse",
                table: "CourseCards");

            migrationBuilder.DropColumn(
                name: "Assesments",
                table: "CourseCards");

            migrationBuilder.DropColumn(
                name: "Certification",
                table: "CourseCards");

            migrationBuilder.DropColumn(
                name: "ClassDuration",
                table: "CourseCards");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "CourseCards");

            migrationBuilder.DropColumn(
                name: "HowToApply",
                table: "CourseCards");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "CourseCards");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "CourseCards");

            migrationBuilder.DropColumn(
                name: "SkillLevel",
                table: "CourseCards");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "CourseCards");

            migrationBuilder.DropColumn(
                name: "StudentsCount",
                table: "CourseCards");

            migrationBuilder.AlterColumn<string>(
                name: "CourseContent",
                table: "CourseCards",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
