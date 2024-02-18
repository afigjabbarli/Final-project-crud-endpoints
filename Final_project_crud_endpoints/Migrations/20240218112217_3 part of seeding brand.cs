using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class _3partofseedingbrand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Brand_Code", "CreatedAt", "Description", "LastUpdatedAt", "Location", "Name", "Phisical_Logo_Name", "Since" },
                values: new object[,]
                {
                    { new Guid("14d4f153-90f6-4fd8-a3a2-d07121be1501"), "", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Canon Inc. is a Japanese multinational corporation specializing in the manufacture of imaging and optical products, including cameras, camcorders, photocopiers, steppers, computer printers, and medical equipment.", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Tokyo, Japan", "Canon", "", new DateTime(1937, 8, 10, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("401c2a61-395b-4eaa-9857-1c6923ee50eb"), "", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Leica Camera AG is a German company that manufactures cameras, lenses, binoculars, rifle scopes, microscopes, and ophthalmic lenses. The company was founded by Ernst Leitz in 1914.", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Wetzlar, Germany", "Leica", "", new DateTime(1914, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("542de3c2-2a08-45dc-808c-8e6a15feac89"), "", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "HP Inc. is an American multinational information technology company that develops personal computers, printers, and related supplies.", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Palo Alto, California, United States", "HP", "", new DateTime(1939, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("57bf27de-49f3-484e-b8be-deba5cf6ed27"), "", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "MSI (Micro-Star International Co., Ltd) is a Taiwanese multinational information technology corporation headquartered in New Taipei City, Taiwan.", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "New Taipei City, Taiwan", "MSI", "", new DateTime(1986, 8, 4, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("57ef2517-6d90-47af-8127-50bb0e0e6068"), "", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Dell Technologies Inc. is an American multinational technology company headquartered in Round Rock, Texas. It designs, develops, manufactures, markets, and sells computer hardware, software, and related services.", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Round Rock, Texas, United States", "Dell", "", new DateTime(1984, 2, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7096389a-10f7-4b4c-936b-c97c3e871535"), "", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Acer Inc. is a Taiwanese multinational hardware and electronics corporation specializing in advanced electronics technology.", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "New Taipei City, Taiwan", "Acer", "", new DateTime(1976, 8, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7c06af60-6e98-4ed7-82aa-fc5b1ca8a0dd"), "", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Toshiba Corporation is a Japanese multinational conglomerate headquartered in Minato, Tokyo, Japan. Its diversified products and services include information technology and communications equipment and systems, electronic components and materials, power systems, industrial and social infrastructure systems, consumer electronics, household appliances, medical equipment, office equipment, as well as lighting and logistics.", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Minato, Tokyo, Japan", "Toshiba", "", new DateTime(1938, 7, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a14cfa60-37d3-42c3-b717-3517d756461e"), "", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Beko is a Turkish domestic appliance and consumer electronics brand of Arcelik AS, controlled by Koc Holding, which started operating in 1955.", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Istanbul, Turkey", "Beko", "", new DateTime(1955, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c0a2690f-bb81-46d6-b758-aa113e77e798"), "", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Lenovo Group Limited is a Chinese multinational technology company headquartered in Beijing. It designs, develops, manufactures, and sells personal computers, tablet computers, smartphones, workstations, servers, electronic storage devices, IT management software, and smart televisions.", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Beijing, China", "Lenovo", "", new DateTime(1984, 11, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c0f66be8-096c-43f9-9523-0291d328ab13"), "", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Nikon Corporation, also known just as Nikon, is a Japanese multinational corporation headquartered in Tokyo, Japan, specializing in optics and imaging products.", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Tokyo, Japan", "Nikon", "", new DateTime(1917, 7, 25, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e550d6c6-e22f-48e7-b9fc-4732b69982ec"), "", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "LG Corporation, formerly Lucky-Goldstar, is a South Korean multinational conglomerate corporation. It is the fourth-largest chaebol in South Korea.", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Seoul, South Korea", "LG", "", new DateTime(1947, 1, 5, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("feda98d0-2c07-440d-aaaa-ff00983e9125"), "", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Microsoft Corporation is an American multinational technology corporation which produces computer software, consumer electronics, personal computers, and related services.", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Redmond, Washington, United States", "Microsoft", "", new DateTime(1975, 4, 4, 0, 0, 0, 0, DateTimeKind.Utc) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("14d4f153-90f6-4fd8-a3a2-d07121be1501"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("401c2a61-395b-4eaa-9857-1c6923ee50eb"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("542de3c2-2a08-45dc-808c-8e6a15feac89"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("57bf27de-49f3-484e-b8be-deba5cf6ed27"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("57ef2517-6d90-47af-8127-50bb0e0e6068"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("7096389a-10f7-4b4c-936b-c97c3e871535"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("7c06af60-6e98-4ed7-82aa-fc5b1ca8a0dd"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("a14cfa60-37d3-42c3-b717-3517d756461e"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("c0a2690f-bb81-46d6-b758-aa113e77e798"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("c0f66be8-096c-43f9-9523-0291d328ab13"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("e550d6c6-e22f-48e7-b9fc-4732b69982ec"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("feda98d0-2c07-440d-aaaa-ff00983e9125"));
        }
    }
}
