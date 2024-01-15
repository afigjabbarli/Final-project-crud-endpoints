using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class Test22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Deepcategories",
                columns: new[] { "Id", "CreatedAt", "Current_Subcategory_Id", "Description", "LastUpdatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("10fd68cf-6503-4f17-9cb5-0b157093b4d0"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("2d61c82b-9ba7-4528-9e14-d8de745f32b3"), "Experience quality and innovation with Philips. From advanced healthcare technology to consumer electronics, Philips delivers solutions that enhance well-being and simplify everyday life.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Philips" },
                    { new Guid("536bf179-64e7-4fd4-a944-1ad6a33ef352"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("2d61c82b-9ba7-4528-9e14-d8de745f32b3"), "Dive into innovation with ASUS. Known for cutting-edge laptops, motherboards, and gaming peripherals, ASUS combines performance and style to enhance your digital lifestyle.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Asus" },
                    { new Guid("900c0cfb-12e2-4917-a69e-741271adb6ae"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("2d61c82b-9ba7-4528-9e14-d8de745f32b3"), "Explore cutting-edge technology with Samsung. From innovative smartphones to high-quality home appliances, Samsung delivers reliability, style, and innovation for modern lifestyles.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Samsung" },
                    { new Guid("a039a892-bf21-440b-869f-d8ee4155d18c"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("2d61c82b-9ba7-4528-9e14-d8de745f32b3"), "Transform your computing experience with Dell. From powerful laptops to versatile desktops and premium monitors, Dell delivers reliable technology solutions for work and play.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Dell" },
                    { new Guid("f6afa27e-a06c-457e-bbad-9d536eedca4d"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("2d61c82b-9ba7-4528-9e14-d8de745f32b3"), "Unleash possibilities with HP. From powerful laptops to innovative printers, HP provides reliable technology solutions for both personal and professional computing needs.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "HP" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("10fd68cf-6503-4f17-9cb5-0b157093b4d0"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("536bf179-64e7-4fd4-a944-1ad6a33ef352"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("900c0cfb-12e2-4917-a69e-741271adb6ae"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("a039a892-bf21-440b-869f-d8ee4155d18c"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("f6afa27e-a06c-457e-bbad-9d536eedca4d"));
        }
    }
}
