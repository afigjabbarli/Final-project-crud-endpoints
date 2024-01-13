using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class SeedinginitialvaluestoCategorytable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CurrentCategoryId",
                table: "Subcategories",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "Description", "LastUpdatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("1d11d022-125b-48f8-988d-3cec3846e976"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Discover cutting-edge smartphones and accessories for seamless connectivity. Elevate your mobile experience with the latest technology, from feature-packed smartphones to stylish and functional accessories that enhance usability and style.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Smartphones and accessories" },
                    { new Guid("2d7ea6fd-0ca5-41f4-98d0-4cbb5f53ee41"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Immerse yourself in entertainment with TV, audio, and photo solutions. Explore stunning visuals, crystal-clear sound, and capture moments with cutting-edge technology, enhancing your audio-visual experience at home.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "TV, audio and photo" },
                    { new Guid("2d831552-2c29-4df3-b267-3f7a3c8f5f67"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Elevate your gaming experience with cutting-edge products for gamers. Unleash the power of high-performance hardware, immersive accessories, and advanced gear designed to take your gaming to the next level.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Products for gamers" },
                    { new Guid("2e86b076-6aa6-4d8f-9162-167c7551041f"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Explore the future with smart gadgets. Experience seamless integration of technology into daily life with innovative devices, from smart home solutions to wearables, enhancing convenience, connectivity, and efficiency.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Smart gadgets" },
                    { new Guid("6944c639-0326-4ebd-b421-d22687d1d6e7"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Upgrade your home with efficient and modern home appliances. Explore a diverse range of devices, from energy-efficient appliances to smart home solutions, making everyday tasks convenient and your living space more comfortable.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Home appliances" },
                    { new Guid("6c1f6448-3983-475a-9dca-9ba8d3dbbf79"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Discover a world of well-being with beauty and health equipment. From advanced skincare devices to fitness technology, elevate your self-care routine with innovative products designed to promote beauty and wellness.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Beauty and health equipment" },
                    { new Guid("96559f96-23dd-4940-a2c9-3a23c9b4193e"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Empower your digital journey with notebooks, PCs, and tablets. Find the perfect balance of performance and portability. Choose from a diverse range of computing solutions tailored to your needs.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Notebooks, PCs, tablets" },
                    { new Guid("dc305526-f312-4dea-a421-9f3698e97380"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Transform your kitchen with modern convenience. Explore a range of innovative kitchen appliances, from efficient cookware to time-saving gadgets, enhancing your culinary experience with style and functionality.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Kitchen appliances" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subcategories_CurrentCategoryId",
                table: "Subcategories",
                column: "CurrentCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subcategories_Categories_CurrentCategoryId",
                table: "Subcategories",
                column: "CurrentCategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subcategories_Categories_CurrentCategoryId",
                table: "Subcategories");

            migrationBuilder.DropIndex(
                name: "IX_Subcategories_CurrentCategoryId",
                table: "Subcategories");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1d11d022-125b-48f8-988d-3cec3846e976"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2d7ea6fd-0ca5-41f4-98d0-4cbb5f53ee41"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2d831552-2c29-4df3-b267-3f7a3c8f5f67"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2e86b076-6aa6-4d8f-9162-167c7551041f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6944c639-0326-4ebd-b421-d22687d1d6e7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6c1f6448-3983-475a-9dca-9ba8d3dbbf79"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("96559f96-23dd-4940-a2c9-3a23c9b4193e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dc305526-f312-4dea-a421-9f3698e97380"));

            migrationBuilder.DropColumn(
                name: "CurrentCategoryId",
                table: "Subcategories");
        }
    }
}
