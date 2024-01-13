using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class SeedinginitialvaluestoColortable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1d11d022-125b-48f8-988d-3cec3846e976"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2d7ea6fd-0ca5-41f4-98d0-4cbb5f53ee41"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2d831552-2c29-4df3-b267-3f7a3c8f5f67"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2e86b076-6aa6-4d8f-9162-167c7551041f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6944c639-0326-4ebd-b421-d22687d1d6e7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6c1f6448-3983-475a-9dca-9ba8d3dbbf79"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("96559f96-23dd-4940-a2c9-3a23c9b4193e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dc305526-f312-4dea-a421-9f3698e97380"));

            migrationBuilder.CreateTable(
                name: "Color",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Color_Code = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Color", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "Description", "LastUpdatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("00b61eb9-102f-49ef-8009-3608da1fa75c"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Upgrade your home with efficient and modern home appliances. Explore a diverse range of devices, from energy-efficient appliances to smart home solutions, making everyday tasks convenient and your living space more comfortable.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Home appliances" },
                    { new Guid("03d90fad-8942-4676-ab76-7c43b6d6055f"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Discover cutting-edge smartphones and accessories for seamless connectivity. Elevate your mobile experience with the latest technology, from feature-packed smartphones to stylish and functional accessories that enhance usability and style.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Smartphones and accessories" },
                    { new Guid("0520912f-21a0-4f9e-9a26-5c961cee1fbd"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Explore the future with smart gadgets. Experience seamless integration of technology into daily life with innovative devices, from smart home solutions to wearables, enhancing convenience, connectivity, and efficiency.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Smart gadgets" },
                    { new Guid("07e8daa5-243e-49a4-8d3d-e552848dcc5c"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Elevate your gaming experience with cutting-edge products for gamers. Unleash the power of high-performance hardware, immersive accessories, and advanced gear designed to take your gaming to the next level.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Products for gamers" },
                    { new Guid("113c3dfd-e98f-4577-8dcd-26af99dc979a"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Empower your digital journey with notebooks, PCs, and tablets. Find the perfect balance of performance and portability. Choose from a diverse range of computing solutions tailored to your needs.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Notebooks, PCs, tablets" },
                    { new Guid("c8921f52-7cb0-4027-8bd8-b6e22ecb0c0e"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Immerse yourself in entertainment with TV, audio, and photo solutions. Explore stunning visuals, crystal-clear sound, and capture moments with cutting-edge technology, enhancing your audio-visual experience at home.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "TV, audio and photo" },
                    { new Guid("d186eccf-d2de-4402-a9ce-ac1954bc7f0f"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Discover a world of well-being with beauty and health equipment. From advanced skincare devices to fitness technology, elevate your self-care routine with innovative products designed to promote beauty and wellness.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Beauty and health equipment" },
                    { new Guid("faae05c6-d8a2-48f3-8a98-8853734e7f8f"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Transform your kitchen with modern convenience. Explore a range of innovative kitchen appliances, from efficient cookware to time-saving gadgets, enhancing your culinary experience with style and functionality.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Kitchen appliances" }
                });

            migrationBuilder.InsertData(
                table: "Color",
                columns: new[] { "Id", "Color_Code", "CreatedAt", "LastUpdatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("145b564f-ec25-4fa7-b0c1-4a331270dba8"), "#ffe4c4", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "bisque" },
                    { new Guid("14d2bbd9-adc8-492b-ab08-f730414c02dc"), "#00ced1", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "darkturquoise" },
                    { new Guid("3c4893d0-0e75-4f86-a559-31831113e28f"), "#a52a2a", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "brown" },
                    { new Guid("54a7408b-2b99-4901-9143-e737ceaf4dc1"), "#ffe4c4", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "bisque" },
                    { new Guid("57ec16bd-8630-4798-9bad-7658e767f5d4"), "#ff0000", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "red" },
                    { new Guid("8350304e-5ff7-42fd-9708-091d0d444476"), "#0000ff", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "blue" },
                    { new Guid("851c3791-ab1c-4dc8-aee6-b06515acaeae"), "#ffff00", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "yellow" },
                    { new Guid("8cdee5c2-33f1-4eb3-bf3e-74849a096b95"), "#008000", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "green" },
                    { new Guid("9c98f92f-b014-46a0-9bfd-f4324fec5801"), "#663399", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "rebeccapurple" },
                    { new Guid("bfd04d75-2247-4416-b7dc-a64aec14373d"), "#2f4f4f", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "darkslategray" },
                    { new Guid("c2b39397-1299-44e4-b499-d513f9f41722"), "#808080", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "gray" },
                    { new Guid("ecdafe44-a538-4cac-91c6-462e96b08649"), "#000000", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "black" },
                    { new Guid("f9bcb956-325a-4e70-bc50-fbfb053a8af0"), "#ffffff", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "white" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Color");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("00b61eb9-102f-49ef-8009-3608da1fa75c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("03d90fad-8942-4676-ab76-7c43b6d6055f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0520912f-21a0-4f9e-9a26-5c961cee1fbd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("07e8daa5-243e-49a4-8d3d-e552848dcc5c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("113c3dfd-e98f-4577-8dcd-26af99dc979a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c8921f52-7cb0-4027-8bd8-b6e22ecb0c0e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d186eccf-d2de-4402-a9ce-ac1954bc7f0f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("faae05c6-d8a2-48f3-8a98-8853734e7f8f"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "Description", "LastUpdatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("1d11d022-125b-48f8-988d-3cec3846e976"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Discover cutting-edge smartphones and accessories for seamless connectivity. Elevate your mobile experience with the latest technology, from feature-packed smartphones to stylish and functional accessories that enhance usability and style.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Smartphones and accessories" },
                    { new Guid("2d7ea6fd-0ca5-41f4-98d0-4cbb5f53ee41"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Immerse yourself in entertainment with TV, audio, and photo solutions. Explore stunning visuals, crystal-clear sound, and capture moments with cutting-edge technology, enhancing your audio-visual experience at home.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "TV, audio and photo" },
                    { new Guid("2d831552-2c29-4df3-b267-3f7a3c8f5f67"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Elevate your gaming experience with cutting-edge products for gamers. Unleash the power of high-performance hardware, immersive accessories, and advanced gear designed to take your gaming to the next level.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Products for gamers" },
                    { new Guid("2e86b076-6aa6-4d8f-9162-167c7551041f"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Explore the future with smart gadgets. Experience seamless integration of technology into daily life with innovative devices, from smart home solutions to wearables, enhancing convenience, connectivity, and efficiency.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Smart gadgets" },
                    { new Guid("6944c639-0326-4ebd-b421-d22687d1d6e7"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Upgrade your home with efficient and modern home appliances. Explore a diverse range of devices, from energy-efficient appliances to smart home solutions, making everyday tasks convenient and your living space more comfortable.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Home appliances" },
                    { new Guid("6c1f6448-3983-475a-9dca-9ba8d3dbbf79"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Discover a world of well-being with beauty and health equipment. From advanced skincare devices to fitness technology, elevate your self-care routine with innovative products designed to promote beauty and wellness.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Beauty and health equipment" },
                    { new Guid("96559f96-23dd-4940-a2c9-3a23c9b4193e"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Empower your digital journey with notebooks, PCs, and tablets. Find the perfect balance of performance and portability. Choose from a diverse range of computing solutions tailored to your needs.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Notebooks, PCs, tablets" },
                    { new Guid("dc305526-f312-4dea-a421-9f3698e97380"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Transform your kitchen with modern convenience. Explore a range of innovative kitchen appliances, from efficient cookware to time-saving gadgets, enhancing your culinary experience with style and functionality.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Kitchen appliances" }
                });
        }
    }
}
