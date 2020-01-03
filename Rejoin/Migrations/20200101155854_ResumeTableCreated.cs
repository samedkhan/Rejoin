using Microsoft.EntityFrameworkCore.Migrations;

namespace Rejoin.Migrations
{
    public partial class ResumeTableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Education_Users_UserId",
                table: "Education");

            migrationBuilder.DropForeignKey(
                name: "FK_Work_Users_UserId",
                table: "Work");

            migrationBuilder.DropIndex(
                name: "IX_Work_UserId",
                table: "Work");

            migrationBuilder.DropIndex(
                name: "IX_Education_UserId",
                table: "Education");

            migrationBuilder.DropColumn(
                name: "EndYear",
                table: "Work");

            migrationBuilder.DropColumn(
                name: "StartYear",
                table: "Work");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Work");

            migrationBuilder.DropColumn(
                name: "EndYear",
                table: "Education");

            migrationBuilder.DropColumn(
                name: "StartYear",
                table: "Education");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Education");

            migrationBuilder.AddColumn<int>(
                name: "EndWorkYear",
                table: "Work",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ResumeId",
                table: "Work",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StartWorkYear",
                table: "Work",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EndEducationYear",
                table: "Education",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ResumeId",
                table: "Education",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StartEducationYear",
                table: "Education",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "UserResume",
                columns: table => new
                {
                    ResumeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserResume", x => x.ResumeId);
                    table.ForeignKey(
                        name: "FK_UserResume_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Work_ResumeId",
                table: "Work",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Education_ResumeId",
                table: "Education",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserResume_UserId",
                table: "UserResume",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Education_UserResume_ResumeId",
                table: "Education",
                column: "ResumeId",
                principalTable: "UserResume",
                principalColumn: "ResumeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Work_UserResume_ResumeId",
                table: "Work",
                column: "ResumeId",
                principalTable: "UserResume",
                principalColumn: "ResumeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Education_UserResume_ResumeId",
                table: "Education");

            migrationBuilder.DropForeignKey(
                name: "FK_Work_UserResume_ResumeId",
                table: "Work");

            migrationBuilder.DropTable(
                name: "UserResume");

            migrationBuilder.DropIndex(
                name: "IX_Work_ResumeId",
                table: "Work");

            migrationBuilder.DropIndex(
                name: "IX_Education_ResumeId",
                table: "Education");

            migrationBuilder.DropColumn(
                name: "EndWorkYear",
                table: "Work");

            migrationBuilder.DropColumn(
                name: "ResumeId",
                table: "Work");

            migrationBuilder.DropColumn(
                name: "StartWorkYear",
                table: "Work");

            migrationBuilder.DropColumn(
                name: "EndEducationYear",
                table: "Education");

            migrationBuilder.DropColumn(
                name: "ResumeId",
                table: "Education");

            migrationBuilder.DropColumn(
                name: "StartEducationYear",
                table: "Education");

            migrationBuilder.AddColumn<int>(
                name: "EndYear",
                table: "Work",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StartYear",
                table: "Work",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Work",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EndYear",
                table: "Education",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StartYear",
                table: "Education",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Education",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Work_UserId",
                table: "Work",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Education_UserId",
                table: "Education",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Education_Users_UserId",
                table: "Education",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Work_Users_UserId",
                table: "Work",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
