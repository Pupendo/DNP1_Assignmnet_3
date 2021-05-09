using Microsoft.EntityFrameworkCore.Migrations;

namespace RestApi.Migrations
{
    public partial class AdultJob2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobId",
                table: "Adults");

            migrationBuilder.AlterColumn<string>(
                name: "JobTitle",
                table: "Jobs",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JobTitleJobId",
                table: "Adults",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Adults_JobTitleJobId",
                table: "Adults",
                column: "JobTitleJobId");

            migrationBuilder.AddForeignKey(
                name: "FK_Adults_Jobs_JobTitleJobId",
                table: "Adults",
                column: "JobTitleJobId",
                principalTable: "Jobs",
                principalColumn: "JobId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adults_Jobs_JobTitleJobId",
                table: "Adults");

            migrationBuilder.DropIndex(
                name: "IX_Adults_JobTitleJobId",
                table: "Adults");

            migrationBuilder.DropColumn(
                name: "JobTitleJobId",
                table: "Adults");

            migrationBuilder.AlterColumn<string>(
                name: "JobTitle",
                table: "Jobs",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<int>(
                name: "JobId",
                table: "Adults",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
