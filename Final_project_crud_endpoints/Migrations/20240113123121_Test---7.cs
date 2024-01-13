using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class Test7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Deepcategories",
                columns: new[] { "Id", "CreatedAt", "Current_Subcategory_Id", "Description", "LastUpdatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("738e7941-fce5-4fd0-8bc1-a615c67aa73a"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("23f8c33a-16fc-4eaa-9c3e-b97e130dce9d"), "As of my last knowledge update in January 2022, Energizer is primarily known for its batteries and power-related products, and there is no widely known information about Energizer producing push-button phones. If there have been developments or new product releases since then, I recommend checking the latest information from reliable sources or visiting the official Energizer website for the most up-to-date details on their product offerings.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Energizer" },
                    { new Guid("99554967-268f-461e-854b-9998bc8ef977"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("23f8c33a-16fc-4eaa-9c3e-b97e130dce9d"), "Nokia is a well-known Finnish multinational telecommunications, information technology, and consumer electronics company. Historically, Nokia was a leading mobile phone manufacturer and played a significant role in the early days of the mobile phone industry. Nokia phones were widely popular and known for their durability and reliability.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Nokia" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("738e7941-fce5-4fd0-8bc1-a615c67aa73a"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("99554967-268f-461e-854b-9998bc8ef977"));
        }
    }
}
