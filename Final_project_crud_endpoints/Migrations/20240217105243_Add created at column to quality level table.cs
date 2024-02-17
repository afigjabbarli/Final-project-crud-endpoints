using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class Addcreatedatcolumntoqualityleveltable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "QualityLevels",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "QualityLevels",
                keyColumn: "Id",
                keyValue: new Guid("1ff5f48a-c831-4dff-9509-5b44fd5df76f"),
                column: "CreatedAt",
                value: new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "QualityLevels",
                keyColumn: "Id",
                keyValue: new Guid("2b15840b-5559-40b1-b234-f5bdd36bcc58"),
                column: "CreatedAt",
                value: new DateTime(2021, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "QualityLevels",
                keyColumn: "Id",
                keyValue: new Guid("49ae595c-37be-47e8-ba8f-9fb78354b4ae"),
                column: "CreatedAt",
                value: new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "QualityLevels",
                keyColumn: "Id",
                keyValue: new Guid("71224665-b59d-4186-b35e-a3091b02684f"),
                column: "CreatedAt",
                value: new DateTime(2022, 6, 15, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "QualityLevels",
                keyColumn: "Id",
                keyValue: new Guid("9b7aaf5b-785f-4f0b-9477-fefbffba1d94"),
                column: "CreatedAt",
                value: new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "QualityLevels",
                keyColumn: "Id",
                keyValue: new Guid("af52d28e-a9b3-4537-b46e-640cc66bc637"),
                column: "CreatedAt",
                value: new DateTime(2018, 2, 14, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "QualityLevels",
                keyColumn: "Id",
                keyValue: new Guid("f33ca602-3d70-4840-830d-91616e20e28a"),
                column: "CreatedAt",
                value: new DateTime(2020, 4, 7, 0, 0, 0, 0, DateTimeKind.Utc));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "QualityLevels");
        }
    }
}
