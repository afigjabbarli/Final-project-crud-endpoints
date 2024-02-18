using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class _2partofbrandseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Brand_Code", "CreatedAt", "Description", "LastUpdatedAt", "Location", "Name", "Phisical_Logo_Name", "Since" },
                values: new object[,]
                {
                    { new Guid("09e8be79-96f0-4c9d-a080-24e1e99e22a1"), "", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Urbanista is a Swedish brand that offers a wide range of headphones and earphones designed for urban living.", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Stockholm, Sweden", "Urbanista", "", new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("49c11372-bc3f-4c6c-947f-4b2b4e0062c6"), "", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Beats by Dre is a subsidiary of Apple Inc. that produces audio products. The company was founded by music producer Dr. Dre and record company executive Jimmy Iovine.", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Culver City, California, United States", "Beats", "", new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4c7de52b-cbb6-481e-870b-6f0ce45792c1"), "", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "BANG & OLUFSEN is a Danish company that designs and manufactures audio products, television sets, and telephones.", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Struer, Denmark", "BANG & OLUFSEN", "", new DateTime(1925, 10, 17, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("52894712-8b19-400a-9831-d7695785d1b8"), "", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Sony Corporation is a Japanese multinational conglomerate corporation headquartered in Kōnan, Minato, Tokyo.", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Tokyo, Japan", "Sony", "", new DateTime(1946, 5, 7, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5bf60494-87be-405d-bb0e-08399df0ac81"), "", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "AIWA Corporation is a consumer electronics company that primarily specializes in audio equipment.", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Tokyo, Japan", "AIWA", "", new DateTime(1951, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9065f70b-5c76-499c-aca9-07334773ed28"), "", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Gelius is a brand that offers a variety of electronic accessories and gadgets.", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Unknown", "Gelius", "", new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("960df5d6-b7d5-455f-b7dc-21b0d5409250"), "", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "JBL is an American company that manufactures loudspeakers and other audio equipment.", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Los Angeles, California, United States", "JBL", "", new DateTime(1946, 10, 27, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("986026a7-9dc0-4e9f-b874-974cafc01f02"), "", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Logitech International S.A. is a Swiss-American manufacturer of computer peripherals and software, with headquarters in Lausanne, Switzerland and Newark, California.", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Lausanne, Switzerland and Newark, California", "Logitech", "", new DateTime(1981, 10, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9ca42a34-34b6-4f3e-85f7-43898f4c9634"), "", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Koninklijke Philips N.V. is a Dutch multinational conglomerate corporation that was founded in Eindhoven. Since 1997, it has been mostly headquartered in Amsterdam, though the Benelux headquarters is still in Eindhoven.", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Amsterdam, Netherlands", "Philips", "", new DateTime(1891, 5, 15, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a6bfd0b3-7219-47e4-b1d3-d86b9270ec4f"), "", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "TRUST is a Dutch computer hardware and software company, which sells a wide range of products that includes computer peripherals such as keyboards, mice, USB hubs, speakers, webcams, and networking products such as routers and switches.", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Dordrecht, Netherlands", "TRUST", "", new DateTime(1983, 5, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cfb3e5a2-29ad-4622-958d-29b358a3a182"), "", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Panasonic Corporation is a Japanese multinational electronics corporation headquartered in Kadoma, Osaka, Japan.", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Kadoma, Osaka, Japan", "Panasonic", "", new DateTime(1918, 3, 13, 0, 0, 0, 0, DateTimeKind.Utc) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("09e8be79-96f0-4c9d-a080-24e1e99e22a1"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("49c11372-bc3f-4c6c-947f-4b2b4e0062c6"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("4c7de52b-cbb6-481e-870b-6f0ce45792c1"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("52894712-8b19-400a-9831-d7695785d1b8"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("5bf60494-87be-405d-bb0e-08399df0ac81"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("9065f70b-5c76-499c-aca9-07334773ed28"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("960df5d6-b7d5-455f-b7dc-21b0d5409250"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("986026a7-9dc0-4e9f-b874-974cafc01f02"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("9ca42a34-34b6-4f3e-85f7-43898f4c9634"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("a6bfd0b3-7219-47e4-b1d3-d86b9270ec4f"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("cfb3e5a2-29ad-4622-958d-29b358a3a182"));
        }
    }
}
