using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class SubcategoriesofNotebooksPCstablets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "CreatedAt", "Current_Category_Id", "Description", "LastUpdatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("042a0d33-d091-4a01-b63c-e676d879d4c8"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("78a7d439-5769-4a7d-8a14-d3f589e71b1f"), "Unleash your creativity with precision using our drawing tablets. Designed for digital artists and professionals, these tablets offer an immersive drawing experience with pressure-sensitive pens and responsive surfaces. Explore a range of sizes and features to suit your artistic needs, whether you're sketching, illustrating, or editing. Elevate your digital artistry with our advanced drawing tablets, combining technology and creativity seamlessly.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Drawing tablets" },
                    { new Guid("0a273bfb-28e6-4d34-a497-6ef2e24e4b5a"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("78a7d439-5769-4a7d-8a14-d3f589e71b1f"), "Unleash productivity and creativity with our diverse range of laptops. From sleek ultrabooks to powerful gaming machines, our collection caters to every need. Experience cutting-edge technology, vibrant displays, and efficient performance in portable designs. Whether you're a professional on the go or a content creator pushing boundaries, our laptops offer a perfect blend of style, power, and versatility for the modern user.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Laptops" },
                    { new Guid("1eb107f7-8525-4ed0-af50-8e01f7731d0b"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("78a7d439-5769-4a7d-8a14-d3f589e71b1f"), "Enhance your computing setup with our diverse range of peripheral equipment. From ergonomic keyboards and precision mice to high-resolution monitors and versatile docking stations, our collection is designed to optimize your workflow. Experience comfort, efficiency, and style with peripherals that complement your unique needs. Elevate your computing experience with the latest and most innovative peripheral equipment for both work and play.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Peripheral equipment" },
                    { new Guid("1f9db05a-b5cc-4ea7-8e6d-93e12b5b8d5d"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("78a7d439-5769-4a7d-8a14-d3f589e71b1f"), "Discover the perfect blend of portability and performance with our versatile tablets. From sleek designs to vibrant displays, our collection offers a range of options to suit your digital lifestyle. Ideal for work, entertainment, or creativity on the go, our tablets feature powerful processors, stunning graphics, and intuitive interfaces. Stay connected and productive with these compact devices that redefine the way you experience digital mobility.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Tablets" },
                    { new Guid("2d61c82b-9ba7-4528-9e14-d8de745f32b3"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("78a7d439-5769-4a7d-8a14-d3f589e71b1f"), "Immerse yourself in vivid visuals and enhanced productivity with our selection of monitors. From sleek designs to high-resolution displays, our collection caters to diverse needs. Whether you're a gamer, designer, or professional, our monitors offer crisp images, fast refresh rates, and ergonomic features for a seamless viewing experience. Elevate your workspace or gaming setup with technology that brings clarity and efficiency to your screen.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Monitors" },
                    { new Guid("63ad6b9b-4b3a-4b1f-b823-276db0a0c28f"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("78a7d439-5769-4a7d-8a14-d3f589e71b1f"), "Optimize connectivity and communication with our advanced network equipment. From routers and switches to access points and modems, our collection is designed to enhance your network performance. Enjoy seamless data transfer, secure connections, and reliable internet access for both home and business environments. Explore cutting-edge technology that ensures a fast, stable, and secure network infrastructure tailored to your connectivity needs.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Network equipment" },
                    { new Guid("6f1d8a61-5b88-4e67-a11f-651b3d09a432"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("78a7d439-5769-4a7d-8a14-d3f589e71b1f"), "Experience the power of innovation with our comprehensive range of computers. From sleek desktops to versatile all-in-ones, our collection caters to diverse needs. Explore high-performance PCs designed for gaming, creative endeavors, or professional tasks. Whether you seek cutting-edge technology, powerful processing, or seamless connectivity, our computers deliver a perfect balance of performance and reliability for the modern computing experience.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Computers" },
                    { new Guid("77d68ed5-b2cb-41a3-84f0-c6d0cbfb11a0"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("78a7d439-5769-4a7d-8a14-d3f589e71b1f"), "Dive into the world of gaming with our cutting-edge video game equipment. From high-performance gaming consoles and controllers to immersive virtual reality systems, our collection caters to enthusiasts of all levels. Experience top-notch graphics, precision controls, and seamless gameplay with our advanced gaming gear. Whether you're a casual gamer or a competitive player, our equipment ensures an unparalleled and thrilling gaming experience.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Video game equipment" },
                    { new Guid("a85e1a45-741c-47b7-8dfb-df7f5e87c76b"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("78a7d439-5769-4a7d-8a14-d3f589e71b1f"), "Elevate your computing experience with our extensive range of computer accessories. From ergonomic peripherals like keyboards and mice to essential adapters, stylish laptop bags, and cutting-edge external drives – our collection enhances functionality and style. Explore accessories that complement your work or gaming setup, providing convenience and efficiency in every click. Personalize your computing space with the latest and most innovative computer accessories.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Computer accessories" },
                    { new Guid("e2f1a8b3-58e8-4962-a7b8-9e7c3ecb301c"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("78a7d439-5769-4a7d-8a14-d3f589e71b1f"), "Build and upgrade with confidence using our comprehensive selection of computer parts. Explore a wide range of components, from powerful processors and graphics cards to reliable storage solutions and high-speed memory. Whether you're customizing your gaming rig or enhancing your workstation, our collection ensures top-tier performance, compatibility, and reliability for all your computing needs.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Computer parts" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("042a0d33-d091-4a01-b63c-e676d879d4c8"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("0a273bfb-28e6-4d34-a497-6ef2e24e4b5a"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("1eb107f7-8525-4ed0-af50-8e01f7731d0b"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("1f9db05a-b5cc-4ea7-8e6d-93e12b5b8d5d"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("2d61c82b-9ba7-4528-9e14-d8de745f32b3"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("63ad6b9b-4b3a-4b1f-b823-276db0a0c28f"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("6f1d8a61-5b88-4e67-a11f-651b3d09a432"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("77d68ed5-b2cb-41a3-84f0-c6d0cbfb11a0"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("a85e1a45-741c-47b7-8dfb-df7f5e87c76b"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("e2f1a8b3-58e8-4962-a7b8-9e7c3ecb301c"));
        }
    }
}
