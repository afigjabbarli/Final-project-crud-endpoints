using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class Qualitylevelseedingdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "QualityLevels",
                columns: new[] { "Id", "Level" },
                values: new object[,]
                {
                    { new Guid("1ff5f48a-c831-4dff-9509-5b44fd5df76f"), "ELITE" },
                    { new Guid("2b15840b-5559-40b1-b234-f5bdd36bcc58"), "PREMIUM" },
                    { new Guid("49ae595c-37be-47e8-ba8f-9fb78354b4ae"), "ESSENTIAL" },
                    { new Guid("71224665-b59d-4186-b35e-a3091b02684f"), "LUXE" },
                    { new Guid("9b7aaf5b-785f-4f0b-9477-fefbffba1d94"), "NOVICE" },
                    { new Guid("af52d28e-a9b3-4537-b46e-640cc66bc637"), "ECONOMY" },
                    { new Guid("f33ca602-3d70-4840-830d-91616e20e28a"), "STANDARD" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QualityLevels",
                keyColumn: "Id",
                keyValue: new Guid("1ff5f48a-c831-4dff-9509-5b44fd5df76f"));

            migrationBuilder.DeleteData(
                table: "QualityLevels",
                keyColumn: "Id",
                keyValue: new Guid("2b15840b-5559-40b1-b234-f5bdd36bcc58"));

            migrationBuilder.DeleteData(
                table: "QualityLevels",
                keyColumn: "Id",
                keyValue: new Guid("49ae595c-37be-47e8-ba8f-9fb78354b4ae"));

            migrationBuilder.DeleteData(
                table: "QualityLevels",
                keyColumn: "Id",
                keyValue: new Guid("71224665-b59d-4186-b35e-a3091b02684f"));

            migrationBuilder.DeleteData(
                table: "QualityLevels",
                keyColumn: "Id",
                keyValue: new Guid("9b7aaf5b-785f-4f0b-9477-fefbffba1d94"));

            migrationBuilder.DeleteData(
                table: "QualityLevels",
                keyColumn: "Id",
                keyValue: new Guid("af52d28e-a9b3-4537-b46e-640cc66bc637"));

            migrationBuilder.DeleteData(
                table: "QualityLevels",
                keyColumn: "Id",
                keyValue: new Guid("f33ca602-3d70-4840-830d-91616e20e28a"));
        }
    }
}
