using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class renamedeepcategorytable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deepcategory_Subcategories_Current_Subcategory_Id",
                table: "Deepcategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Deepcategory",
                table: "Deepcategory");

            migrationBuilder.RenameTable(
                name: "Deepcategory",
                newName: "Deepcategories");

            migrationBuilder.RenameIndex(
                name: "IX_Deepcategory_Current_Subcategory_Id",
                table: "Deepcategories",
                newName: "IX_Deepcategories_Current_Subcategory_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Deepcategories",
                table: "Deepcategories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Deepcategories_Subcategories_Current_Subcategory_Id",
                table: "Deepcategories",
                column: "Current_Subcategory_Id",
                principalTable: "Subcategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deepcategories_Subcategories_Current_Subcategory_Id",
                table: "Deepcategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Deepcategories",
                table: "Deepcategories");

            migrationBuilder.RenameTable(
                name: "Deepcategories",
                newName: "Deepcategory");

            migrationBuilder.RenameIndex(
                name: "IX_Deepcategories_Current_Subcategory_Id",
                table: "Deepcategory",
                newName: "IX_Deepcategory_Current_Subcategory_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Deepcategory",
                table: "Deepcategory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Deepcategory_Subcategories_Current_Subcategory_Id",
                table: "Deepcategory",
                column: "Current_Subcategory_Id",
                principalTable: "Subcategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
