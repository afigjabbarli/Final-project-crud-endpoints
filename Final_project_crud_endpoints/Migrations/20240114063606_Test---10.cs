using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class Test10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("0f810786-43f5-41f1-929d-89d80b9a9235"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Explore the world of innovation with Apple's cutting-edge products. From the iconic iPhone series to sleek MacBook laptops and powerful iPads, Apple offers a seamless ecosystem of devices. Discover high-quality craftsmanship, stunning displays, and user-friendly interfaces that redefine technology. Elevate your digital experience with Apple's thoughtfully designed products, ensuring a blend of style, performance, and innovation in every device.", "Apple" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("14db8bd4-4b22-4726-8058-4b02e2a16b73"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Experience the epitome of technology and innovation with Samsung's diverse product range. From flagship smartphones like the Galaxy series to smart TVs, home appliances, and cutting-edge wearables, Samsung offers a comprehensive ecosystem. Discover stunning displays, powerful performance, and advanced features that redefine the way we live and connect. Elevate your digital lifestyle with Samsung's thoughtfully designed products, bringing together quality, innovation, and versatility in every device.", "Samsung" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("ca0e67f6-20c4-49f1-8f91-d7cd17e374a3"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Explore the world of innovation with Xiaomi's diverse range of technology products. From feature-packed smartphones and smart home devices to fitness wearables and more, Xiaomi offers a wide array of products that combine quality with affordability. Discover cutting-edge technology, sleek designs, and user-friendly interfaces that cater to various aspects of modern living. Elevate your tech experience with Xiaomi's thoughtfully crafted products, where innovation meets accessibility.", "Xiaomi" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("cce8806d-26a8-4601-80e5-acbcfc0dc553"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Amazfit is a brand of smartwatches and fitness trackers primarily produced by Huami, a Chinese company that specializes in wearable technology. Amazfit smartwatches are known for their focus on health and fitness features, as well as stylish designs. ", "AMAZFIT" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("f8623b5a-756b-4b4e-89ad-3204dd8088d1"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Boasting a powerful 2-in-1 calling chip & stable 5.2 Bluetooth connection, Kr Pro provides you an stable, clear and high sound quality phone calls at anytime & anywhere. Conveniently receive & reject phone calls, dial out and store up to 100 contacts on your Kr Pro smart watch!", "Kieslect" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("0f810786-43f5-41f1-929d-89d80b9a9235"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Experience the epitome of technology and innovation with Samsung's diverse product range. From flagship smartphones like the Galaxy series to smart TVs, home appliances, and cutting-edge wearables, Samsung offers a comprehensive ecosystem. Discover stunning displays, powerful performance, and advanced features that redefine the way we live and connect. Elevate your digital lifestyle with Samsung's thoughtfully designed products, bringing together quality, innovation, and versatility in every device.", "Samsung" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("14db8bd4-4b22-4726-8058-4b02e2a16b73"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Boasting a powerful 2-in-1 calling chip & stable 5.2 Bluetooth connection, Kr Pro provides you an stable, clear and high sound quality phone calls at anytime & anywhere. Conveniently receive & reject phone calls, dial out and store up to 100 contacts on your Kr Pro smart watch!", "Kieslect" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("ca0e67f6-20c4-49f1-8f91-d7cd17e374a3"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Explore the world of innovation with Apple's cutting-edge products. From the iconic iPhone series to sleek MacBook laptops and powerful iPads, Apple offers a seamless ecosystem of devices. Discover high-quality craftsmanship, stunning displays, and user-friendly interfaces that redefine technology. Elevate your digital experience with Apple's thoughtfully designed products, ensuring a blend of style, performance, and innovation in every device.", "Apple" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("cce8806d-26a8-4601-80e5-acbcfc0dc553"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Explore the world of innovation with Xiaomi's diverse range of technology products. From feature-packed smartphones and smart home devices to fitness wearables and more, Xiaomi offers a wide array of products that combine quality with affordability. Discover cutting-edge technology, sleek designs, and user-friendly interfaces that cater to various aspects of modern living. Elevate your tech experience with Xiaomi's thoughtfully crafted products, where innovation meets accessibility.", "Xiaomi" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("f8623b5a-756b-4b4e-89ad-3204dd8088d1"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Amazfit is a brand of smartwatches and fitness trackers primarily produced by Huami, a Chinese company that specializes in wearable technology. Amazfit smartwatches are known for their focus on health and fitness features, as well as stylish designs. ", "AMAZFIT" });
        }
    }
}
