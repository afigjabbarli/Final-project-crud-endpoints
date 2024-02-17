using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class Addqualityleveltabletodatabaseandestablishedonetomanyrelationshipbetweenproductandqualityleveltable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "Current_Quality_Level_Id",
                table: "Products",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "QualityLevels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Level = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QualityLevels", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_Current_Quality_Level_Id",
                table: "Products",
                column: "Current_Quality_Level_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_QualityLevels_Current_Quality_Level_Id",
                table: "Products",
                column: "Current_Quality_Level_Id",
                principalTable: "QualityLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_QualityLevels_Current_Quality_Level_Id",
                table: "Products");

            migrationBuilder.DropTable(
                name: "QualityLevels");

            migrationBuilder.DropIndex(
                name: "IX_Products_Current_Quality_Level_Id",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Current_Quality_Level_Id",
                table: "Products");
        }
    }
}
