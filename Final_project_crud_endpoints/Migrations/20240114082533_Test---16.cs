using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class Test16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Deepcategories",
                columns: new[] { "Id", "CreatedAt", "Current_Subcategory_Id", "Description", "LastUpdatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("1a39bd74-4a89-43df-9fd9-b34710b1d221"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("7587c8cc-2cc2-4eb4-8c87-48f540a759e1"), "Embrace the open road with Motorcycles. Experience freedom, speed, and the thrill of the ride on these powerful and iconic two-wheelers.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Motorcycles" },
                    { new Guid("28f7b326-391f-407c-9fb8-ec4b6458ddd5"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("7587c8cc-2cc2-4eb4-8c87-48f540a759e1"), "Drive into the future with Electric Cars. Experience sustainable mobility, zero emissions, and cutting-edge technology for a greener and smarter approach to commuting.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Electric cars" },
                    { new Guid("380d07fd-a2a4-4477-ab6f-7b95fafb0c88"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("7587c8cc-2cc2-4eb4-8c87-48f540a759e1"), "Ride into the future with Battery Motorcycles. Silent, eco-friendly, and efficient, these electric two-wheelers provide a thrilling and sustainable alternative for urban commuting and beyond.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Battery motorcycles" },
                    { new Guid("3b23c2f5-658a-4dc7-90d3-d5349c7cf6ef"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("7587c8cc-2cc2-4eb4-8c87-48f540a759e1"), "Navigate city streets with ease using Mopeds. Combining efficiency with style, these compact two-wheelers offer a convenient and eco-friendly solution for urban commuting.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Mopeds" },
                    { new Guid("4a51d1c9-2415-4eb4-8aae-a5bf732ddd89"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("7587c8cc-2cc2-4eb4-8c87-48f540a759e1"), "Embrace eco-friendly commuting with Electric Scooters. Effortlessly navigate urban landscapes, enjoy efficient travel, and reduce your carbon footprint with these sleek and agile electric vehicles.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Electric scooters" },
                    { new Guid("aba63da0-0281-413b-9148-f68e2e0275cc"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("7587c8cc-2cc2-4eb4-8c87-48f540a759e1"), "Experience futuristic transportation with Gyroboards. Effortlessly glide and maneuver, mastering the art of balance for a fun and efficient way to commute in urban environments.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Gyroboards" },
                    { new Guid("b0823bd2-809c-4e25-bfb4-db44fe708dc8"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("7587c8cc-2cc2-4eb4-8c87-48f540a759e1"), "Unleash excitement with Electric Skates. Effortlessly glide, accelerate, and brake with these motorized wonders, offering a thrilling and dynamic way to explore your surroundings.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Electric skates" },
                    { new Guid("dc0f0d97-95e1-478f-b6d9-2562e00d2193"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("7587c8cc-2cc2-4eb4-8c87-48f540a759e1"), "Conquer off-road adventures with a Quad Bike. Experience versatility, power, and adrenaline as you navigate challenging terrains with this all-terrain vehicle.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Quad bike" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("1a39bd74-4a89-43df-9fd9-b34710b1d221"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("28f7b326-391f-407c-9fb8-ec4b6458ddd5"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("380d07fd-a2a4-4477-ab6f-7b95fafb0c88"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("3b23c2f5-658a-4dc7-90d3-d5349c7cf6ef"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("4a51d1c9-2415-4eb4-8aae-a5bf732ddd89"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("aba63da0-0281-413b-9148-f68e2e0275cc"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("b0823bd2-809c-4e25-bfb4-db44fe708dc8"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("dc0f0d97-95e1-478f-b6d9-2562e00d2193"));
        }
    }
}
