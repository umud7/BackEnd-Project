using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd_Project.Migrations
{
    public partial class addChangeTeacherSkillTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Percentages",
                table: "TeacherSkills");

            migrationBuilder.AddColumn<int>(
                name: "Communication",
                table: "TeacherSkills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Design",
                table: "TeacherSkills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Development",
                table: "TeacherSkills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Innovation",
                table: "TeacherSkills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Language",
                table: "TeacherSkills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeamLeader",
                table: "TeacherSkills",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Communication",
                table: "TeacherSkills");

            migrationBuilder.DropColumn(
                name: "Design",
                table: "TeacherSkills");

            migrationBuilder.DropColumn(
                name: "Development",
                table: "TeacherSkills");

            migrationBuilder.DropColumn(
                name: "Innovation",
                table: "TeacherSkills");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "TeacherSkills");

            migrationBuilder.DropColumn(
                name: "TeamLeader",
                table: "TeacherSkills");

            migrationBuilder.AddColumn<int>(
                name: "Percentages",
                table: "TeacherSkills",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
