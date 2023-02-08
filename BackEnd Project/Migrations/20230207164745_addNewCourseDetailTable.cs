using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd_Project.Migrations
{
    public partial class addNewCourseDetailTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Assesments",
                table: "CourseDetails",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClassDuration",
                table: "CourseDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CourseFee",
                table: "CourseDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Duration",
                table: "CourseDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "CourseDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SkillLevel",
                table: "CourseDetails",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "CourseDetails",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "StudentCount",
                table: "CourseDetails",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Assesments",
                table: "CourseDetails");

            migrationBuilder.DropColumn(
                name: "ClassDuration",
                table: "CourseDetails");

            migrationBuilder.DropColumn(
                name: "CourseFee",
                table: "CourseDetails");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "CourseDetails");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "CourseDetails");

            migrationBuilder.DropColumn(
                name: "SkillLevel",
                table: "CourseDetails");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "CourseDetails");

            migrationBuilder.DropColumn(
                name: "StudentCount",
                table: "CourseDetails");
        }
    }
}
