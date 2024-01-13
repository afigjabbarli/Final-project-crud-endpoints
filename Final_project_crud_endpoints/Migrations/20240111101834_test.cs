using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subcategories_Categories_CurrentCategoryId",
                table: "Subcategories");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1461fc5f-46f5-42d8-8e50-962297f85772"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("158ffdf0-9af6-476c-8f25-45a29886703b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("19bf52fc-2fa4-4944-a9ab-ccfc70d1f486"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("32a488a4-d88c-488f-a1f3-8f27dfdd3e6d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("39c12978-e6b2-4470-a1e7-736ac74e7767"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("43d6a5dc-2ff9-4ff2-bd8b-e8e1651fd86e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4d209225-2a50-4d15-9ec2-23877ae3deb2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4de817e5-728f-4a81-8ceb-1956b7b21c23"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9a7c6a18-53ea-4461-aeac-a881298da985"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c1638140-814b-43de-aed3-8b3b00c1ab8e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e4606ae9-4c1e-4b26-b9c2-9328cf07edcd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fd32eb04-5eab-496f-8101-50871336172a"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("1dcf5e26-86d5-4071-8d56-75e2544de4ee"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("2c887422-582e-43f2-90db-547b3a268116"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("32dff4b9-0d0b-4395-b929-1d8791463d7c"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("3c2ccb9d-1342-4824-965c-f52fb6637113"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("3e2f5718-007a-4301-bfe9-211d58cdda19"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("597695df-82b6-46f1-9e71-1cdd6d0341ba"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("6e6ed80a-b0c2-474f-a65b-01ebe57f5d65"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("74423ff2-c71a-4358-86f8-954f2a5ee99b"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("92c6cbab-366e-4df4-9f09-48aa7725ef20"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("95795514-3200-44b5-a1a3-8a4dbc15ceb6"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("973a298b-b70e-4132-9784-2659d7bbdc0a"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("c0f96038-3f49-4979-aefe-d17ad3fa68ba"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("c46399f0-db2b-4c3f-99be-a5ddd0d643b8"));

            migrationBuilder.RenameColumn(
                name: "CurrentCategoryId",
                table: "Subcategories",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Subcategories_CurrentCategoryId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                newName: "CurrentCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Subcategories_CategoryId",
                table: "Subcategories",
                newName: "IX_Subcategories_CurrentCategoryId");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "Description", "LastUpdatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("1461fc5f-46f5-42d8-8e50-962297f85772"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Elevate your gaming experience with cutting-edge products for gamers. Unleash the power of high-performance hardware, immersive accessories, and advanced gear designed to take your gaming to the next level.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Hobby and entertainment" },
                    { new Guid("158ffdf0-9af6-476c-8f25-45a29886703b"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Immerse yourself in entertainment with TV, audio, and photo solutions. Explore stunning visuals, crystal-clear sound, and capture moments with cutting-edge technology, enhancing your audio-visual experience at home.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Automotive products" },
                    { new Guid("19bf52fc-2fa4-4944-a9ab-ccfc70d1f486"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Discover a world of well-being with beauty and health equipment. From advanced skincare devices to fitness technology, elevate your self-care routine with innovative products designed to promote beauty and wellness.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Beauty and health equipment" },
                    { new Guid("32a488a4-d88c-488f-a1f3-8f27dfdd3e6d"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Immerse yourself in entertainment with TV, audio, and photo solutions. Explore stunning visuals, crystal-clear sound, and capture moments with cutting-edge technology, enhancing your audio-visual experience at home.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Construction supplies" },
                    { new Guid("39c12978-e6b2-4470-a1e7-736ac74e7767"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Upgrade your home with efficient and modern home appliances. Explore a diverse range of devices, from energy-efficient appliances to smart home solutions, making everyday tasks convenient and your living space more comfortable.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Home appliances" },
                    { new Guid("43d6a5dc-2ff9-4ff2-bd8b-e8e1651fd86e"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Upgrade your home with efficient and modern home appliances. Explore a diverse range of devices, from energy-efficient appliances to smart home solutions, making everyday tasks convenient and your living space more comfortable.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "House and garden" },
                    { new Guid("4d209225-2a50-4d15-9ec2-23877ae3deb2"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Empower your digital journey with notebooks, PCs, and tablets. Find the perfect balance of performance and portability. Choose from a diverse range of computing solutions tailored to your needs.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Notebooks, PCs, tablets" },
                    { new Guid("4de817e5-728f-4a81-8ceb-1956b7b21c23"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Elevate your gaming experience with cutting-edge products for gamers. Unleash the power of high-performance hardware, immersive accessories, and advanced gear designed to take your gaming to the next level.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Products for gamers" },
                    { new Guid("9a7c6a18-53ea-4461-aeac-a881298da985"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Transform your kitchen with modern convenience. Explore a range of innovative kitchen appliances, from efficient cookware to time-saving gadgets, enhancing your culinary experience with style and functionality.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Kitchen appliances" },
                    { new Guid("c1638140-814b-43de-aed3-8b3b00c1ab8e"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Explore the future with smart gadgets. Experience seamless integration of technology into daily life with innovative devices, from smart home solutions to wearables, enhancing convenience, connectivity, and efficiency.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Smart gadgets" },
                    { new Guid("e4606ae9-4c1e-4b26-b9c2-9328cf07edcd"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Discover cutting-edge smartphones and accessories for seamless connectivity. Elevate your mobile experience with the latest technology, from feature-packed smartphones to stylish and functional accessories that enhance usability and style.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Smartphones and accessories" },
                    { new Guid("fd32eb04-5eab-496f-8101-50871336172a"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Immerse yourself in entertainment with TV, audio, and photo solutions. Explore stunning visuals, crystal-clear sound, and capture moments with cutting-edge technology, enhancing your audio-visual experience at home.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "TV, audio and photo" }
                });

            migrationBuilder.InsertData(
                table: "Color",
                columns: new[] { "Id", "Color_Code", "CreatedAt", "LastUpdatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("1dcf5e26-86d5-4071-8d56-75e2544de4ee"), "#ffe4c4", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "bisque" },
                    { new Guid("2c887422-582e-43f2-90db-547b3a268116"), "#ffe4c4", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "bisque" },
                    { new Guid("32dff4b9-0d0b-4395-b929-1d8791463d7c"), "#000000", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "black" },
                    { new Guid("3c2ccb9d-1342-4824-965c-f52fb6637113"), "#0000ff", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "blue" },
                    { new Guid("3e2f5718-007a-4301-bfe9-211d58cdda19"), "#ffffff", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "white" },
                    { new Guid("597695df-82b6-46f1-9e71-1cdd6d0341ba"), "#ff0000", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "red" },
                    { new Guid("6e6ed80a-b0c2-474f-a65b-01ebe57f5d65"), "#008000", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "green" },
                    { new Guid("74423ff2-c71a-4358-86f8-954f2a5ee99b"), "#663399", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "rebeccapurple" },
                    { new Guid("92c6cbab-366e-4df4-9f09-48aa7725ef20"), "#808080", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "gray" },
                    { new Guid("95795514-3200-44b5-a1a3-8a4dbc15ceb6"), "#a52a2a", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "brown" },
                    { new Guid("973a298b-b70e-4132-9784-2659d7bbdc0a"), "#2f4f4f", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "darkslategray" },
                    { new Guid("c0f96038-3f49-4979-aefe-d17ad3fa68ba"), "#00ced1", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "darkturquoise" },
                    { new Guid("c46399f0-db2b-4c3f-99be-a5ddd0d643b8"), "#ffff00", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "yellow" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Subcategories_Categories_CurrentCategoryId",
                table: "Subcategories",
                column: "CurrentCategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
