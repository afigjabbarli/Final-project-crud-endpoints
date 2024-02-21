using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class Updatebasketitemstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid[]>(
                name: "Color_IDs",
                table: "BasketItems",
                type: "uuid[]",
                nullable: false,
                defaultValue: new Guid[0]);

            migrationBuilder.AddColumn<Guid>(
                name: "Product_ID",
                table: "BasketItems",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid[]>(
                name: "Size_IDs",
                table: "BasketItems",
                type: "uuid[]",
                nullable: false,
                defaultValue: new Guid[0]);

            migrationBuilder.AddColumn<Guid[]>(
                name: "Store_IDs",
                table: "BasketItems",
                type: "uuid[]",
                nullable: false,
                defaultValue: new Guid[0]);

            migrationBuilder.AddColumn<Guid[]>(
                name: "Warranty_IDs",
                table: "BasketItems",
                type: "uuid[]",
                nullable: false,
                defaultValue: new Guid[0]);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color_IDs",
                table: "BasketItems");

            migrationBuilder.DropColumn(
                name: "Product_ID",
                table: "BasketItems");

            migrationBuilder.DropColumn(
                name: "Size_IDs",
                table: "BasketItems");

            migrationBuilder.DropColumn(
                name: "Store_IDs",
                table: "BasketItems");

            migrationBuilder.DropColumn(
                name: "Warranty_IDs",
                table: "BasketItems");
        }
    }
}
