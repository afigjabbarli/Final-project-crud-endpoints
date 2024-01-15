using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class Phisical_image_namecolumnsuccesfullyaddedtoproducttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ManufacturedIn",
                table: "Products");

            migrationBuilder.AddColumn<List<string>>(
                name: "Phisical_image_names",
                table: "Products",
                type: "text[]",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phisical_image_names",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "ManufacturedIn",
                table: "Products",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
