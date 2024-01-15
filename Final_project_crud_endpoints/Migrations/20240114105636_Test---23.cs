using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class Test23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("10fd68cf-6503-4f17-9cb5-0b157093b4d0"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Explore cutting-edge technology with Samsung. From innovative smartphones to high-quality home appliances, Samsung delivers reliability, style, and innovation for modern lifestyles.", "Samsung" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("900c0cfb-12e2-4917-a69e-741271adb6ae"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Unleash possibilities with HP. From powerful laptops to innovative printers, HP provides reliable technology solutions for both personal and professional computing needs.", "HP" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("f6afa27e-a06c-457e-bbad-9d536eedca4d"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Experience quality and innovation with Philips. From advanced healthcare technology to consumer electronics, Philips delivers solutions that enhance well-being and simplify everyday life.", "Philips" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("10fd68cf-6503-4f17-9cb5-0b157093b4d0"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Experience quality and innovation with Philips. From advanced healthcare technology to consumer electronics, Philips delivers solutions that enhance well-being and simplify everyday life.", "Philips" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("900c0cfb-12e2-4917-a69e-741271adb6ae"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Explore cutting-edge technology with Samsung. From innovative smartphones to high-quality home appliances, Samsung delivers reliability, style, and innovation for modern lifestyles.", "Samsung" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("f6afa27e-a06c-457e-bbad-9d536eedca4d"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Unleash possibilities with HP. From powerful laptops to innovative printers, HP provides reliable technology solutions for both personal and professional computing needs.", "HP" });
        }
    }
}
