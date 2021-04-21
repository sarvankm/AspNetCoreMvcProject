using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCoreMvcProject.Migrations
{
    public partial class AddedSkillsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CommunicationSkillPercent",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "DesignSkillPercent",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "DevelopmentSkillPercent",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "InnovationSkillPercent",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "LanguageSkillPercent",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "TeamLeaderSkillPercent",
                table: "Teachers");

            migrationBuilder.AddColumn<int>(
                name: "SkillId",
                table: "Teachers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageSkillPercent = table.Column<int>(nullable: false),
                    DesignSkillPercent = table.Column<int>(nullable: false),
                    TeamLeaderSkillPercent = table.Column<int>(nullable: false),
                    InnovationSkillPercent = table.Column<int>(nullable: false),
                    DevelopmentSkillPercent = table.Column<int>(nullable: false),
                    CommunicationSkillPercent = table.Column<int>(nullable: false),
                    TeacherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skills_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Skills_TeacherId",
                table: "Skills",
                column: "TeacherId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropColumn(
                name: "SkillId",
                table: "Teachers");

            migrationBuilder.AddColumn<int>(
                name: "CommunicationSkillPercent",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DesignSkillPercent",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DevelopmentSkillPercent",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InnovationSkillPercent",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LanguageSkillPercent",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeamLeaderSkillPercent",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
