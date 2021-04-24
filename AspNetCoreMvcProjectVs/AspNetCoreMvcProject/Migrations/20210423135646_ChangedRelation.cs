using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCoreMvcProject.Migrations
{
    public partial class ChangedRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CommentForms_BlogId",
                table: "CommentForms");

            migrationBuilder.CreateIndex(
                name: "IX_CommentForms_BlogId",
                table: "CommentForms",
                column: "BlogId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CommentForms_BlogId",
                table: "CommentForms");

            migrationBuilder.CreateIndex(
                name: "IX_CommentForms_BlogId",
                table: "CommentForms",
                column: "BlogId",
                unique: true);
        }
    }
}
