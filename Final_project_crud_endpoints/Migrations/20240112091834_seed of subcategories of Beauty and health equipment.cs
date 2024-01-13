using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class seedofsubcategoriesofBeautyandhealthequipment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "CreatedAt", "Current_Category_Id", "Description", "LastUpdatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("1f6e8d24-8653-4270-8e3d-6cfe922a4b8a"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("d2bc155a-9de0-40ed-b3e7-1a4c0983c2e5"), "Craft your signature look with our comprehensive selection of shaving and haircut essentials. From precision trimmers and electric razors to grooming kits and high-quality shaving creams, our collection offers everything you need for a polished appearance. Enjoy a personalized grooming experience with tools designed for precision, comfort, and style. Elevate your self-care routine and achieve a well-groomed look effortlessly with our curated shaving and haircut essentials.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Shaving and haircut" },
                    { new Guid("47bd8a53-93c2-4bc7-b77b-9c6d8e9352c6"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("d2bc155a-9de0-40ed-b3e7-1a4c0983c2e5"), "Prioritize your well-being with our comprehensive range of health products. From fitness trackers and home workout equipment to nutritional supplements and personal care items, our collection is designed to support a healthy and active lifestyle. Explore innovative solutions that cater to physical and mental well-being, ensuring you have the tools to prioritize health in your daily routine. Elevate your journey to a healthier you with our thoughtfully curated health products.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Health" },
                    { new Guid("8b9c3aef-6154-4c9d-ae56-7a3df134f71b"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("d2bc155a-9de0-40ed-b3e7-1a4c0983c2e5"), "Transform your look with our diverse collection of hairstyling tools and products. From high-quality hairdryers and professional-grade straighteners to a variety of styling brushes and hair care products, our range caters to all your hairstyling needs. Whether you're aiming for sleek and straight, bouncy curls, or a trendy updo, our hairstyling tools and products offer versatility and creativity. Elevate your personal style and express yourself with the latest in hairstyling innovation.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Hairstyle" },
                    { new Guid("f6c2d95e-4d7d-41f2-aa1a-23a40dd8b4b9"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("d2bc155a-9de0-40ed-b3e7-1a4c0983c2e5"), "Prioritize your well-being with our comprehensive range of health products. From fitness trackers and home workout equipment to nutritional supplements and personal care items, our collection is designed to support a healthy and active lifestyle. Explore innovative solutions that cater to physical and mental well-being, ensuring you have the tools to prioritize health in your daily routine. Elevate your journey to a healthier you with our thoughtfully curated health products.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Health" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("1f6e8d24-8653-4270-8e3d-6cfe922a4b8a"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("47bd8a53-93c2-4bc7-b77b-9c6d8e9352c6"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("8b9c3aef-6154-4c9d-ae56-7a3df134f71b"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("f6c2d95e-4d7d-41f2-aa1a-23a40dd8b4b9"));
        }
    }
}
