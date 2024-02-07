using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class updateuserandactivationtokentablenames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActivationToken_User_UserId",
                table: "ActivationToken");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ActivationToken",
                table: "ActivationToken");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "ActivationToken",
                newName: "ActivationTokens");

            migrationBuilder.RenameIndex(
                name: "IX_ActivationToken_UserId",
                table: "ActivationTokens",
                newName: "IX_ActivationTokens_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "PhisicalImageURL",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ActivationTokens",
                table: "ActivationTokens",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ActivationTokens_Users_UserId",
                table: "ActivationTokens",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActivationTokens_Users_UserId",
                table: "ActivationTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ActivationTokens",
                table: "ActivationTokens");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "ActivationTokens",
                newName: "ActivationToken");

            migrationBuilder.RenameIndex(
                name: "IX_ActivationTokens_UserId",
                table: "ActivationToken",
                newName: "IX_ActivationToken_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "PhisicalImageURL",
                table: "User",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ActivationToken",
                table: "ActivationToken",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ActivationToken_User_UserId",
                table: "ActivationToken",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
