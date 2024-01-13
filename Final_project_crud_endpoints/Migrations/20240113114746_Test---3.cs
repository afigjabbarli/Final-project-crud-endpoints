using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class Test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Deepcategories",
                columns: new[] { "Id", "CreatedAt", "Current_Subcategory_Id", "Description", "LastUpdatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("4fe68c8c-130d-471a-bac4-eabd7eab4ee3"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("9f2ef2e1-15a5-4c93-bbfb-15a95c50d5e8"), "Capture the perfect moments with our selection of selfie sticks. From compact and portable designs to Bluetooth-enabled options, our curated collection ensures you can snap photos and record videos with ease. Explore adjustable lengths, secure phone mounts, and convenient features for effortless selfies. Elevate your photography game with our thoughtfully chosen selfie sticks, providing a fun and versatile tool for capturing memories on your own terms.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Selfie sticks" },
                    { new Guid("5eaf8632-b8c7-45c4-b049-70bd6cf34739"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("9f2ef2e1-15a5-4c93-bbfb-15a95c50d5e8"), "Optimize energy harvesting with our collection of wires designed for efficient energy collection. From robust cables to specialized wiring solutions, our curated selection caters to various energy-harvesting systems. Explore options with high conductivity and durability, ensuring effective transfer of harvested energy. Elevate your sustainable energy initiatives with our thoughtfully chosen wires for energy collection, providing the essential connectivity for harnessing power from solar, motion, or other sources.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Wires for energy collection" },
                    { new Guid("7c5cb09e-76ef-4307-9012-fbd1db7e0a26"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("9f2ef2e1-15a5-4c93-bbfb-15a95c50d5e8"), "Safeguard your device with our collection of protective glass solutions. From tempered glass screen protectors to full coverage and anti-glare options, our curated selection offers durable and crystal-clear protection. Explore precise fits for various devices, easy installation, and advanced features such as scratch resistance and fingerprint resistance. Elevate your device's durability with our thoughtfully chosen protective glass, ensuring a clear and shielded screen for smartphones, tablets, and more.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Protective glass" },
                    { new Guid("8047875e-f8ea-429c-bef9-5813d22f3a42"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("9f2ef2e1-15a5-4c93-bbfb-15a95c50d5e8"), "Ensure seamless charging with our collection of phone adapters. From USB-C to Lightning and micro USB adapters, our curated selection offers compatibility with various devices. Explore fast-charging options, compact designs, and durable materials for reliable power delivery. Elevate your charging experience with our thoughtfully chosen phone adapters, providing the essential connectivity to keep your devices powered up efficiently and conveniently.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Phone adapters" },
                    { new Guid("81a2378e-4dd7-4f06-8ff1-8d390afcd4d0"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("9f2ef2e1-15a5-4c93-bbfb-15a95c50d5e8"), "Stay powered on the go with our range of reliable power banks. From compact and portable options to high-capacity choices, our curated selection ensures you're always charged and connected. Explore features like fast charging, multiple ports, and sleek designs. Elevate your mobile experience with our thoughtfully chosen power banks, providing a convenient and efficient way to keep your devices charged, whether you're traveling, commuting, or simply on the move.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Powerbank" },
                    { new Guid("89ff430a-a0cd-41b7-a803-c47fa04c2569"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("9f2ef2e1-15a5-4c93-bbfb-15a95c50d5e8"), "Elevate your mobile gaming experience with our smartphone gamepads. From ergonomic designs to customizable controls, our curated selection offers a seamless and immersive gaming experience on your smartphone. Explore Bluetooth-enabled options for wireless connectivity and compatibility with a variety of games. Elevate your gaming sessions with our thoughtfully chosen smartphone gamepads, providing precision control and enhanced gameplay for a wide range of mobile games.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Gamepad for smartphone" },
                    { new Guid("af939c28-8161-411c-a6fe-7193b79e1e6c"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("9f2ef2e1-15a5-4c93-bbfb-15a95c50d5e8"), "Expand your storage capacity with our range of SD cards. From standard to high-capacity options, our curated selection ensures reliable and fast storage solutions for various devices. Explore different storage capacities and read/write speeds to suit your specific needs, whether for cameras, smartphones, or other digital devices. Elevate your storage capabilities with our carefully chosen SD cards, providing the essential memory expansion for capturing, storing, and transferring your data seamlessly.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "SD cards" },
                    { new Guid("b18e82d5-c4c5-4295-b9fa-99b82101a58f"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("9f2ef2e1-15a5-4c93-bbfb-15a95c50d5e8"), "Guard your device in style with our collection of protective covers. From sleek phone cases to durable laptop sleeves, our curated selection offers a blend of fashion and functionality. Explore options that prioritize shock absorption, drop protection, and precise fit for various devices. Elevate your device's defense with our thoughtfully chosen protective covers, ensuring both style and durability for smartphones, laptops, tablets, and more.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Protective cover" },
                    { new Guid("d6211952-48af-4029-95b7-d6fc7844429c"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("9f2ef2e1-15a5-4c93-bbfb-15a95c50d5e8"), "Enhance your device's storage capacity with our selection of microSD cards. From standard to high-capacity options, our curated collection offers reliable and fast storage solutions for smartphones, cameras, and other digital devices. Explore different storage capacities and read/write speeds to suit your specific needs. Elevate your storage capabilities with our thoughtfully chosen microSD cards, providing the essential memory expansion for capturing, storing, and transferring your data seamlessly.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Micro cards" },
                    { new Guid("e9281b7d-cb0c-45da-bf83-962bcd4ba656"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("9f2ef2e1-15a5-4c93-bbfb-15a95c50d5e8"), "Step into the future of sustainable technology with our wireless energy harvesting devices. Harnessing ambient energy from the environment, these devices eliminate the need for traditional power sources. Explore innovative solutions that convert light, motion, or radio frequency signals into usable power for various applications. Elevate your approach to energy efficiency with our curated selection of wireless energy harvesting devices, contributing to a greener and more sustainable future.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Wireless energy harvesting device" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("4fe68c8c-130d-471a-bac4-eabd7eab4ee3"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("5eaf8632-b8c7-45c4-b049-70bd6cf34739"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("7c5cb09e-76ef-4307-9012-fbd1db7e0a26"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("8047875e-f8ea-429c-bef9-5813d22f3a42"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("81a2378e-4dd7-4f06-8ff1-8d390afcd4d0"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("89ff430a-a0cd-41b7-a803-c47fa04c2569"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("af939c28-8161-411c-a6fe-7193b79e1e6c"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("b18e82d5-c4c5-4295-b9fa-99b82101a58f"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("d6211952-48af-4029-95b7-d6fc7844429c"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("e9281b7d-cb0c-45da-bf83-962bcd4ba656"));
        }
    }
}
