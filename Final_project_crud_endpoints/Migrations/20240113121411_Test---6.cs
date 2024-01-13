using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class Test6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("02b84dde-1ae8-4e03-81f9-c164ef536b19"),
                columns: new[] { "CreatedAt", "Description", "LastUpdatedAt", "Name" },
                values: new object[] { new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Experience durability and rugged design with Blackview smartphones. From robust devices to outdoor-friendly models, Blackview offers a range of smartphones that withstand tough conditions. Discover features like water resistance, long-lasting batteries, and reliable performance. Elevate your mobile adventures with Blackview's thoughtfully crafted smartphones.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Blackview" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("1201990f-f7fa-486c-a98b-40065fd130cb"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Explore the world of innovation with Xiaomi's diverse range of technology products. From feature-packed smartphones and smart home devices to fitness wearables and more, Xiaomi offers a wide array of products that combine quality with affordability. Discover cutting-edge technology, sleek designs, and user-friendly interfaces that cater to various aspects of modern living. Elevate your tech experience with Xiaomi's thoughtfully crafted products, where innovation meets accessibility.", "Xiaomi" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("599c9f12-b1c9-4dc0-8854-1af53d3bc2f0"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Experience the epitome of technology and innovation with Samsung's diverse product range. From flagship smartphones like the Galaxy series to smart TVs, home appliances, and cutting-edge wearables, Samsung offers a comprehensive ecosystem. Discover stunning displays, powerful performance, and advanced features that redefine the way we live and connect. Elevate your digital lifestyle with Samsung's thoughtfully designed products, bringing together quality, innovation, and versatility in every device.", "Samsung" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("87f60f99-e88a-4a8b-9269-d67d4cc0106e"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Dive into the realm of innovation with OPPO's exceptional lineup of smartphones. From sleek designs to cutting-edge camera technology, OPPO offers a range of devices that prioritize style and functionality. Explore the latest in mobile innovation with OPPO's commitment to delivering impressive features and powerful performance. Elevate your mobile experience with OPPO's thoughtfully crafted smartphones, blending style, innovation, and user-friendly design.", "OPPO" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("e59993b4-0e5f-4972-96d6-2b9928af3296"),
                columns: new[] { "CreatedAt", "Description", "LastUpdatedAt", "Name" },
                values: new object[] { new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Explore the world of innovation with Apple's cutting-edge products. From the iconic iPhone series to sleek MacBook laptops and powerful iPads, Apple offers a seamless ecosystem of devices. Discover high-quality craftsmanship, stunning displays, and user-friendly interfaces that redefine technology. Elevate your digital experience with Apple's thoughtfully designed products, ensuring a blend of style, performance, and innovation in every device.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Apple" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("02b84dde-1ae8-4e03-81f9-c164ef536b19"),
                columns: new[] { "CreatedAt", "Description", "LastUpdatedAt", "Name" },
                values: new object[] { new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Explore the world of innovation with Xiaomi's diverse range of technology products. From feature-packed smartphones and smart home devices to fitness wearables and more, Xiaomi offers a wide array of products that combine quality with affordability. Discover cutting-edge technology, sleek designs, and user-friendly interfaces that cater to various aspects of modern living. Elevate your tech experience with Xiaomi's thoughtfully crafted products, where innovation meets accessibility.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Xiaomi" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("1201990f-f7fa-486c-a98b-40065fd130cb"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Dive into the realm of innovation with OPPO's exceptional lineup of smartphones. From sleek designs to cutting-edge camera technology, OPPO offers a range of devices that prioritize style and functionality. Explore the latest in mobile innovation with OPPO's commitment to delivering impressive features and powerful performance. Elevate your mobile experience with OPPO's thoughtfully crafted smartphones, blending style, innovation, and user-friendly design.", "OPPO" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("599c9f12-b1c9-4dc0-8854-1af53d3bc2f0"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Explore the world of innovation with Apple's cutting-edge products. From the iconic iPhone series to sleek MacBook laptops and powerful iPads, Apple offers a seamless ecosystem of devices. Discover high-quality craftsmanship, stunning displays, and user-friendly interfaces that redefine technology. Elevate your digital experience with Apple's thoughtfully designed products, ensuring a blend of style, performance, and innovation in every device.", "Apple" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("87f60f99-e88a-4a8b-9269-d67d4cc0106e"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Experience the epitome of technology and innovation with Samsung's diverse product range. From flagship smartphones like the Galaxy series to smart TVs, home appliances, and cutting-edge wearables, Samsung offers a comprehensive ecosystem. Discover stunning displays, powerful performance, and advanced features that redefine the way we live and connect. Elevate your digital lifestyle with Samsung's thoughtfully designed products, bringing together quality, innovation, and versatility in every device.", "Samsung" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("e59993b4-0e5f-4972-96d6-2b9928af3296"),
                columns: new[] { "CreatedAt", "Description", "LastUpdatedAt", "Name" },
                values: new object[] { new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Experience durability and rugged design with Blackview smartphones. From robust devices to outdoor-friendly models, Blackview offers a range of smartphones that withstand tough conditions. Discover features like water resistance, long-lasting batteries, and reliable performance. Elevate your mobile adventures with Blackview's thoughtfully crafted smartphones.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Blackview" });
        }
    }
}
