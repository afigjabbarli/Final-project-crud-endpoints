using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class Test11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Deepcategories",
                columns: new[] { "Id", "CreatedAt", "Current_Subcategory_Id", "Description", "LastUpdatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("320dfc5c-fb01-45d0-9f93-0b71dcc393b6"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("07ff4b23-b509-41e2-b932-37eae200181c"), "Enhance your fitness journey with Q&Q Smart Bracelets. Track activities, monitor health metrics, and stay connected in style with these innovative and functional wearables.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Q&Q " },
                    { new Guid("8b282235-99da-449e-a0ca-c0a755cf5087"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("07ff4b23-b509-41e2-b932-37eae200181c"), "Experience durability and rugged design with Blackview smartphones. From robust devices to outdoor-friendly models, Blackview offers a range of smartphones that withstand tough conditions. Discover features like water resistance, long-lasting batteries, and reliable performance. Elevate your mobile adventures with Blackview's thoughtfully crafted smartphones.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Blackview" },
                    { new Guid("aacd89bd-f53a-40e6-8cb5-045ac969da2d"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("07ff4b23-b509-41e2-b932-37eae200181c"), "Explore the world of innovation with Xiaomi's diverse range of technology products. From feature-packed smartphones and smart home devices to fitness wearables and more, Xiaomi offers a wide array of products that combine quality with affordability. Discover cutting-edge technology, sleek designs, and user-friendly interfaces that cater to various aspects of modern living. Elevate your tech experience with Xiaomi's thoughtfully crafted products, where innovation meets accessibility.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Xiaomi" },
                    { new Guid("fc34b77b-6812-41fa-b942-998c92a77854"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("07ff4b23-b509-41e2-b932-37eae200181c"), "Immerse yourself in innovation with Huawei's diverse range of technology products. From flagship smartphones like the P and Mate series to cutting-edge wearables, laptops, and networking solutions, Huawei offers a comprehensive ecosystem. Discover advanced camera technology, powerful performance, and sleek designs that redefine the possibilities of connected living. Elevate your digital experience with Huawei's thoughtfully designed products, where innovation, craftsmanship, and efficiency converge.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "HUAWEI" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("320dfc5c-fb01-45d0-9f93-0b71dcc393b6"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("8b282235-99da-449e-a0ca-c0a755cf5087"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("aacd89bd-f53a-40e6-8cb5-045ac969da2d"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("fc34b77b-6812-41fa-b942-998c92a77854"));
        }
    }
}
