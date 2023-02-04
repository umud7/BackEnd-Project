using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd_Project.Migrations
{
    public partial class addTeacheTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Bios",
                table: "Bios");

            migrationBuilder.RenameTable(
                name: "Bios",
                newName: "Bio");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bio",
                table: "Bio",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "SocialPages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Facebook = table.Column<string>(nullable: true),
                    Pinterest = table.Column<string>(nullable: true),
                    Vimeo = table.Column<string>(nullable: true),
                    Twitter = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialPages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    Position = table.Column<int>(nullable: false),
                    SocialPageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_SocialPages_SocialPageId",
                        column: x => x.SocialPageId,
                        principalTable: "SocialPages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_SocialPageId",
                table: "Teachers",
                column: "SocialPageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "SocialPages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bio",
                table: "Bio");

            migrationBuilder.RenameTable(
                name: "Bio",
                newName: "Bios");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bios",
                table: "Bios",
                column: "Id");
        }
    }
}
