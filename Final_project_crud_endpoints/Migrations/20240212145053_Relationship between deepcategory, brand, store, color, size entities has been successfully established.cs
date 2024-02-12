using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class Relationshipbetweendeepcategorybrandstorecolorsizeentitieshasbeensuccessfullyestablished : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "Current_Brand_Id",
                table: "Products",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Current_Deepcategory_Id",
                table: "Products",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "ProductColor",
                columns: table => new
                {
                    Product_Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Color_Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductColor", x => new { x.Product_Id, x.Color_Id });
                    table.ForeignKey(
                        name: "FK_ProductColor_Colors_Color_Id",
                        column: x => x.Color_Id,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductColor_Products_Product_Id",
                        column: x => x.Product_Id,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSize",
                columns: table => new
                {
                    Product_Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Size_Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSize", x => new { x.Product_Id, x.Size_Id });
                    table.ForeignKey(
                        name: "FK_ProductSize_Products_Product_Id",
                        column: x => x.Product_Id,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSize_Sizes_Size_Id",
                        column: x => x.Size_Id,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductStore",
                columns: table => new
                {
                    Product_Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Store_Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductStore", x => new { x.Product_Id, x.Store_Id });
                    table.ForeignKey(
                        name: "FK_ProductStore_Products_Product_Id",
                        column: x => x.Product_Id,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductStore_Stores_Store_Id",
                        column: x => x.Store_Id,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_Current_Brand_Id",
                table: "Products",
                column: "Current_Brand_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Current_Deepcategory_Id",
                table: "Products",
                column: "Current_Deepcategory_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProductColor_Color_Id",
                table: "ProductColor",
                column: "Color_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSize_Size_Id",
                table: "ProductSize",
                column: "Size_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProductStore_Store_Id",
                table: "ProductStore",
                column: "Store_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Brands_Current_Brand_Id",
                table: "Products",
                column: "Current_Brand_Id",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Deepcategories_Current_Deepcategory_Id",
                table: "Products",
                column: "Current_Deepcategory_Id",
                principalTable: "Deepcategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Brands_Current_Brand_Id",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Deepcategories_Current_Deepcategory_Id",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ProductColor");

            migrationBuilder.DropTable(
                name: "ProductSize");

            migrationBuilder.DropTable(
                name: "ProductStore");

            migrationBuilder.DropIndex(
                name: "IX_Products_Current_Brand_Id",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_Current_Deepcategory_Id",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Current_Brand_Id",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Current_Deepcategory_Id",
                table: "Products");
        }
    }
}
