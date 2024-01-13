using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class seedingsubcategoriesofAutomotiveproductscategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "CreatedAt", "Current_Category_Id", "Description", "LastUpdatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("2c6e7f8d-af34-48bd-b2a1-c5c8d39a6e4f"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("3a0c847a-8ce1-4f14-916f-3e4b899d19d9"), "Optimize your cutting and grinding tasks with our selection of high-quality discs and wheels. From abrasive grinding wheels to precision cutting discs, our collection caters to various applications and materials. Explore durable designs, reliable materials, and innovative features that ensure efficiency and precision in your projects. Elevate your work with our carefully curated range of discs and wheels, providing the essential tools for metalworking, construction, and other applications.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Discs and wheels" },
                    { new Guid("4e9b8c5a-d0e2-4af6-b6cf-d91c2f8e5b7a"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("3a0c847a-8ce1-4f14-916f-3e4b899d19d9"), "Keep your vehicle running smoothly with our comprehensive selection of spare parts for cars. From essential components like brake pads and filters to critical engine parts and electrical components, our collection caters to various makes and models. Explore reliable brands, quality materials, and a diverse range of automotive spare parts that ensure durability and performance. Elevate your vehicle maintenance with our carefully curated selection, providing the essential components for optimal functionality and longevity.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Spare parts for cars" },
                    { new Guid("8d2a5c6f-4e0b-495f-96b8-fd37a1c9e8d6"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("3a0c847a-8ce1-4f14-916f-3e4b899d19d9"), "Upgrade your vehicle's technology with our cutting-edge automotive electronics. From advanced infotainment systems and GPS navigation to state-of-the-art car audio and safety electronics, our collection is designed to enhance your driving experience. Explore innovative features, connectivity options, and safety solutions that bring modern technology to your vehicle. Elevate your driving journey with our carefully curated range of automotive electronics, ensuring a seamless blend of entertainment, connectivity, and safety on the road.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Automotive electronics" },
                    { new Guid("9a1d8e5b-8c0f-4e2a-af0d-7d5f3e6c4b0a"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("3a0c847a-8ce1-4f14-916f-3e4b899d19d9"), "Preserve the beauty of your vehicle with our selection of high-quality car care tools. From durable microfiber cloths and soft-bristle brushes to precision applicators and efficient cleaning solutions, our collection is designed to keep your car looking its best. Explore tools that cater to every aspect of car care, ensuring a thorough and effective cleaning and detailing process. Elevate your car care routine with our carefully curated range of tools, providing the essential instruments for maintaining the pristine condition of your vehicle.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Car care tools" },
                    { new Guid("a8b7c3d6-5e29-4d18-9c7a-e6f85d1c2b4c"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("3a0c847a-8ce1-4f14-916f-3e4b899d19d9"), "Enhance your driving experience with our curated selection of car accessories. From versatile phone mounts and stylish seat covers to high-tech dash cams and convenient organizers, our collection caters to both functionality and style. Explore accessories that elevate comfort, convenience, and aesthetics in your vehicle. Whether you're looking for practical additions or personalized touches, our range of car accessories ensures you can tailor your driving space to suit your preferences. Elevate your journey with thoughtfully chosen automotive enhancements.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Car accessories" },
                    { new Guid("d9c6e8f5-742e-4d8f-a7e6-13d6c9b2a1d5"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("3a0c847a-8ce1-4f14-916f-3e4b899d19d9"), "Explore our range of high-quality oils and liquids designed to enhance performance and lubrication across various applications. From specialized lubricants for machinery to essential oils for automotive maintenance, our collection prioritizes reliability and efficiency. Discover carefully curated products with innovative formulations, ensuring optimal performance and longevity for your equipment. Elevate your operations with our selection of oils and liquids, providing the essential fluids for smooth-running machinery and vehicles.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Oils and liquids" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("2c6e7f8d-af34-48bd-b2a1-c5c8d39a6e4f"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("4e9b8c5a-d0e2-4af6-b6cf-d91c2f8e5b7a"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("8d2a5c6f-4e0b-495f-96b8-fd37a1c9e8d6"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("9a1d8e5b-8c0f-4e2a-af0d-7d5f3e6c4b0a"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("a8b7c3d6-5e29-4d18-9c7a-e6f85d1c2b4c"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("d9c6e8f5-742e-4d8f-a7e6-13d6c9b2a1d5"));
        }
    }
}
