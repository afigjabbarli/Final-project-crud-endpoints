using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class latestchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("145b564f-ec25-4fa7-b0c1-4a331270dba8"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("14d2bbd9-adc8-492b-ab08-f730414c02dc"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("3c4893d0-0e75-4f86-a559-31831113e28f"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("54a7408b-2b99-4901-9143-e737ceaf4dc1"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("57ec16bd-8630-4798-9bad-7658e767f5d4"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("8350304e-5ff7-42fd-9708-091d0d444476"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("851c3791-ab1c-4dc8-aee6-b06515acaeae"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("8cdee5c2-33f1-4eb3-bf3e-74849a096b95"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("9c98f92f-b014-46a0-9bfd-f4324fec5801"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("bfd04d75-2247-4416-b7dc-a64aec14373d"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("c2b39397-1299-44e4-b499-d513f9f41722"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("ecdafe44-a538-4cac-91c6-462e96b08649"));

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: new Guid("f9bcb956-325a-4e70-bc50-fbfb053a8af0"));

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
