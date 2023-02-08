using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd_Project.Migrations
{
    public partial class addChangeEventsDetailTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "EventDetails");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Events",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Events");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "EventDetails",
                type: "datetime2",
                nullable: true);
        }
    }
}
