using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class Test19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("0d2689e3-cce8-4ef7-b152-a193594a0e0e"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Explore the world of innovation with Apple's cutting-edge products. From the iconic iPhone series to sleek MacBook laptops and powerful iPads, Apple offers a seamless ecosystem of devices. Discover high-quality craftsmanship, stunning displays, and user-friendly interfaces that redefine technology. Elevate your digital experience with Apple's thoughtfully designed products, ensuring a blend of style, performance, and innovation in every device.", "Apple" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("15a950de-af6e-4f43-9ad0-f25fcb42e8ab"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Discover cutting-edge technology with HP products. From powerful laptops to innovative printers, HP offers reliable solutions for both personal and professional computing needs.", "HP" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("1a97e5e2-07b6-4388-bce0-c16c99e3262a"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Elevate your gaming and computing experience with MSI. Known for high-performance laptops, motherboards, and graphics cards, MSI delivers cutting-edge technology and sleek design.", "MSI" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("592c0caf-47ac-4095-a39d-b7ffbd4ec886"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Experience innovation and reliability with Acer. From powerful laptops to sleek monitors, Acer offers a diverse range of technology solutions for work, play, and creativity.", "Acer" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("68db1da6-3858-4d97-a42b-359c0ad8e332"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Immerse yourself in innovation with Huawei's diverse range of technology products. From flagship smartphones like the P and Mate series to cutting-edge wearables, laptops, and networking solutions, Huawei offers a comprehensive ecosystem. Discover advanced camera technology, powerful performance, and sleek designs that redefine the possibilities of connected living. Elevate your digital experience with Huawei's thoughtfully designed products, where innovation, craftsmanship, and efficiency converge.", "HUAWEI" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("8505c965-4e9d-4726-bf56-9be79d7d61e3"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Empower your digital journey with Lenovo. From versatile laptops to cutting-edge PCs and smart devices, Lenovo delivers innovation, performance, and reliability for a connected world.", "Lenovo" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("ab334357-7842-4f11-82e9-91706f1cd590"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Dive into innovation with ASUS. Known for cutting-edge laptops, motherboards, and gaming peripherals, ASUS combines performance and style to enhance your digital lifestyle.", "Asus" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("c3f97827-5dca-4a53-9432-247321f407e5"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Discover the perfect blend of style and performance with Honor. From feature-packed smartphones to smartwatches, Honor delivers innovative technology for the digital-savvy lifestyle.", "Honor" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("e9e58617-65d6-4eec-9ec6-64b51559059d"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Transform your computing experience with Dell. From powerful laptops to versatile desktops and premium monitors, Dell delivers reliable technology solutions for work and play.", "Dell" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("0d2689e3-cce8-4ef7-b152-a193594a0e0e"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Transform your computing experience with Dell. From powerful laptops to versatile desktops and premium monitors, Dell delivers reliable technology solutions for work and play.", "Dell" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("15a950de-af6e-4f43-9ad0-f25fcb42e8ab"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Discover the perfect blend of style and performance with Honor. From feature-packed smartphones to smartwatches, Honor delivers innovative technology for the digital-savvy lifestyle.", "Honor" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("1a97e5e2-07b6-4388-bce0-c16c99e3262a"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Immerse yourself in innovation with Huawei's diverse range of technology products. From flagship smartphones like the P and Mate series to cutting-edge wearables, laptops, and networking solutions, Huawei offers a comprehensive ecosystem. Discover advanced camera technology, powerful performance, and sleek designs that redefine the possibilities of connected living. Elevate your digital experience with Huawei's thoughtfully designed products, where innovation, craftsmanship, and efficiency converge.", "HUAWEI" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("592c0caf-47ac-4095-a39d-b7ffbd4ec886"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Discover cutting-edge technology with HP products. From powerful laptops to innovative printers, HP offers reliable solutions for both personal and professional computing needs.", "HP" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("68db1da6-3858-4d97-a42b-359c0ad8e332"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Empower your digital journey with Lenovo. From versatile laptops to cutting-edge PCs and smart devices, Lenovo delivers innovation, performance, and reliability for a connected world.", "Lenovo" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("8505c965-4e9d-4726-bf56-9be79d7d61e3"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Dive into innovation with ASUS. Known for cutting-edge laptops, motherboards, and gaming peripherals, ASUS combines performance and style to enhance your digital lifestyle.", "Asus" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("ab334357-7842-4f11-82e9-91706f1cd590"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Experience innovation and reliability with Acer. From powerful laptops to sleek monitors, Acer offers a diverse range of technology solutions for work, play, and creativity.", "Acer" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("c3f97827-5dca-4a53-9432-247321f407e5"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Explore the world of innovation with Apple's cutting-edge products. From the iconic iPhone series to sleek MacBook laptops and powerful iPads, Apple offers a seamless ecosystem of devices. Discover high-quality craftsmanship, stunning displays, and user-friendly interfaces that redefine technology. Elevate your digital experience with Apple's thoughtfully designed products, ensuring a blend of style, performance, and innovation in every device.", "Apple" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("e9e58617-65d6-4eec-9ec6-64b51559059d"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Elevate your gaming and computing experience with MSI. Known for high-performance laptops, motherboards, and graphics cards, MSI delivers cutting-edge technology and sleek design.", "MSI" });
        }
    }
}
