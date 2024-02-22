using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class addnewcolumnstoorderitemtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Order_Item_Single_Price",
                table: "OrderItems",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Phisical_Image_Name",
                table: "OrderItems",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Product_Code",
                table: "OrderItems",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Order_Item_Single_Price",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "Phisical_Image_Name",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "Product_Code",
                table: "OrderItems");
        }
    }
}
