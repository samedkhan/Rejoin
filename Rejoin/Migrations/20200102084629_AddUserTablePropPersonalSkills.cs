using Microsoft.EntityFrameworkCore.Migrations;

namespace Rejoin.Migrations
{
    public partial class AddUserTablePropPersonalSkills : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Education_UserResume_ResumeId",
                table: "Education");

            migrationBuilder.DropForeignKey(
                name: "FK_UserResume_Users_UserId",
                table: "UserResume");

            migrationBuilder.DropForeignKey(
                name: "FK_Work_UserResume_ResumeId",
                table: "Work");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Work",
                table: "Work");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserResume",
                table: "UserResume");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Education",
                table: "Education");

            migrationBuilder.RenameTable(
                name: "Work",
                newName: "Works");

            migrationBuilder.RenameTable(
                name: "UserResume",
                newName: "UserResumes");

            migrationBuilder.RenameTable(
                name: "Education",
                newName: "Educations");

            migrationBuilder.RenameIndex(
                name: "IX_Work_ResumeId",
                table: "Works",
                newName: "IX_Works_ResumeId");

            migrationBuilder.RenameIndex(
                name: "IX_UserResume_UserId",
                table: "UserResumes",
                newName: "IX_UserResumes_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Education_ResumeId",
                table: "Educations",
                newName: "IX_Educations_ResumeId");

            migrationBuilder.AddColumn<string>(
                name: "PersonalSkills",
                table: "Users",
                type: "ntext",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Works",
                table: "Works",
                column: "WorkId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserResumes",
                table: "UserResumes",
                column: "ResumeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Educations",
                table: "Educations",
                column: "EducationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_UserResumes_ResumeId",
                table: "Educations",
                column: "ResumeId",
                principalTable: "UserResumes",
                principalColumn: "ResumeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserResumes_Users_UserId",
                table: "UserResumes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Works_UserResumes_ResumeId",
                table: "Works",
                column: "ResumeId",
                principalTable: "UserResumes",
                principalColumn: "ResumeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Educations_UserResumes_ResumeId",
                table: "Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_UserResumes_Users_UserId",
                table: "UserResumes");

            migrationBuilder.DropForeignKey(
                name: "FK_Works_UserResumes_ResumeId",
                table: "Works");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Works",
                table: "Works");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserResumes",
                table: "UserResumes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Educations",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "PersonalSkills",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Works",
                newName: "Work");

            migrationBuilder.RenameTable(
                name: "UserResumes",
                newName: "UserResume");

            migrationBuilder.RenameTable(
                name: "Educations",
                newName: "Education");

            migrationBuilder.RenameIndex(
                name: "IX_Works_ResumeId",
                table: "Work",
                newName: "IX_Work_ResumeId");

            migrationBuilder.RenameIndex(
                name: "IX_UserResumes_UserId",
                table: "UserResume",
                newName: "IX_UserResume_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Educations_ResumeId",
                table: "Education",
                newName: "IX_Education_ResumeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Work",
                table: "Work",
                column: "WorkId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserResume",
                table: "UserResume",
                column: "ResumeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Education",
                table: "Education",
                column: "EducationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Education_UserResume_ResumeId",
                table: "Education",
                column: "ResumeId",
                principalTable: "UserResume",
                principalColumn: "ResumeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserResume_Users_UserId",
                table: "UserResume",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Work_UserResume_ResumeId",
                table: "Work",
                column: "ResumeId",
                principalTable: "UserResume",
                principalColumn: "ResumeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
