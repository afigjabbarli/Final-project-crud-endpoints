using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class Test18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Deepcategories",
                columns: new[] { "Id", "CreatedAt", "Current_Subcategory_Id", "Description", "LastUpdatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("0d2689e3-cce8-4ef7-b152-a193594a0e0e"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("0a273bfb-28e6-4d34-a497-6ef2e24e4b5a"), "Transform your computing experience with Dell. From powerful laptops to versatile desktops and premium monitors, Dell delivers reliable technology solutions for work and play.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Dell" },
                    { new Guid("15a950de-af6e-4f43-9ad0-f25fcb42e8ab"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("0a273bfb-28e6-4d34-a497-6ef2e24e4b5a"), "Discover the perfect blend of style and performance with Honor. From feature-packed smartphones to smartwatches, Honor delivers innovative technology for the digital-savvy lifestyle.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Honor" },
                    { new Guid("1a97e5e2-07b6-4388-bce0-c16c99e3262a"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("0a273bfb-28e6-4d34-a497-6ef2e24e4b5a"), "Immerse yourself in innovation with Huawei's diverse range of technology products. From flagship smartphones like the P and Mate series to cutting-edge wearables, laptops, and networking solutions, Huawei offers a comprehensive ecosystem. Discover advanced camera technology, powerful performance, and sleek designs that redefine the possibilities of connected living. Elevate your digital experience with Huawei's thoughtfully designed products, where innovation, craftsmanship, and efficiency converge.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "HUAWEI" },
                    { new Guid("592c0caf-47ac-4095-a39d-b7ffbd4ec886"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("0a273bfb-28e6-4d34-a497-6ef2e24e4b5a"), "Discover cutting-edge technology with HP products. From powerful laptops to innovative printers, HP offers reliable solutions for both personal and professional computing needs.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "HP" },
                    { new Guid("68db1da6-3858-4d97-a42b-359c0ad8e332"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("0a273bfb-28e6-4d34-a497-6ef2e24e4b5a"), "Empower your digital journey with Lenovo. From versatile laptops to cutting-edge PCs and smart devices, Lenovo delivers innovation, performance, and reliability for a connected world.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Lenovo" },
                    { new Guid("8505c965-4e9d-4726-bf56-9be79d7d61e3"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("0a273bfb-28e6-4d34-a497-6ef2e24e4b5a"), "Dive into innovation with ASUS. Known for cutting-edge laptops, motherboards, and gaming peripherals, ASUS combines performance and style to enhance your digital lifestyle.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Asus" },
                    { new Guid("ab334357-7842-4f11-82e9-91706f1cd590"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("0a273bfb-28e6-4d34-a497-6ef2e24e4b5a"), "Experience innovation and reliability with Acer. From powerful laptops to sleek monitors, Acer offers a diverse range of technology solutions for work, play, and creativity.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Acer" },
                    { new Guid("c3f97827-5dca-4a53-9432-247321f407e5"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("0a273bfb-28e6-4d34-a497-6ef2e24e4b5a"), "Explore the world of innovation with Apple's cutting-edge products. From the iconic iPhone series to sleek MacBook laptops and powerful iPads, Apple offers a seamless ecosystem of devices. Discover high-quality craftsmanship, stunning displays, and user-friendly interfaces that redefine technology. Elevate your digital experience with Apple's thoughtfully designed products, ensuring a blend of style, performance, and innovation in every device.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Apple" },
                    { new Guid("e9e58617-65d6-4eec-9ec6-64b51559059d"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("0a273bfb-28e6-4d34-a497-6ef2e24e4b5a"), "Elevate your gaming and computing experience with MSI. Known for high-performance laptops, motherboards, and graphics cards, MSI delivers cutting-edge technology and sleek design.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "MSI" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("0d2689e3-cce8-4ef7-b152-a193594a0e0e"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("15a950de-af6e-4f43-9ad0-f25fcb42e8ab"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("1a97e5e2-07b6-4388-bce0-c16c99e3262a"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("592c0caf-47ac-4095-a39d-b7ffbd4ec886"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("68db1da6-3858-4d97-a42b-359c0ad8e332"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("8505c965-4e9d-4726-bf56-9be79d7d61e3"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("ab334357-7842-4f11-82e9-91706f1cd590"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("c3f97827-5dca-4a53-9432-247321f407e5"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("e9e58617-65d6-4eec-9ec6-64b51559059d"));
        }
    }
}
