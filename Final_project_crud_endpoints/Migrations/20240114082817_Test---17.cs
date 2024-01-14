using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class Test17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("1a39bd74-4a89-43df-9fd9-b34710b1d221"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Embrace eco-friendly commuting with Electric Scooters. Effortlessly navigate urban landscapes, enjoy efficient travel, and reduce your carbon footprint with these sleek and agile electric vehicles.", "Electric scooters" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("28f7b326-391f-407c-9fb8-ec4b6458ddd5"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Navigate city streets with ease using Mopeds. Combining efficiency with style, these compact two-wheelers offer a convenient and eco-friendly solution for urban commuting.", "Mopeds" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("3b23c2f5-658a-4dc7-90d3-d5349c7cf6ef"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Experience futuristic transportation with Gyroboards. Effortlessly glide and maneuver, mastering the art of balance for a fun and efficient way to commute in urban environments.", "Gyroboards" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("4a51d1c9-2415-4eb4-8aae-a5bf732ddd89"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Drive into the future with Electric Cars. Experience sustainable mobility, zero emissions, and cutting-edge technology for a greener and smarter approach to commuting.", "Electric cars" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("aba63da0-0281-413b-9148-f68e2e0275cc"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Unleash excitement with Electric Skates. Effortlessly glide, accelerate, and brake with these motorized wonders, offering a thrilling and dynamic way to explore your surroundings.", "Electric skates" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("b0823bd2-809c-4e25-bfb4-db44fe708dc8"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Embrace the open road with Motorcycles. Experience freedom, speed, and the thrill of the ride on these powerful and iconic two-wheelers.", "Motorcycles" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("1a39bd74-4a89-43df-9fd9-b34710b1d221"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Embrace the open road with Motorcycles. Experience freedom, speed, and the thrill of the ride on these powerful and iconic two-wheelers.", "Motorcycles" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("28f7b326-391f-407c-9fb8-ec4b6458ddd5"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Drive into the future with Electric Cars. Experience sustainable mobility, zero emissions, and cutting-edge technology for a greener and smarter approach to commuting.", "Electric cars" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("3b23c2f5-658a-4dc7-90d3-d5349c7cf6ef"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Navigate city streets with ease using Mopeds. Combining efficiency with style, these compact two-wheelers offer a convenient and eco-friendly solution for urban commuting.", "Mopeds" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("4a51d1c9-2415-4eb4-8aae-a5bf732ddd89"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Embrace eco-friendly commuting with Electric Scooters. Effortlessly navigate urban landscapes, enjoy efficient travel, and reduce your carbon footprint with these sleek and agile electric vehicles.", "Electric scooters" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("aba63da0-0281-413b-9148-f68e2e0275cc"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Experience futuristic transportation with Gyroboards. Effortlessly glide and maneuver, mastering the art of balance for a fun and efficient way to commute in urban environments.", "Gyroboards" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("b0823bd2-809c-4e25-bfb4-db44fe708dc8"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Unleash excitement with Electric Skates. Effortlessly glide, accelerate, and brake with these motorized wonders, offering a thrilling and dynamic way to explore your surroundings.", "Electric skates" });
        }
    }
}
