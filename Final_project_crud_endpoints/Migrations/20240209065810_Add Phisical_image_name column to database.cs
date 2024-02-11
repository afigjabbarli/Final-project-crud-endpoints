using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class AddPhisical_image_namecolumntodatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhisicalImageURL",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "Phisical_image_name",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phisical_image_name",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "PhisicalImageURL",
                table: "Users",
                type: "text",
                nullable: true);
        }
    }
}
