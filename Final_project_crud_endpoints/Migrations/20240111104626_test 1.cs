using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subcategories_Categories_CategoryId",
                table: "Subcategories");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("10f780c2-7abc-41d1-bee5-8334d9ec55c5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("39f6fdc5-45e1-4b92-9383-8e1c1d98f7ea"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("48d9e9ed-e79e-4b13-ba90-516995feb7c8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4e3bdb6a-1631-472b-8e0f-4353e3fa2827"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("73643a09-4bf1-41a3-afd1-eb5a1c9d64f9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("77be8093-01e1-4ce5-a8af-d1ac806142d4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7ccd4698-0b6e-479a-a47d-cf13f0917e14"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("90d88eb0-ad08-434e-a474-e2d98d10ebe0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("95be74c0-4536-418e-af2f-6d5e5e0fd8ea"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9ad2cd64-2820-4e7c-892b-d853a7616185"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b92a1575-40df-4b21-b354-28b7d2369987"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f902d97c-953c-433d-a397-63516d9bdf1d"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("1ea9c1f3-e58a-46a9-a13b-a1ba54efa3cf"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("2ab2d708-7a28-4374-a8bd-ed614a784b96"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("30545496-b78d-4280-8cb0-316a6f0bb06e"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("41b2e6c8-8384-40f4-99a7-6a8189d1ca30"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("44f6625a-ee67-4104-a1e0-45f487c422fb"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("51fe3065-dd8a-4e93-b73e-53a4d103c7f5"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("80b4e790-f40f-41fa-bb21-eec6ccd827d9"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("84b1c949-c7f8-443f-8ef5-c428bee4a64a"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("932a00b8-2f86-40d4-8c41-41293c1d4d7e"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("9de721a3-70a7-4e8e-82ff-df7a8d37223e"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("b1363337-95b6-4e97-b007-5142a39d26b5"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("d21b6c6e-32cc-4181-ae9f-5b8a75f11da0"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("dde641a4-1057-49b4-be2b-5501d387b4b0"));

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Subcategories",
                newName: "Current_Category_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Subcategories_CategoryId",
                table: "Subcategories",
                newName: "IX_Subcategories_Current_Category_Id");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "Description", "LastUpdatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("3a0c847a-8ce1-4f14-916f-3e4b899d19d9"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Immerse yourself in entertainment with TV, audio, and photo solutions. Explore stunning visuals, crystal-clear sound, and capture moments with cutting-edge technology, enhancing your audio-visual experience at home.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Automotive products" },
                    { new Guid("4c0298b4-09c2-46e1-8baa-10b8395ebd94"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Discover cutting-edge smartphones and accessories for seamless connectivity. Elevate your mobile experience with the latest technology, from feature-packed smartphones to stylish and functional accessories that enhance usability and style.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Smartphones and accessories" },
                    { new Guid("5b9e0bd5-927c-4d4b-9534-9b67ef7235b2"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Upgrade your home with efficient and modern home appliances. Explore a diverse range of devices, from energy-efficient appliances to smart home solutions, making everyday tasks convenient and your living space more comfortable.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "House and garden" },
                    { new Guid("68a906fa-2d2e-4bb7-a93a-9d12305b07a3"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Immerse yourself in entertainment with TV, audio, and photo solutions. Explore stunning visuals, crystal-clear sound, and capture moments with cutting-edge technology, enhancing your audio-visual experience at home.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "TV, audio and photo" },
                    { new Guid("78a7d439-5769-4a7d-8a14-d3f589e71b1f"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Empower your digital journey with notebooks, PCs, and tablets. Find the perfect balance of performance and portability. Choose from a diverse range of computing solutions tailored to your needs.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Notebooks, PCs, tablets" },
                    { new Guid("8ff9b1e2-0630-4821-aa16-13937e509ee2"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Immerse yourself in entertainment with TV, audio, and photo solutions. Explore stunning visuals, crystal-clear sound, and capture moments with cutting-edge technology, enhancing your audio-visual experience at home.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Construction supplies" },
                    { new Guid("9214f8c7-7c65-4c6d-852c-9f6f6c232a21"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Upgrade your home with efficient and modern home appliances. Explore a diverse range of devices, from energy-efficient appliances to smart home solutions, making everyday tasks convenient and your living space more comfortable.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Home appliances" },
                    { new Guid("a1e01df1-f0ef-4e89-a68b-3cd32bfbc04f"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Explore the future with smart gadgets. Experience seamless integration of technology into daily life with innovative devices, from smart home solutions to wearables, enhancing convenience, connectivity, and efficiency.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Smart gadgets" },
                    { new Guid("b654a618-ec4f-4d7f-a90e-0c5ea3eaa0e1"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Elevate your gaming experience with cutting-edge products for gamers. Unleash the power of high-performance hardware, immersive accessories, and advanced gear designed to take your gaming to the next level.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Hobby and entertainment" },
                    { new Guid("cdb59c3a-487c-42e5-bc0e-58ad5cfb93d3"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Elevate your gaming experience with cutting-edge products for gamers. Unleash the power of high-performance hardware, immersive accessories, and advanced gear designed to take your gaming to the next level.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Products for gamers" },
                    { new Guid("d2bc155a-9de0-40ed-b3e7-1a4c0983c2e5"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Discover a world of well-being with beauty and health equipment. From advanced skincare devices to fitness technology, elevate your self-care routine with innovative products designed to promote beauty and wellness.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Beauty and health equipment" },
                    { new Guid("f6b3406c-6046-486f-8ba8-a896ac26fe90"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Transform your kitchen with modern convenience. Explore a range of innovative kitchen appliances, from efficient cookware to time-saving gadgets, enhancing your culinary experience with style and functionality.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Kitchen appliances" }
                });

            migrationBuilder.InsertData(
                table: "Color",
                columns: new[] { "Id", "Color_Code", "CreatedAt", "LastUpdatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("2ff83d6b-6c95-4f7d-9c64-60e406a057a1"), "#ffe4c4", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "bisque" },
                    { new Guid("3e20ac3a-c156-4f60-b0b4-e1f1c205e24d"), "#808080", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "gray" },
                    { new Guid("45e0cbf9-aa2a-44a4-93a1-bf4d3aa623ce"), "#ffff00", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "yellow" },
                    { new Guid("4b24804b-9a8f-4d33-9f43-8c461e4dbf11"), "#000000", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "black" },
                    { new Guid("6c1d50fc-b6eb-4d76-ba7e-81a7811ea15f"), "#ff0000", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "red" },
                    { new Guid("7a9d04e8-1a22-4aae-8232-62f5a0c28b87"), "#663399", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "rebeccapurple" },
                    { new Guid("8640c057-8997-4b16-b3dd-7c3d3c2e1a12"), "#2f4f4f", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "darkslategray" },
                    { new Guid("8a4c94f8-2437-4e89-9075-56bbcf19c0e9"), "#a52a2a", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "brown" },
                    { new Guid("9a305d7f-5c8f-4fe1-9c0d-d8a8eb4a17c3"), "#ffe4c4", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "bisque" },
                    { new Guid("9c327764-bf90-4b8b-8c38-370cb3aa2a5a"), "#ffffff", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "white" },
                    { new Guid("af15118a-95ac-487a-b103-c9a0a1918c25"), "#0000ff", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "blue" },
                    { new Guid("c80a742d-12db-4a19-a0e8-44c67f7fb21a"), "#00ced1", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "darkturquoise" },
                    { new Guid("db1ef4d9-5b95-41a3-8bfb-7f01f8a50f32"), "#008000", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "green" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Subcategories_Categories_Current_Category_Id",
                table: "Subcategories",
                column: "Current_Category_Id",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subcategories_Categories_Current_Category_Id",
                table: "Subcategories");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3a0c847a-8ce1-4f14-916f-3e4b899d19d9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c0298b4-09c2-46e1-8baa-10b8395ebd94"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5b9e0bd5-927c-4d4b-9534-9b67ef7235b2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("68a906fa-2d2e-4bb7-a93a-9d12305b07a3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("78a7d439-5769-4a7d-8a14-d3f589e71b1f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8ff9b1e2-0630-4821-aa16-13937e509ee2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9214f8c7-7c65-4c6d-852c-9f6f6c232a21"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a1e01df1-f0ef-4e89-a68b-3cd32bfbc04f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b654a618-ec4f-4d7f-a90e-0c5ea3eaa0e1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cdb59c3a-487c-42e5-bc0e-58ad5cfb93d3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d2bc155a-9de0-40ed-b3e7-1a4c0983c2e5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f6b3406c-6046-486f-8ba8-a896ac26fe90"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("2ff83d6b-6c95-4f7d-9c64-60e406a057a1"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("3e20ac3a-c156-4f60-b0b4-e1f1c205e24d"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("45e0cbf9-aa2a-44a4-93a1-bf4d3aa623ce"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("4b24804b-9a8f-4d33-9f43-8c461e4dbf11"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("6c1d50fc-b6eb-4d76-ba7e-81a7811ea15f"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("7a9d04e8-1a22-4aae-8232-62f5a0c28b87"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("8640c057-8997-4b16-b3dd-7c3d3c2e1a12"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("8a4c94f8-2437-4e89-9075-56bbcf19c0e9"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("9a305d7f-5c8f-4fe1-9c0d-d8a8eb4a17c3"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("9c327764-bf90-4b8b-8c38-370cb3aa2a5a"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("af15118a-95ac-487a-b103-c9a0a1918c25"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("c80a742d-12db-4a19-a0e8-44c67f7fb21a"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("db1ef4d9-5b95-41a3-8bfb-7f01f8a50f32"));

            migrationBuilder.RenameColumn(
                name: "Current_Category_Id",
                table: "Subcategories",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Subcategories_Current_Category_Id",
                table: "Subcategories",
                newName: "IX_Subcategories_CategoryId");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "Description", "LastUpdatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("10f780c2-7abc-41d1-bee5-8334d9ec55c5"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Upgrade your home with efficient and modern home appliances. Explore a diverse range of devices, from energy-efficient appliances to smart home solutions, making everyday tasks convenient and your living space more comfortable.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Home appliances" },
                    { new Guid("39f6fdc5-45e1-4b92-9383-8e1c1d98f7ea"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Explore the future with smart gadgets. Experience seamless integration of technology into daily life with innovative devices, from smart home solutions to wearables, enhancing convenience, connectivity, and efficiency.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Smart gadgets" },
                    { new Guid("48d9e9ed-e79e-4b13-ba90-516995feb7c8"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Elevate your gaming experience with cutting-edge products for gamers. Unleash the power of high-performance hardware, immersive accessories, and advanced gear designed to take your gaming to the next level.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Hobby and entertainment" },
                    { new Guid("4e3bdb6a-1631-472b-8e0f-4353e3fa2827"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Immerse yourself in entertainment with TV, audio, and photo solutions. Explore stunning visuals, crystal-clear sound, and capture moments with cutting-edge technology, enhancing your audio-visual experience at home.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Automotive products" },
                    { new Guid("73643a09-4bf1-41a3-afd1-eb5a1c9d64f9"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Transform your kitchen with modern convenience. Explore a range of innovative kitchen appliances, from efficient cookware to time-saving gadgets, enhancing your culinary experience with style and functionality.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Kitchen appliances" },
                    { new Guid("77be8093-01e1-4ce5-a8af-d1ac806142d4"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Elevate your gaming experience with cutting-edge products for gamers. Unleash the power of high-performance hardware, immersive accessories, and advanced gear designed to take your gaming to the next level.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Products for gamers" },
                    { new Guid("7ccd4698-0b6e-479a-a47d-cf13f0917e14"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Upgrade your home with efficient and modern home appliances. Explore a diverse range of devices, from energy-efficient appliances to smart home solutions, making everyday tasks convenient and your living space more comfortable.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "House and garden" },
                    { new Guid("90d88eb0-ad08-434e-a474-e2d98d10ebe0"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Immerse yourself in entertainment with TV, audio, and photo solutions. Explore stunning visuals, crystal-clear sound, and capture moments with cutting-edge technology, enhancing your audio-visual experience at home.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Construction supplies" },
                    { new Guid("95be74c0-4536-418e-af2f-6d5e5e0fd8ea"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Empower your digital journey with notebooks, PCs, and tablets. Find the perfect balance of performance and portability. Choose from a diverse range of computing solutions tailored to your needs.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Notebooks, PCs, tablets" },
                    { new Guid("9ad2cd64-2820-4e7c-892b-d853a7616185"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Immerse yourself in entertainment with TV, audio, and photo solutions. Explore stunning visuals, crystal-clear sound, and capture moments with cutting-edge technology, enhancing your audio-visual experience at home.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "TV, audio and photo" },
                    { new Guid("b92a1575-40df-4b21-b354-28b7d2369987"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Discover a world of well-being with beauty and health equipment. From advanced skincare devices to fitness technology, elevate your self-care routine with innovative products designed to promote beauty and wellness.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Beauty and health equipment" },
                    { new Guid("f902d97c-953c-433d-a397-63516d9bdf1d"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Discover cutting-edge smartphones and accessories for seamless connectivity. Elevate your mobile experience with the latest technology, from feature-packed smartphones to stylish and functional accessories that enhance usability and style.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Smartphones and accessories" }
                });

            migrationBuilder.InsertData(
                table: "Color",
                columns: new[] { "Id", "Color_Code", "CreatedAt", "LastUpdatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("1ea9c1f3-e58a-46a9-a13b-a1ba54efa3cf"), "#0000ff", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "blue" },
                    { new Guid("2ab2d708-7a28-4374-a8bd-ed614a784b96"), "#2f4f4f", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "darkslategray" },
                    { new Guid("30545496-b78d-4280-8cb0-316a6f0bb06e"), "#00ced1", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "darkturquoise" },
                    { new Guid("41b2e6c8-8384-40f4-99a7-6a8189d1ca30"), "#000000", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "black" },
                    { new Guid("44f6625a-ee67-4104-a1e0-45f487c422fb"), "#663399", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "rebeccapurple" },
                    { new Guid("51fe3065-dd8a-4e93-b73e-53a4d103c7f5"), "#008000", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "green" },
                    { new Guid("80b4e790-f40f-41fa-bb21-eec6ccd827d9"), "#ffe4c4", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "bisque" },
                    { new Guid("84b1c949-c7f8-443f-8ef5-c428bee4a64a"), "#ff0000", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "red" },
                    { new Guid("932a00b8-2f86-40d4-8c41-41293c1d4d7e"), "#ffffff", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "white" },
                    { new Guid("9de721a3-70a7-4e8e-82ff-df7a8d37223e"), "#808080", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "gray" },
                    { new Guid("b1363337-95b6-4e97-b007-5142a39d26b5"), "#ffe4c4", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "bisque" },
                    { new Guid("d21b6c6e-32cc-4181-ae9f-5b8a75f11da0"), "#ffff00", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "yellow" },
                    { new Guid("dde641a4-1057-49b4-be2b-5501d387b4b0"), "#a52a2a", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "brown" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Subcategories_Categories_CategoryId",
                table: "Subcategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
