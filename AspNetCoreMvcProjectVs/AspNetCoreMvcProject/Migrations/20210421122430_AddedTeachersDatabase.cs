using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCoreMvcProject.Migrations
{
    public partial class AddedTeachersDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: false),
                    FullName = table.Column<string>(nullable: false),
                    Profession = table.Column<string>(nullable: false),
                    About = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Degree = table.Column<string>(nullable: false),
                    Experience = table.Column<string>(nullable: false),
                    Hobbies = table.Column<string>(nullable: false),
                    Faculty = table.Column<string>(nullable: false),
                    ContactInfoMail = table.Column<string>(nullable: false),
                    ContactInfoSkype = table.Column<string>(nullable: false),
                    ContactInfoNumber = table.Column<string>(nullable: false),
                    OwnFacebook = table.Column<string>(nullable: false),
                    OwnPinterest = table.Column<string>(nullable: false),
                    OwnVimeo = table.Column<string>(nullable: false),
                    OwnTwitter = table.Column<string>(nullable: false),
                    LanguageSkillPercent = table.Column<int>(nullable: false),
                    DesignSkillPercent = table.Column<int>(nullable: false),
                    TeamLeaderSkillPercent = table.Column<int>(nullable: false),
                    InnovationSkillPercent = table.Column<int>(nullable: false),
                    DevelopmentSkillPercent = table.Column<int>(nullable: false),
                    CommunicationSkillPercent = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
