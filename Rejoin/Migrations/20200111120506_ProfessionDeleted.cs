using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rejoin.Migrations
{
    public partial class ProfessionDeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Professions");

            migrationBuilder.DropTable(
                name: "PSkills");

            migrationBuilder.DropColumn(
                name: "LastActivityDate",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "ExpierenceYear",
                table: "UserResumes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "JobProfession",
                table: "UserResumes",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PersonalSkill",
                table: "UserResumes",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpierenceYear",
                table: "UserResumes");

            migrationBuilder.DropColumn(
                name: "JobProfession",
                table: "UserResumes");

            migrationBuilder.DropColumn(
                name: "PersonalSkill",
                table: "UserResumes");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastActivityDate",
                table: "Users",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Professions",
                columns: table => new
                {
                    ProfessionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpierenceYear = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professions", x => x.ProfessionID);
                    table.ForeignKey(
                        name: "FK_Professions_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PSkills",
                columns: table => new
                {
                    PSkillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PSkills", x => x.PSkillId);
                    table.ForeignKey(
                        name: "FK_PSkills_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Professions_UserID",
                table: "Professions",
                column: "UserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PSkills_UserId",
                table: "PSkills",
                column: "UserId");
        }
    }
}
