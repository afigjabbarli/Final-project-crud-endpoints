using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class seedofsubcategoriesofTVaudioandphoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "CreatedAt", "Current_Category_Id", "Description", "LastUpdatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("3a6b95f8-eda4-45b8-9dd1-1aa64e2eeb8c"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("68a906fa-2d2e-4bb7-a93a-9d12305b07a3"), "Enhance your television experience with our range of TV accessories. From versatile wall mounts and sleek soundbars to advanced remote controls and immersive lighting solutions, our collection is designed to complement and elevate your viewing setup. Explore accessories that add convenience, style, and enhanced functionality to your entertainment space. Transform your TV into a complete multimedia experience with our thoughtfully curated selection of TV accessories.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "TV accessories" },
                    { new Guid("4c9b5a81-7f8c-4ee0-8ba2-ead63a7dc6f3"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("68a906fa-2d2e-4bb7-a93a-9d12305b07a3"), "", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "TV in HD format" },
                    { new Guid("7dfe9a0c-2457-4db2-9c59-0f3705dbde44"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("68a906fa-2d2e-4bb7-a93a-9d12305b07a3"), "Immerse yourself in superior sound quality with our diverse range of audio equipment. From high-fidelity speakers and headphones to powerful amplifiers and versatile audio accessories, our collection caters to audiophiles and music enthusiasts. Explore cutting-edge technology that delivers crisp and immersive audio experiences. Elevate your sound journey with our thoughtfully curated selection of audio equipment designed to enhance every note, beat, and melody in your favorite music.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Audio equipment" },
                    { new Guid("7f6a8e21-8fe1-4f0f-93b9-af14ab0f86c1"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("68a906fa-2d2e-4bb7-a93a-9d12305b07a3"), "Capture the perfect shot with our range of photography essentials. From high-quality lenses and powerful flashes to versatile camera accessories, our collection caters to photographers of all levels. Explore equipment that enhances creativity, ensures precision, and adds versatility to your photography gear. Elevate your photographic skills with our carefully curated selection of lenses, flashes, and accessories designed to bring out the best in every shot.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Lenses, flashes, accessories" },
                    { new Guid("94bd67a9-3c6a-4d1f-b2b2-0f8915ac5c2a"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("68a906fa-2d2e-4bb7-a93a-9d12305b07a3"), "", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "On TV technology" },
                    { new Guid("9e4b6a3d-5e32-4ea7-bff4-34bc47eeef71"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("68a906fa-2d2e-4bb7-a93a-9d12305b07a3"), "Unleash your creativity with our comprehensive range of cameras and photography equipment. From powerful DSLRs and compact mirrorless cameras to versatile action cameras and high-quality lenses, our collection caters to photographers of all levels. Discover cutting-edge technology and innovative features that capture every moment in stunning detail. Elevate your photography experience with our curated selection of cameras and accessories, designed to meet the diverse needs of enthusiasts and professionals alike.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Camera and cameras" },
                    { new Guid("afe0d8b2-4f44-4821-a6b9-5e1e77d892db"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("68a906fa-2d2e-4bb7-a93a-9d12305b07a3"), "", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "TV brands" },
                    { new Guid("b8c2a1d4-6d8c-42e4-98fe-8c31a26a6a2c"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("68a906fa-2d2e-4bb7-a93a-9d12305b07a3"), "", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "TV diagonally" },
                    { new Guid("d1e39c7c-5d2d-42f1-982d-cf6b3f46b9a1"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("68a906fa-2d2e-4bb7-a93a-9d12305b07a3"), "Elevate your viewing experience with our stylish and functional TV stands. From modern designs with sleek finishes to versatile options with ample storage, our collection caters to various tastes and needs. Discover sturdy stands that complement your home decor while providing a stable platform for your television. Whether you prefer a minimalist look or need extra storage for entertainment essentials, our TV stands combine form and function to enhance your living space.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "TV stands" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("3a6b95f8-eda4-45b8-9dd1-1aa64e2eeb8c"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("4c9b5a81-7f8c-4ee0-8ba2-ead63a7dc6f3"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("7dfe9a0c-2457-4db2-9c59-0f3705dbde44"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("7f6a8e21-8fe1-4f0f-93b9-af14ab0f86c1"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("94bd67a9-3c6a-4d1f-b2b2-0f8915ac5c2a"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("9e4b6a3d-5e32-4ea7-bff4-34bc47eeef71"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("afe0d8b2-4f44-4821-a6b9-5e1e77d892db"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("b8c2a1d4-6d8c-42e4-98fe-8c31a26a6a2c"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("d1e39c7c-5d2d-42f1-982d-cf6b3f46b9a1"));
        }
    }
}
