using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class AddCategory_CodecolumntoCategorytable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TrackingCode",
                table: "Products",
                newName: "Product_Code");

            migrationBuilder.AddColumn<string>(
                name: "Category_Code",
                table: "Categories",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3a0c847a-8ce1-4f14-916f-3e4b899d19d9"),
                column: "Category_Code",
                value: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c0298b4-09c2-46e1-8baa-10b8395ebd94"),
                column: "Category_Code",
                value: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5b9e0bd5-927c-4d4b-9534-9b67ef7235b2"),
                column: "Category_Code",
                value: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("68a906fa-2d2e-4bb7-a93a-9d12305b07a3"),
                column: "Category_Code",
                value: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("78a7d439-5769-4a7d-8a14-d3f589e71b1f"),
                column: "Category_Code",
                value: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8ff9b1e2-0630-4821-aa16-13937e509ee2"),
                column: "Category_Code",
                value: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9214f8c7-7c65-4c6d-852c-9f6f6c232a21"),
                column: "Category_Code",
                value: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a1e01df1-f0ef-4e89-a68b-3cd32bfbc04f"),
                column: "Category_Code",
                value: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b654a618-ec4f-4d7f-a90e-0c5ea3eaa0e1"),
                column: "Category_Code",
                value: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cdb59c3a-487c-42e5-bc0e-58ad5cfb93d3"),
                column: "Category_Code",
                value: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d2bc155a-9de0-40ed-b3e7-1a4c0983c2e5"),
                column: "Category_Code",
                value: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f6b3406c-6046-486f-8ba8-a896ac26fe90"),
                column: "Category_Code",
                value: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category_Code",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "Product_Code",
                table: "Products",
                newName: "TrackingCode");
        }
    }
}
