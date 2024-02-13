using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class Addnewseeddataforwarrantytable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Warranties",
                columns: new[] { "Id", "CreatedAt", "Description", "ExpireYear", "LastUpdatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("00f0c335-f171-49b1-85c2-b506f51f4919"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "This type of warranty covers specific parts of a product. For example, separate warranties might be provided for certain parts of a car, such as the engine or transmission.", 5, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Gold Warranty" },
                    { new Guid("29b6f35a-db7c-43f6-bb3b-5d0a2bd794d6"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "This type of warranty covers specific parts of a product. For example, separate warranties might be provided for certain parts of a car, such as the engine or transmission.", 5, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "V.I.P Warranty" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Warranties",
                keyColumn: "Id",
                keyValue: new Guid("00f0c335-f171-49b1-85c2-b506f51f4919"));

            migrationBuilder.DeleteData(
                table: "Warranties",
                keyColumn: "Id",
                keyValue: new Guid("29b6f35a-db7c-43f6-bb3b-5d0a2bd794d6"));
        }
    }
}
