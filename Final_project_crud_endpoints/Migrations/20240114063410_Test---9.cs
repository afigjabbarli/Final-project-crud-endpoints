using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class Test9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Deepcategories",
                columns: new[] { "Id", "CreatedAt", "Current_Subcategory_Id", "Description", "LastUpdatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("0f810786-43f5-41f1-929d-89d80b9a9235"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("d4b8a5c2-c4db-4e3f-aa3f-3d389f5a1aeb"), "Experience the epitome of technology and innovation with Samsung's diverse product range. From flagship smartphones like the Galaxy series to smart TVs, home appliances, and cutting-edge wearables, Samsung offers a comprehensive ecosystem. Discover stunning displays, powerful performance, and advanced features that redefine the way we live and connect. Elevate your digital lifestyle with Samsung's thoughtfully designed products, bringing together quality, innovation, and versatility in every device.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Samsung" },
                    { new Guid("14db8bd4-4b22-4726-8058-4b02e2a16b73"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("d4b8a5c2-c4db-4e3f-aa3f-3d389f5a1aeb"), "Boasting a powerful 2-in-1 calling chip & stable 5.2 Bluetooth connection, Kr Pro provides you an stable, clear and high sound quality phone calls at anytime & anywhere. Conveniently receive & reject phone calls, dial out and store up to 100 contacts on your Kr Pro smart watch!", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Kieslect" },
                    { new Guid("838f5b32-13c6-4910-9b43-bb06174d2165"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("d4b8a5c2-c4db-4e3f-aa3f-3d389f5a1aeb"), "Immerse yourself in innovation with Huawei's diverse range of technology products. From flagship smartphones like the P and Mate series to cutting-edge wearables, laptops, and networking solutions, Huawei offers a comprehensive ecosystem. Discover advanced camera technology, powerful performance, and sleek designs that redefine the possibilities of connected living. Elevate your digital experience with Huawei's thoughtfully designed products, where innovation, craftsmanship, and efficiency converge.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "HUAWEI" },
                    { new Guid("ca0e67f6-20c4-49f1-8f91-d7cd17e374a3"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("d4b8a5c2-c4db-4e3f-aa3f-3d389f5a1aeb"), "Explore the world of innovation with Apple's cutting-edge products. From the iconic iPhone series to sleek MacBook laptops and powerful iPads, Apple offers a seamless ecosystem of devices. Discover high-quality craftsmanship, stunning displays, and user-friendly interfaces that redefine technology. Elevate your digital experience with Apple's thoughtfully designed products, ensuring a blend of style, performance, and innovation in every device.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Apple" },
                    { new Guid("cce8806d-26a8-4601-80e5-acbcfc0dc553"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("d4b8a5c2-c4db-4e3f-aa3f-3d389f5a1aeb"), "Explore the world of innovation with Xiaomi's diverse range of technology products. From feature-packed smartphones and smart home devices to fitness wearables and more, Xiaomi offers a wide array of products that combine quality with affordability. Discover cutting-edge technology, sleek designs, and user-friendly interfaces that cater to various aspects of modern living. Elevate your tech experience with Xiaomi's thoughtfully crafted products, where innovation meets accessibility.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Xiaomi" },
                    { new Guid("f8623b5a-756b-4b4e-89ad-3204dd8088d1"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("d4b8a5c2-c4db-4e3f-aa3f-3d389f5a1aeb"), "Amazfit is a brand of smartwatches and fitness trackers primarily produced by Huami, a Chinese company that specializes in wearable technology. Amazfit smartwatches are known for their focus on health and fitness features, as well as stylish designs. ", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "AMAZFIT" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("0f810786-43f5-41f1-929d-89d80b9a9235"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("14db8bd4-4b22-4726-8058-4b02e2a16b73"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("838f5b32-13c6-4910-9b43-bb06174d2165"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("ca0e67f6-20c4-49f1-8f91-d7cd17e374a3"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("cce8806d-26a8-4601-80e5-acbcfc0dc553"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("f8623b5a-756b-4b4e-89ad-3204dd8088d1"));
        }
    }
}
