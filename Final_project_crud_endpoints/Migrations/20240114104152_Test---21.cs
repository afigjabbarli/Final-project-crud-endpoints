using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class Test21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Deepcategories",
                columns: new[] { "Id", "CreatedAt", "Current_Subcategory_Id", "Description", "LastUpdatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("c3f67629-5dca-4a53-9432-247321f507e5"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("6f1d8a61-5b88-4e67-a11f-651b3d09a432"), "Simplify your computing setup with Monoblocks. Combining a sleek display and powerful components, these all-in-one solutions offer efficiency and style for a streamlined desktop experience.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Monoblocks" },
                    { new Guid("c3f67823-5dca-4a53-9432-247321f107e5"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("6f1d8a61-5b88-4e67-a11f-651b3d09a432"), "Build your computing powerhouse with System Blocks. Customize performance, expandability, and style as you create a tailored PC to meet your specific needs and preferences.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "System blocks" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("c3f67629-5dca-4a53-9432-247321f507e5"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("c3f67823-5dca-4a53-9432-247321f107e5"));
        }
    }
}
