using Microsoft.EntityFrameworkCore.Migrations;

namespace Rejoin.Migrations
{
    public partial class UserAndJobTablesAddListApply : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apply_Jobs_JobId",
                table: "Apply");

            migrationBuilder.DropForeignKey(
                name: "FK_Apply_Users_UserId",
                table: "Apply");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Apply",
                table: "Apply");

            migrationBuilder.RenameTable(
                name: "Apply",
                newName: "Appliers");

            migrationBuilder.RenameIndex(
                name: "IX_Apply_UserId",
                table: "Appliers",
                newName: "IX_Appliers_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Apply_JobId",
                table: "Appliers",
                newName: "IX_Appliers_JobId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appliers",
                table: "Appliers",
                column: "ApplyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appliers_Jobs_JobId",
                table: "Appliers",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "JobId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Appliers_Users_UserId",
                table: "Appliers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appliers_Jobs_JobId",
                table: "Appliers");

            migrationBuilder.DropForeignKey(
                name: "FK_Appliers_Users_UserId",
                table: "Appliers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appliers",
                table: "Appliers");

            migrationBuilder.RenameTable(
                name: "Appliers",
                newName: "Apply");

            migrationBuilder.RenameIndex(
                name: "IX_Appliers_UserId",
                table: "Apply",
                newName: "IX_Apply_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Appliers_JobId",
                table: "Apply",
                newName: "IX_Apply_JobId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Apply",
                table: "Apply",
                column: "ApplyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Apply_Jobs_JobId",
                table: "Apply",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "JobId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Apply_Users_UserId",
                table: "Apply",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
