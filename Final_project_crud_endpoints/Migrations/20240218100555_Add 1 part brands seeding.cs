using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class Add1partbrandsseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("38110fb3-0ee0-4d2a-8a6b-9149f816d7f0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("593ed06c-0e43-4e6a-8b9c-8484656d636d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("65e30d8f-02cd-4e50-aead-49e98bf1c29d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a04a27c5-bffc-42de-a9b1-bf2751f99022"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b963251f-d17a-4e47-8382-b53ab275e2a8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d4bf6e7d-06f6-44b8-aa2f-06386b18baf0"));

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Brand_Code", "CreatedAt", "Description", "LastUpdatedAt", "Location", "Name", "Phisical_Logo_Name", "Since" },
                values: new object[,]
                {
                    { new Guid("174a35aa-842a-4c36-a87c-873592f30b7f"), "", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "HUAWEI is a Chinese multinational technology company headquartered in Shenzhen, Guangdong, China. It designs, develops, and sells telecommunications equipment, consumer electronics, and smartphones.", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Shenzhen, Guangdong, China", "HUAWEI", "", new DateTime(1987, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("1e47e670-0628-4de9-9611-ab1231d33fc2"), "", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "OPPO is a Chinese consumer electronics and mobile communications company", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Dongguan, Guangdong, China", "OPPO", "", new DateTime(2001, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("39561cb1-4970-46b6-a20e-7d9007e21b1e"), "", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Honor is a smartphone brand owned by Huawei Technologies Co., Ltd.", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Shenzhen, Guangdong, China", "Honor", "", new DateTime(2013, 12, 16, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4836ab7d-98ba-4076-bcec-d63ec704acf9"), "", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Google is an American multinational technology company that specializes in Internet-related services and products.", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Mountain View, California, United States", "Google", "", new DateTime(1998, 9, 4, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("49f291ab-3817-401b-958c-032626fd611f"), "", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Apple Inc. is an American multinational technology company", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Cupertino, California, United States", "Apple", "", new DateTime(1976, 4, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("799e6cef-0b58-4e78-aef9-036b2d63d23f"), "", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "ASUS is a multinational computer and phone hardware and electronics company headquartered in Beitou District, Taipei, Taiwan.", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Beitou District, Taipei, Taiwan", "ASUS", "", new DateTime(1989, 4, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c9372f89-7541-4c63-a484-85385288f152"), "", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Samsung is a South Korean multinational conglomerate", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Seoul, South Korea", "Samsung", "", new DateTime(1938, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dfe7933d-6502-474d-8f13-d0e3703a2800"), "", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Motorola, Inc. was an American multinational telecommunications company founded on September 25, 1928, based in Schaumburg, Illinois. After having lost $4.3 billion from 2007 to 2009, the company demerged into two independent public companies, Motorola Mobility and Motorola Solutions on January 4, 2011.", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Chicago, Illinois, United States", "Motorola", "", new DateTime(1928, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f3bd0853-9079-491a-8b25-e41d40d3e922"), "", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Xiaomi Corporation is a Chinese multinational electronics company", new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Beijing, China", "Xiaomi", "", new DateTime(2010, 4, 6, 0, 0, 0, 0, DateTimeKind.Utc) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("174a35aa-842a-4c36-a87c-873592f30b7f"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("1e47e670-0628-4de9-9611-ab1231d33fc2"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("39561cb1-4970-46b6-a20e-7d9007e21b1e"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("4836ab7d-98ba-4076-bcec-d63ec704acf9"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("49f291ab-3817-401b-958c-032626fd611f"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("799e6cef-0b58-4e78-aef9-036b2d63d23f"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("c9372f89-7541-4c63-a484-85385288f152"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("dfe7933d-6502-474d-8f13-d0e3703a2800"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("f3bd0853-9079-491a-8b25-e41d40d3e922"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Current_Brand_Id", "Current_Deepcategory_Id", "Current_Quality_Level_Id", "Description", "Discount", "IsAvailable", "IsOffer", "LastUpdatedAt", "ManufacturedAt", "Name", "Price", "Product_Code", "Quantity" },
                values: new object[,]
                {
                    { new Guid("38110fb3-0ee0-4d2a-8a6b-9149f816d7f0"), new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("67e43826-095f-42ba-9f18-6a65316fa950"), new Guid("ff7f0ed7-33f4-4067-8278-d291bc6cab0b"), new Guid("1ff5f48a-c831-4dff-9509-5b44fd5df76f"), "Introducing the iPhone 13 Pro Max 1TB Alpine Green, the pinnacle of Apple's smartphone technology. With its expansive 1TB storage capacity, you'll never have to worry about running out of space for your photos, videos, and apps. The stunning Alpine Green finish adds a touch of luxury to its sleek and elegant design. Featuring the powerful A15 Bionic chip, it delivers blazing-fast performance and unmatched efficiency. The Pro Max's advanced camera system captures breathtaking photos and videos in any lighting condition. With 5G connectivity, you can download and stream content at lightning speed. And with all-day battery life and iOS 15, it's designed to keep up with your busy lifestyle.", 10, true, true, new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Utc), "iPhone 13 Pro Max 1TB Alpine Green", 1699m, "", 150m },
                    { new Guid("593ed06c-0e43-4e6a-8b9c-8484656d636d"), new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("5244689f-5409-4be0-8932-dc8e5548c3cd"), new Guid("fd235119-1ca2-40f2-956e-17b040dd0d3a"), new Guid("2b15840b-5559-40b1-b234-f5bdd36bcc58"), "Explore the future of smartphone design with the OPPO Find N3 Flip 12/256 GB Gold. This innovative device features a unique flip design that combines style and functionality. The luxurious gold finish adds a touch of sophistication to its sleek exterior. With 12 GB of RAM and 256 GB of internal storage, it delivers powerful performance and ample space for your apps and files. Its flexible display can be flipped open to reveal a larger screen for immersive multimedia experiences. Capture stunning photos and videos with the high-resolution camera system, and enjoy crystal-clear video calls with the front-facing camera. And with its long-lasting battery life and advanced features, it's the perfect companion for your on-the-go lifestyle.", 0, true, false, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Utc), "OPPO Find N3 Flip 12/256 GB Gold", 1499m, "", 75m },
                    { new Guid("65e30d8f-02cd-4e50-aead-49e98bf1c29d"), new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("5244689f-5409-4be0-8932-dc8e5548c3cd"), new Guid("fd235119-1ca2-40f2-956e-17b040dd0d3a"), new Guid("2b15840b-5559-40b1-b234-f5bdd36bcc58"), "Experience luxury and innovation with the OPPO Find N3 16/512 GB Gold. With its exquisite design and cutting-edge features, it redefines what a smartphone can be. The stunning gold finish adds a touch of elegance to its sleek and modern design. Featuring 16 GB of RAM and 512 GB of internal storage, it offers blazing-fast performance and ample space for all your files and apps. Its immersive display delivers vibrant colors and sharp details, making every visual experience unforgettable. Capture stunning photos and videos with the high-resolution camera system, and take crystal-clear selfies with the front-facing camera. And with its long-lasting battery life and advanced features, it's designed to keep up with your busy lifestyle.", 0, true, false, new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Utc), "OPPO Find N3 16/512 GB Gold", 1299m, "", 50m },
                    { new Guid("a04a27c5-bffc-42de-a9b1-bf2751f99022"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("67e43826-095f-42ba-9f18-6a65316fa950"), new Guid("ff7f0ed7-33f4-4067-8278-d291bc6cab0b"), new Guid("1ff5f48a-c831-4dff-9509-5b44fd5df76f"), "The iPhone 15 Pro 512 GB Blue is a cutting-edge smartphone packed with powerful features. With its advanced A-series processor, it delivers smooth performance for gaming, multitasking, and demanding apps. The 512 GB storage capacity provides ample space for your photos, videos, and files. Its vibrant blue color adds a touch of elegance to its modern design. The high-resolution display showcases your content with vivid clarity. Equipped with an advanced camera system, it captures stunning photos and videos. The iPhone 15 Pro is also water and dust resistant, making it ideal for daily use. With state-of-the-art security features and long battery life, it meets the needs of those seeking performance, beauty, and functionality.", 25, true, true, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "iPhone 15 Pro 512 GB Blue", 3599m, "", 100m },
                    { new Guid("b963251f-d17a-4e47-8382-b53ab275e2a8"), new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("5244689f-5409-4be0-8932-dc8e5548c3cd"), new Guid("fd235119-1ca2-40f2-956e-17b040dd0d3a"), new Guid("2b15840b-5559-40b1-b234-f5bdd36bcc58"), "Discover the perfect balance of style and performance with the OPPO A58 8/128 GB Black. Featuring a sleek and modern design, it's sure to turn heads wherever you go. With its powerful octa-core processor and 8 GB of RAM, it delivers smooth multitasking and responsive performance. The generous 128 GB of internal storage provides ample space for all your apps, photos, and videos. Its vibrant display brings your content to life with vivid colors and sharp details. Capture every moment with the high-resolution rear camera, and take stunning selfies with the front-facing camera. And with its long-lasting battery life, you can stay connected all day long without interruption.", 0, true, false, new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Utc), "OPPO A58 8/128 GB Black", 299m, "", 100m },
                    { new Guid("d4bf6e7d-06f6-44b8-aa2f-06386b18baf0"), new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("67e43826-095f-42ba-9f18-6a65316fa950"), new Guid("ff7f0ed7-33f4-4067-8278-d291bc6cab0b"), new Guid("1ff5f48a-c831-4dff-9509-5b44fd5df76f"), "Experience the future of smartphones with the iPhone 14 Pro 512 GB Silver. Boasting a sleek and elegant design, the Silver variant adds a touch of sophistication to your everyday life. With its powerful A16 chip, it delivers lightning-fast performance and unrivaled efficiency. The expansive 512 GB storage capacity ensures you have ample space for all your photos, videos, and apps. Its advanced camera system captures stunning images and videos with remarkable clarity and detail. Featuring 5G connectivity, you can download, stream, and share content at incredible speeds. And with its long-lasting battery life and iOS 16, it's designed to keep up with your busy lifestyle.", 15, true, true, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), "iPhone 14 Pro 512 GB Silver", 1899m, "", 200m }
                });
        }
    }
}
