using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class Test8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("738e7941-fce5-4fd0-8bc1-a615c67aa73a"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Nokia is a well-known Finnish multinational telecommunications, information technology, and consumer electronics company. Historically, Nokia was a leading mobile phone manufacturer and played a significant role in the early days of the mobile phone industry. Nokia phones were widely popular and known for their durability and reliability.", "Nokia" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("99554967-268f-461e-854b-9998bc8ef977"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "As of my last knowledge update in January 2022, Energizer is primarily known for its batteries and power-related products, and there is no widely known information about Energizer producing push-button phones. If there have been developments or new product releases since then, I recommend checking the latest information from reliable sources or visiting the official Energizer website for the most up-to-date details on their product offerings.", "Energizer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("738e7941-fce5-4fd0-8bc1-a615c67aa73a"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "As of my last knowledge update in January 2022, Energizer is primarily known for its batteries and power-related products, and there is no widely known information about Energizer producing push-button phones. If there have been developments or new product releases since then, I recommend checking the latest information from reliable sources or visiting the official Energizer website for the most up-to-date details on their product offerings.", "Energizer" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("99554967-268f-461e-854b-9998bc8ef977"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Nokia is a well-known Finnish multinational telecommunications, information technology, and consumer electronics company. Historically, Nokia was a leading mobile phone manufacturer and played a significant role in the early days of the mobile phone industry. Nokia phones were widely popular and known for their durability and reliability.", "Nokia" });
        }
    }
}
