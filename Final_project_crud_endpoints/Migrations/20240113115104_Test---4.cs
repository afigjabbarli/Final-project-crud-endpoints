using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class Test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("4fe68c8c-130d-471a-bac4-eabd7eab4ee3"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Safeguard your device with our collection of protective glass solutions. From tempered glass screen protectors to full coverage and anti-glare options, our curated selection offers durable and crystal-clear protection. Explore precise fits for various devices, easy installation, and advanced features such as scratch resistance and fingerprint resistance. Elevate your device's durability with our thoughtfully chosen protective glass, ensuring a clear and shielded screen for smartphones, tablets, and more.", "Protective glass" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("5eaf8632-b8c7-45c4-b049-70bd6cf34739"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Step into the future of sustainable technology with our wireless energy harvesting devices. Harnessing ambient energy from the environment, these devices eliminate the need for traditional power sources. Explore innovative solutions that convert light, motion, or radio frequency signals into usable power for various applications. Elevate your approach to energy efficiency with our curated selection of wireless energy harvesting devices, contributing to a greener and more sustainable future.", "Wireless energy harvesting device" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("7c5cb09e-76ef-4307-9012-fbd1db7e0a26"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Guard your device in style with our collection of protective covers. From sleek phone cases to durable laptop sleeves, our curated selection offers a blend of fashion and functionality. Explore options that prioritize shock absorption, drop protection, and precise fit for various devices. Elevate your device's defense with our thoughtfully chosen protective covers, ensuring both style and durability for smartphones, laptops, tablets, and more.", "Protective cover" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("8047875e-f8ea-429c-bef9-5813d22f3a42"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Optimize energy harvesting with our collection of wires designed for efficient energy collection. From robust cables to specialized wiring solutions, our curated selection caters to various energy-harvesting systems. Explore options with high conductivity and durability, ensuring effective transfer of harvested energy. Elevate your sustainable energy initiatives with our thoughtfully chosen wires for energy collection, providing the essential connectivity for harnessing power from solar, motion, or other sources.", "Wires for energy collection" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("89ff430a-a0cd-41b7-a803-c47fa04c2569"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Ensure seamless charging with our collection of phone adapters. From USB-C to Lightning and micro USB adapters, our curated selection offers compatibility with various devices. Explore fast-charging options, compact designs, and durable materials for reliable power delivery. Elevate your charging experience with our thoughtfully chosen phone adapters, providing the essential connectivity to keep your devices powered up efficiently and conveniently.", "Phone adapters" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("af939c28-8161-411c-a6fe-7193b79e1e6c"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Capture the perfect moments with our selection of selfie sticks. From compact and portable designs to Bluetooth-enabled options, our curated collection ensures you can snap photos and record videos with ease. Explore adjustable lengths, secure phone mounts, and convenient features for effortless selfies. Elevate your photography game with our thoughtfully chosen selfie sticks, providing a fun and versatile tool for capturing memories on your own terms.", "Selfie sticks" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("b18e82d5-c4c5-4295-b9fa-99b82101a58f"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Expand your storage capacity with our range of SD cards. From standard to high-capacity options, our curated selection ensures reliable and fast storage solutions for various devices. Explore different storage capacities and read/write speeds to suit your specific needs, whether for cameras, smartphones, or other digital devices. Elevate your storage capabilities with our carefully chosen SD cards, providing the essential memory expansion for capturing, storing, and transferring your data seamlessly.", "SD cards" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("e9281b7d-cb0c-45da-bf83-962bcd4ba656"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Elevate your mobile gaming experience with our smartphone gamepads. From ergonomic designs to customizable controls, our curated selection offers a seamless and immersive gaming experience on your smartphone. Explore Bluetooth-enabled options for wireless connectivity and compatibility with a variety of games. Elevate your gaming sessions with our thoughtfully chosen smartphone gamepads, providing precision control and enhanced gameplay for a wide range of mobile games.", "Gamepad for smartphone" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("4fe68c8c-130d-471a-bac4-eabd7eab4ee3"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Capture the perfect moments with our selection of selfie sticks. From compact and portable designs to Bluetooth-enabled options, our curated collection ensures you can snap photos and record videos with ease. Explore adjustable lengths, secure phone mounts, and convenient features for effortless selfies. Elevate your photography game with our thoughtfully chosen selfie sticks, providing a fun and versatile tool for capturing memories on your own terms.", "Selfie sticks" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("5eaf8632-b8c7-45c4-b049-70bd6cf34739"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Optimize energy harvesting with our collection of wires designed for efficient energy collection. From robust cables to specialized wiring solutions, our curated selection caters to various energy-harvesting systems. Explore options with high conductivity and durability, ensuring effective transfer of harvested energy. Elevate your sustainable energy initiatives with our thoughtfully chosen wires for energy collection, providing the essential connectivity for harnessing power from solar, motion, or other sources.", "Wires for energy collection" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("7c5cb09e-76ef-4307-9012-fbd1db7e0a26"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Safeguard your device with our collection of protective glass solutions. From tempered glass screen protectors to full coverage and anti-glare options, our curated selection offers durable and crystal-clear protection. Explore precise fits for various devices, easy installation, and advanced features such as scratch resistance and fingerprint resistance. Elevate your device's durability with our thoughtfully chosen protective glass, ensuring a clear and shielded screen for smartphones, tablets, and more.", "Protective glass" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("8047875e-f8ea-429c-bef9-5813d22f3a42"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Ensure seamless charging with our collection of phone adapters. From USB-C to Lightning and micro USB adapters, our curated selection offers compatibility with various devices. Explore fast-charging options, compact designs, and durable materials for reliable power delivery. Elevate your charging experience with our thoughtfully chosen phone adapters, providing the essential connectivity to keep your devices powered up efficiently and conveniently.", "Phone adapters" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("89ff430a-a0cd-41b7-a803-c47fa04c2569"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Elevate your mobile gaming experience with our smartphone gamepads. From ergonomic designs to customizable controls, our curated selection offers a seamless and immersive gaming experience on your smartphone. Explore Bluetooth-enabled options for wireless connectivity and compatibility with a variety of games. Elevate your gaming sessions with our thoughtfully chosen smartphone gamepads, providing precision control and enhanced gameplay for a wide range of mobile games.", "Gamepad for smartphone" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("af939c28-8161-411c-a6fe-7193b79e1e6c"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Expand your storage capacity with our range of SD cards. From standard to high-capacity options, our curated selection ensures reliable and fast storage solutions for various devices. Explore different storage capacities and read/write speeds to suit your specific needs, whether for cameras, smartphones, or other digital devices. Elevate your storage capabilities with our carefully chosen SD cards, providing the essential memory expansion for capturing, storing, and transferring your data seamlessly.", "SD cards" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("b18e82d5-c4c5-4295-b9fa-99b82101a58f"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Guard your device in style with our collection of protective covers. From sleek phone cases to durable laptop sleeves, our curated selection offers a blend of fashion and functionality. Explore options that prioritize shock absorption, drop protection, and precise fit for various devices. Elevate your device's defense with our thoughtfully chosen protective covers, ensuring both style and durability for smartphones, laptops, tablets, and more.", "Protective cover" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("e9281b7d-cb0c-45da-bf83-962bcd4ba656"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Step into the future of sustainable technology with our wireless energy harvesting devices. Harnessing ambient energy from the environment, these devices eliminate the need for traditional power sources. Explore innovative solutions that convert light, motion, or radio frequency signals into usable power for various applications. Elevate your approach to energy efficiency with our curated selection of wireless energy harvesting devices, contributing to a greener and more sustainable future.", "Wireless energy harvesting device" });
        }
    }
}
