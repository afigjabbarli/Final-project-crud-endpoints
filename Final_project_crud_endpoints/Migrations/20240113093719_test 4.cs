using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Deepcategories",
                columns: new[] { "Id", "CreatedAt", "Current_Subcategory_Id", "Description", "LastUpdatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("011cd970-d173-45aa-95ba-242b3442809e"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("7a92b0cd-7d8d-4ee9-8a82-4f482b4c4a95"), "Discover the legacy of innovation with Motorola's lineup of smartphones. From iconic designs like the Moto G series to the sleek and powerful Moto Edge devices, Motorola offers a range of smartphones that combine style with functionality. Explore advanced camera systems, long-lasting batteries, and near-stock Android experiences. Elevate your mobile journey with Motorola's thoughtfully crafted smartphones, providing reliable performance and a user-friendly interface for everyday use.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Motorola" },
                    { new Guid("087d5394-9fb8-46f0-beba-a6c8df2c0114"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("7a92b0cd-7d8d-4ee9-8a82-4f482b4c4a95"), "Explore the world of innovation with Apple's cutting-edge products. From the iconic iPhone series to sleek MacBook laptops and powerful iPads, Apple offers a seamless ecosystem of devices. Discover high-quality craftsmanship, stunning displays, and user-friendly interfaces that redefine technology. Elevate your digital experience with Apple's thoughtfully designed products, ensuring a blend of style, performance, and innovation in every device.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Apple" },
                    { new Guid("332253aa-aa2f-4c83-b69b-2ef5afd1395a"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("7a92b0cd-7d8d-4ee9-8a82-4f482b4c4a95"), "Experience affordability and innovation with Infinix smartphones. From sleek designs to feature-packed devices, Infinix offers a range of smartphones that prioritize both style and functionality. Explore cutting-edge technology, impressive camera capabilities, and long-lasting batteries that cater to the diverse needs of users. Elevate your mobile experience with Infinix's thoughtfully crafted smartphones, where performance meets affordability in a sleek package.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Infinix" },
                    { new Guid("40c96dfe-6df4-420b-9fb2-807cd31535bb"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("7a92b0cd-7d8d-4ee9-8a82-4f482b4c4a95"), "Dive into the world of technology with TCL smartphones, where innovation meets style. Explore a range of feature-packed devices that offer stunning displays, powerful cameras, and sleek designs. TCL smartphones deliver a seamless and immersive user experience, combining cutting-edge technology with affordability. Elevate your mobile journey with TCL's thoughtfully crafted smartphones, redefining the way you capture, connect, and communicate.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "TCL" },
                    { new Guid("462f1143-3776-42a1-9e70-7adc31fdff93"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("7a92b0cd-7d8d-4ee9-8a82-4f482b4c4a95"), "Immerse yourself in innovation and creativity with Vivo smartphones. From sleek designs to advanced camera technology, Vivo offers a diverse range of smartphones that capture the essence of modern living. Discover features like high-quality audio, vibrant displays, and powerful performance. Elevate your mobile lifestyle with Vivo's thoughtfully crafted smartphones.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Vivo" },
                    { new Guid("4848fc7f-44a6-497a-907c-ae9acb6e88ed"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("7a92b0cd-7d8d-4ee9-8a82-4f482b4c4a95"), "Discover the latest in mobile technology with Tecno smartphones. From stylish designs to innovative features, Tecno offers a diverse range of smartphones that cater to different user needs. Explore advanced camera systems, long-lasting batteries, and user-friendly interfaces. Elevate your mobile experience with Tecno's thoughtfully crafted smartphones, combining style with functionality.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Tecno" },
                    { new Guid("686bdcfd-4a8c-4a46-8f2f-5c0221e26d95"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("7a92b0cd-7d8d-4ee9-8a82-4f482b4c4a95"), "Experience the epitome of technology and innovation with Samsung's diverse product range. From flagship smartphones like the Galaxy series to smart TVs, home appliances, and cutting-edge wearables, Samsung offers a comprehensive ecosystem. Discover stunning displays, powerful performance, and advanced features that redefine the way we live and connect. Elevate your digital lifestyle with Samsung's thoughtfully designed products, bringing together quality, innovation, and versatility in every device.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Samsung" },
                    { new Guid("8c7b2f7f-6122-4770-ba40-23a0c034bcdf"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("7a92b0cd-7d8d-4ee9-8a82-4f482b4c4a95"), "Explore the world of innovation with Xiaomi's diverse range of technology products. From feature-packed smartphones and smart home devices to fitness wearables and more, Xiaomi offers a wide array of products that combine quality with affordability. Discover cutting-edge technology, sleek designs, and user-friendly interfaces that cater to various aspects of modern living. Elevate your tech experience with Xiaomi's thoughtfully crafted products, where innovation meets accessibility.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Xiaomi" },
                    { new Guid("a98d197d-5d1b-46d7-8190-90cea77a73ff"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("7a92b0cd-7d8d-4ee9-8a82-4f482b4c4a95"), "Immerse yourself in the pure Android experience with Google's smartphones. From the Pixel series, Google delivers devices known for their exceptional camera capabilities, seamless integration with Google services, and regular software updates. Explore cutting-edge technology, clean design, and the convenience of Google Assistant. Elevate your mobile journey with Google's thoughtfully crafted smartphones, where simplicity meets innovation for a pure Android experience.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Google" },
                    { new Guid("ac1807be-c7b3-483a-8a29-48da827ecd1f"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("7a92b0cd-7d8d-4ee9-8a82-4f482b4c4a95"), "Immerse yourself in innovation with Huawei's diverse range of technology products. From flagship smartphones like the P and Mate series to cutting-edge wearables, laptops, and networking solutions, Huawei offers a comprehensive ecosystem. Discover advanced camera technology, powerful performance, and sleek designs that redefine the possibilities of connected living. Elevate your digital experience with Huawei's thoughtfully designed products, where innovation, craftsmanship, and efficiency converge.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "HUAWEI" },
                    { new Guid("c0e1f0e5-cc6c-4bdf-b23e-840441c9fde2"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("7a92b0cd-7d8d-4ee9-8a82-4f482b4c4a95"), "Explore the perfect blend of style and innovation with Honor smartphones. From sleek designs to powerful features, Honor offers a range of smartphones that cater to the tech-savvy and fashion-conscious users. Discover advanced camera systems, high-performance processors, and stunning displays. Elevate your mobile lifestyle with Honor's thoughtfully crafted smartphones.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Honor" },
                    { new Guid("f5142e73-d14d-421e-8cac-3d5c9e3fdd42"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("7a92b0cd-7d8d-4ee9-8a82-4f482b4c4a95"), "Experience affordability without compromising on performance with Itel smartphones. From budget-friendly models to feature-packed devices, Itel offers a range of smartphones that cater to diverse user needs. Explore reliable performance, long-lasting batteries, and user-friendly interfaces. Elevate your mobile experience with Itel's thoughtfully crafted smartphones, delivering value and functionality.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Itel" },
                    { new Guid("f54296e5-2946-4e90-bc3c-0de027289e8d"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("7a92b0cd-7d8d-4ee9-8a82-4f482b4c4a95"), "Experience durability and rugged design with Blackview smartphones. From robust devices to outdoor-friendly models, Blackview offers a range of smartphones that withstand tough conditions. Discover features like water resistance, long-lasting batteries, and reliable performance. Elevate your mobile adventures with Blackview's thoughtfully crafted smartphones.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Blackview" },
                    { new Guid("fd235119-1ca2-40f2-956e-17b040dd0d3a"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("7a92b0cd-7d8d-4ee9-8a82-4f482b4c4a95"), "Explore cutting-edge technology and performance with ASUS smartphones. From gaming-focused devices to flagship models, ASUS offers a range of smartphones that deliver powerful features and innovative designs. Experience high-quality displays, impressive camera capabilities, and a seamless user interface. Elevate your mobile gaming and entertainment with ASUS's thoughtfully crafted smartphones.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "ASUS" },
                    { new Guid("ff7f0ed7-33f4-4067-8278-d291bc6cab0b"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("7a92b0cd-7d8d-4ee9-8a82-4f482b4c4a95"), "Dive into the realm of innovation with OPPO's exceptional lineup of smartphones. From sleek designs to cutting-edge camera technology, OPPO offers a range of devices that prioritize style and functionality. Explore the latest in mobile innovation with OPPO's commitment to delivering impressive features and powerful performance. Elevate your mobile experience with OPPO's thoughtfully crafted smartphones, blending style, innovation, and user-friendly design.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "OPPO" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("011cd970-d173-45aa-95ba-242b3442809e"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("087d5394-9fb8-46f0-beba-a6c8df2c0114"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("332253aa-aa2f-4c83-b69b-2ef5afd1395a"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("40c96dfe-6df4-420b-9fb2-807cd31535bb"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("462f1143-3776-42a1-9e70-7adc31fdff93"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("4848fc7f-44a6-497a-907c-ae9acb6e88ed"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("686bdcfd-4a8c-4a46-8f2f-5c0221e26d95"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("8c7b2f7f-6122-4770-ba40-23a0c034bcdf"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("a98d197d-5d1b-46d7-8190-90cea77a73ff"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("ac1807be-c7b3-483a-8a29-48da827ecd1f"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("c0e1f0e5-cc6c-4bdf-b23e-840441c9fde2"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("f5142e73-d14d-421e-8cac-3d5c9e3fdd42"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("f54296e5-2946-4e90-bc3c-0de027289e8d"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("fd235119-1ca2-40f2-956e-17b040dd0d3a"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("ff7f0ed7-33f4-4067-8278-d291bc6cab0b"));
        }
    }
}
