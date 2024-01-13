using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class seedingsubcategoriesofConstructionsuppliescategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "CreatedAt", "Current_Category_Id", "Description", "LastUpdatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("1a3f6c8e-cd94-4ac8-84b9-02c3f9d8e0b6"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("8ff9b1e2-0630-4821-aa16-13937e509ee2"), "Equip yourself with the right tools for the job with our comprehensive selection of hand tools for construction. From sturdy hammers and versatile screwdrivers to precise levels and durable tape measures, our collection is designed to meet the needs of builders and craftsmen. Explore ergonomic designs, reliable materials, and innovative features that enhance precision and efficiency on the construction site. Elevate your craftsmanship with our thoughtfully curated range of hand tools, ensuring you have the essential instruments for successful construction projects.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Hand tools for construction" },
                    { new Guid("1a9d6e8f-cd3b-4f80-8c65-3a0e5d8f6b1a"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("8ff9b1e2-0630-4821-aa16-13937e509ee2"), "Ensure a seamless construction process with our wide range of construction consumables. From high-quality adhesives and sealants to essential safety gear and durable work gloves, our collection caters to the diverse needs of construction professionals. Explore reliable brands, innovative solutions, and materials that prioritize safety and efficiency on the job site. Elevate your construction capabilities with our carefully curated range of consumables, providing the essential tools and supplies for successful and secure construction projects.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Construction consumables" },
                    { new Guid("4c2f7b9d-b8a3-4f5c-8369-9e0d4f1e7c2d"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("8ff9b1e2-0630-4821-aa16-13937e509ee2"), "Power your construction projects with our extensive range of construction equipment. From heavy machinery like excavators and bulldozers to versatile tools like concrete mixers and jackhammers, our collection caters to the diverse needs of construction professionals. Explore reliable brands, innovative features, and durable construction that ensures efficiency and productivity on the job site. Elevate your construction capabilities with our carefully curated range of equipment, delivering the strength and versatility needed to tackle any project.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Equipment" },
                    { new Guid("5c0a8f1d-4d7e-4950-abe6-3e8d6f9b2c8a"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("8ff9b1e2-0630-4821-aa16-13937e509ee2"), "Empower your construction projects with our robust selection of power tools. From high-performance drills and saws to versatile sanders and powerful impact wrenches, our collection is designed to meet the demands of construction professionals. Explore reliable brands, innovative features, and durable construction that ensure precision and efficiency on the job. Elevate your construction capabilities with our carefully curated range of power tools, delivering the strength and precision needed to tackle any project.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Power tools for construction" },
                    { new Guid("5e8c4f2d-7a19-4d5e-a18b-9c32f6d8c5b7"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("8ff9b1e2-0630-4821-aa16-13937e509ee2"), "Efficient plumbing solutions for every project. Explore our range of high-quality plumbing products, from durable pipes and fittings to reliable fixtures and innovative accessories. Whether you're working on residential installations or commercial projects, our collection is designed to meet the diverse needs of plumbers and contractors. Elevate your plumbing projects with our carefully curated selection, ensuring precision, durability, and efficiency in every installation and repair.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Plumbing" },
                    { new Guid("7b4c1e8d-36a2-42b1-af95-98d36aefb37d"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("8ff9b1e2-0630-4821-aa16-13937e509ee2"), "Gear up for construction success with our range of durable and functional construction clothing and accessories. From rugged work boots and protective eyewear to high-visibility vests and weather-resistant jackets, our collection prioritizes safety and comfort on the construction site. Explore durable fabrics, innovative designs, and essential accessories that enhance your workwear experience. Elevate your construction gear with our carefully curated selection, ensuring you're equipped for the demands of the job while staying safe and comfortable.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Construction clothing and accessories" },
                    { new Guid("9e7a2c3b-0b15-4f33-ba7d-8cf9e4a1b5a8"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("8ff9b1e2-0630-4821-aa16-13937e509ee2"), "Ensure accuracy and precision in your construction projects with our specialized measuring and marking tools. From durable tape measures and laser levels to precise marking tools, our collection is designed to meet the exacting standards of construction professionals. Explore ergonomic designs and advanced features that enhance efficiency and accuracy on the job. Elevate your construction capabilities with our carefully curated range of measuring and marking tools, providing the precision needed for successful and precise construction projects.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Measuring and marking tools for construction" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("1a3f6c8e-cd94-4ac8-84b9-02c3f9d8e0b6"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("1a9d6e8f-cd3b-4f80-8c65-3a0e5d8f6b1a"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("4c2f7b9d-b8a3-4f5c-8369-9e0d4f1e7c2d"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("5c0a8f1d-4d7e-4950-abe6-3e8d6f9b2c8a"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("5e8c4f2d-7a19-4d5e-a18b-9c32f6d8c5b7"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("7b4c1e8d-36a2-42b1-af95-98d36aefb37d"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("9e7a2c3b-0b15-4f33-ba7d-8cf9e4a1b5a8"));
        }
    }
}
