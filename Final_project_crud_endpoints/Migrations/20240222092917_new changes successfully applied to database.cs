using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class newchangessuccessfullyappliedtodatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color_IDs",
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

            migrationBuilder.AddColumn<Guid>(
                name: "ColorID",
                table: "BasketItems",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SizeID",
                table: "BasketItems",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "StoreID",
                table: "BasketItems",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "WarrantyID",
                table: "BasketItems",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ColorID",
                table: "BasketItems");

            migrationBuilder.DropColumn(
                name: "SizeID",
                table: "BasketItems");

            migrationBuilder.DropColumn(
                name: "StoreID",
                table: "BasketItems");

            migrationBuilder.DropColumn(
                name: "WarrantyID",
                table: "BasketItems");

            migrationBuilder.AddColumn<Guid[]>(
                name: "Color_IDs",
                table: "BasketItems",
                type: "uuid[]",
                nullable: false,
                defaultValue: new Guid[0]);

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
    }
}
