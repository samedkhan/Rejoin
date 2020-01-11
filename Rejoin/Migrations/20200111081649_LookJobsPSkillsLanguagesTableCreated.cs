using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rejoin.Migrations
{
    public partial class LookJobsPSkillsLanguagesTableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Professions_UserID",
                table: "Professions");

            migrationBuilder.DropIndex(
                name: "IX_LookingJobs_UserId",
                table: "LookingJobs");

            migrationBuilder.DropColumn(
                name: "ExperienceMonth",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ExperienceYear",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "JobProfession",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PersonalSkills",
                table: "Users");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastActivityDate",
                table: "Users",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Professions_UserID",
                table: "Professions",
                column: "UserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LookingJobs_UserId",
                table: "LookingJobs",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Professions_UserID",
                table: "Professions");

            migrationBuilder.DropIndex(
                name: "IX_LookingJobs_UserId",
                table: "LookingJobs");

            migrationBuilder.DropColumn(
                name: "LastActivityDate",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "ExperienceMonth",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExperienceYear",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "JobProfession",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PersonalSkills",
                table: "Users",
                type: "ntext",
                maxLength: 500,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Professions_UserID",
                table: "Professions",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_LookingJobs_UserId",
                table: "LookingJobs",
                column: "UserId");
        }
    }
}
