using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class Addingnewtablestodatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductColor_Colors_Color_Id",
                table: "ProductColor");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductColor_Products_Product_Id",
                table: "ProductColor");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSize_Products_Product_Id",
                table: "ProductSize");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSize_Sizes_Size_Id",
                table: "ProductSize");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductStore_Products_Product_Id",
                table: "ProductStore");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductStore_Stores_Store_Id",
                table: "ProductStore");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductWarranty_Products_Product_Id",
                table: "ProductWarranty");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductWarranty_Warranties_Warranty_Id",
                table: "ProductWarranty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductWarranty",
                table: "ProductWarranty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductStore",
                table: "ProductStore");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSize",
                table: "ProductSize");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductColor",
                table: "ProductColor");

            migrationBuilder.RenameTable(
                name: "ProductWarranty",
                newName: "ProductWarranties");

            migrationBuilder.RenameTable(
                name: "ProductStore",
                newName: "ProductStores");

            migrationBuilder.RenameTable(
                name: "ProductSize",
                newName: "ProductSizes");

            migrationBuilder.RenameTable(
                name: "ProductColor",
                newName: "ProductColors");

            migrationBuilder.RenameIndex(
                name: "IX_ProductWarranty_Warranty_Id",
                table: "ProductWarranties",
                newName: "IX_ProductWarranties_Warranty_Id");

            migrationBuilder.RenameIndex(
                name: "IX_ProductStore_Store_Id",
                table: "ProductStores",
                newName: "IX_ProductStores_Store_Id");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSize_Size_Id",
                table: "ProductSizes",
                newName: "IX_ProductSizes_Size_Id");

            migrationBuilder.RenameIndex(
                name: "IX_ProductColor_Color_Id",
                table: "ProductColors",
                newName: "IX_ProductColors_Color_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductWarranties",
                table: "ProductWarranties",
                columns: new[] { "Product_Id", "Warranty_Id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductStores",
                table: "ProductStores",
                columns: new[] { "Product_Id", "Store_Id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSizes",
                table: "ProductSizes",
                columns: new[] { "Product_Id", "Size_Id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductColors",
                table: "ProductColors",
                columns: new[] { "Product_Id", "Color_Id" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductColors_Colors_Color_Id",
                table: "ProductColors",
                column: "Color_Id",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductColors_Products_Product_Id",
                table: "ProductColors",
                column: "Product_Id",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSizes_Products_Product_Id",
                table: "ProductSizes",
                column: "Product_Id",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSizes_Sizes_Size_Id",
                table: "ProductSizes",
                column: "Size_Id",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductStores_Products_Product_Id",
                table: "ProductStores",
                column: "Product_Id",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductStores_Stores_Store_Id",
                table: "ProductStores",
                column: "Store_Id",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductWarranties_Products_Product_Id",
                table: "ProductWarranties",
                column: "Product_Id",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductWarranties_Warranties_Warranty_Id",
                table: "ProductWarranties",
                column: "Warranty_Id",
                principalTable: "Warranties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductColors_Colors_Color_Id",
                table: "ProductColors");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductColors_Products_Product_Id",
                table: "ProductColors");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSizes_Products_Product_Id",
                table: "ProductSizes");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSizes_Sizes_Size_Id",
                table: "ProductSizes");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductStores_Products_Product_Id",
                table: "ProductStores");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductStores_Stores_Store_Id",
                table: "ProductStores");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductWarranties_Products_Product_Id",
                table: "ProductWarranties");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductWarranties_Warranties_Warranty_Id",
                table: "ProductWarranties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductWarranties",
                table: "ProductWarranties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductStores",
                table: "ProductStores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSizes",
                table: "ProductSizes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductColors",
                table: "ProductColors");

            migrationBuilder.RenameTable(
                name: "ProductWarranties",
                newName: "ProductWarranty");

            migrationBuilder.RenameTable(
                name: "ProductStores",
                newName: "ProductStore");

            migrationBuilder.RenameTable(
                name: "ProductSizes",
                newName: "ProductSize");

            migrationBuilder.RenameTable(
                name: "ProductColors",
                newName: "ProductColor");

            migrationBuilder.RenameIndex(
                name: "IX_ProductWarranties_Warranty_Id",
                table: "ProductWarranty",
                newName: "IX_ProductWarranty_Warranty_Id");

            migrationBuilder.RenameIndex(
                name: "IX_ProductStores_Store_Id",
                table: "ProductStore",
                newName: "IX_ProductStore_Store_Id");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSizes_Size_Id",
                table: "ProductSize",
                newName: "IX_ProductSize_Size_Id");

            migrationBuilder.RenameIndex(
                name: "IX_ProductColors_Color_Id",
                table: "ProductColor",
                newName: "IX_ProductColor_Color_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductWarranty",
                table: "ProductWarranty",
                columns: new[] { "Product_Id", "Warranty_Id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductStore",
                table: "ProductStore",
                columns: new[] { "Product_Id", "Store_Id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSize",
                table: "ProductSize",
                columns: new[] { "Product_Id", "Size_Id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductColor",
                table: "ProductColor",
                columns: new[] { "Product_Id", "Color_Id" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductColor_Colors_Color_Id",
                table: "ProductColor",
                column: "Color_Id",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductColor_Products_Product_Id",
                table: "ProductColor",
                column: "Product_Id",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSize_Products_Product_Id",
                table: "ProductSize",
                column: "Product_Id",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSize_Sizes_Size_Id",
                table: "ProductSize",
                column: "Size_Id",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductStore_Products_Product_Id",
                table: "ProductStore",
                column: "Product_Id",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductStore_Stores_Store_Id",
                table: "ProductStore",
                column: "Store_Id",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductWarranty_Products_Product_Id",
                table: "ProductWarranty",
                column: "Product_Id",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductWarranty_Warranties_Warranty_Id",
                table: "ProductWarranty",
                column: "Warranty_Id",
                principalTable: "Warranties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
