using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class warrantyseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Warranties",
                columns: new[] { "Id", "CreatedAt", "Description", "ExpireYear", "LastUpdatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("2bc1d548-e721-4c4a-a866-607b1697f792"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Some sellers or manufacturers may offer extended warranty options, extending the standard warranty period. This provides additional protection after the expiration of the standard warranty period, usually for an extra fee.", 2, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Extended Warranty" },
                    { new Guid("a23d7953-d26c-445a-a094-9dfb4803db32"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), " Offered by the seller, this type of warranty assures protection against specific defects for a certain duration. Also known as a store warranty, it remains valid regardless of where the product was purchased.", 1, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Seller's Warranty" },
                    { new Guid("aee92391-3cbf-41f3-9d9d-95fee80b0c6d"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "This type of warranty covers specific parts of a product. For example, separate warranties might be provided for certain parts of a car, such as the engine or transmission.", 2, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Parts Warranty" },
                    { new Guid("befd7bb6-29aa-46c0-b5dd-3047456eafa5"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "A statutory warranty is based on laws that dictate certain standards a product must meet for a specific period. It's intended to protect consumer rights and is generally valid throughout the expected lifespan of the product.", 2, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Statutory Warranty" },
                    { new Guid("da9360f7-4c2d-495a-b8d1-514f700000a9"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Provided by the manufacturer or brand, this type of warranty typically covers the product against specific defects for a certain period. In case of product failure, the manufacturer warranty may offer free repair or replacement service.", 1, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Manufacturer's Warranty" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Warranties",
                keyColumn: "Id",
                keyValue: new Guid("2bc1d548-e721-4c4a-a866-607b1697f792"));

            migrationBuilder.DeleteData(
                table: "Warranties",
                keyColumn: "Id",
                keyValue: new Guid("a23d7953-d26c-445a-a094-9dfb4803db32"));

            migrationBuilder.DeleteData(
                table: "Warranties",
                keyColumn: "Id",
                keyValue: new Guid("aee92391-3cbf-41f3-9d9d-95fee80b0c6d"));

            migrationBuilder.DeleteData(
                table: "Warranties",
                keyColumn: "Id",
                keyValue: new Guid("befd7bb6-29aa-46c0-b5dd-3047456eafa5"));

            migrationBuilder.DeleteData(
                table: "Warranties",
                keyColumn: "Id",
                keyValue: new Guid("da9360f7-4c2d-495a-b8d1-514f700000a9"));
        }
    }
}
