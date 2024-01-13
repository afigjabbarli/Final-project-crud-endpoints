using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class subcategoriesofSmartgadgetscategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "CreatedAt", "Current_Category_Id", "Description", "LastUpdatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("07ff4b23-b509-41e2-b932-37eae200181c"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("a1e01df1-f0ef-4e89-a68b-3cd32bfbc04f"), "Elevate your fitness and style with our smart bracelets. These sleek, wearable devices seamlessly integrate technology into your lifestyle. Track your health and fitness metrics, receive notifications, and stay connected on the go. Designed for comfort and performance, our smart bracelets are the perfect companions for those who prioritize both wellness and fashion in their daily lives.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Smart bracelets" },
                    { new Guid("431bbfe3-7e5d-4d90-b590-e20fb631ac3d"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("a1e01df1-f0ef-4e89-a68b-3cd32bfbc04f"), "Accessorize your style and stay punctual with our curated selection of wristwatches. From classic elegance to modern innovation, our collection offers a timepiece for every occasion. Choose from a variety of designs, materials, and features, ensuring both functionality and fashion. Embrace the art of timekeeping with our wristwatches, where precision meets personal expression.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Wristwatches" },
                    { new Guid("7587c8cc-2cc2-4eb4-8c87-48f540a759e1"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("a1e01df1-f0ef-4e89-a68b-3cd32bfbc04f"), "Embark on seamless journeys with our diverse transportation solutions. From sleek electric cars to reliable bicycles and innovative scooters, our collection is designed for modern mobility. Discover eco-friendly options and cutting-edge technologies that redefine how you move. Whether commuting or exploring, our transportation offerings prioritize efficiency, sustainability, and a connected travel experience.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Transportation" },
                    { new Guid("8d60aefa-e6cb-4b90-9e90-0de7d4d01a7b"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("a1e01df1-f0ef-4e89-a68b-3cd32bfbc04f"), "Transform your surroundings with our collection of smart equipment. From intelligent home devices to cutting-edge gadgets, these products seamlessly integrate technology into your daily life. Enjoy enhanced efficiency, connectivity, and control as our smart equipment empowers you to create a modern and intelligent living or working space. Explore the future of convenience with our innovative selection.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Smart equipment" },
                    { new Guid("aab6cbec-dc48-4d4f-a480-137c3e8605c9"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("a1e01df1-f0ef-4e89-a68b-3cd32bfbc04f"), "Empower your child with a blend of fun and safety using our children's smartwatches. These wearable gadgets offer a secure connection, allowing you to stay in touch while granting your child a sense of independence. Packed with features like GPS tracking, calling, and safety alerts, our smartwatches provide peace of mind for parents and an exciting, interactive experience for kids. Nurture their curiosity with technology that's both entertaining and secure.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Children's smart watches" },
                    { new Guid("b0f7748c-02cf-46e3-9c82-412c284240d1"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("a1e01df1-f0ef-4e89-a68b-3cd32bfbc04f"), "Dive into a world of immersive audio with our premium headphones. Offering crystal-clear sound, comfortable designs, and sleek aesthetics, our headphones elevate your listening experience. Whether you're a music enthusiast, gamer, or on-the-go professional, our range includes wireless and wired options, ensuring a perfect fit for every lifestyle. Experience the power of superior sound quality with our cutting-edge headphone collection.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Headphones" },
                    { new Guid("d4b8a5c2-c4db-4e3f-aa3f-3d389f5a1aeb"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("a1e01df1-f0ef-4e89-a68b-3cd32bfbc04f"), "Embrace the future of wearable technology with our smartwatches. Seamlessly blending style and functionality, these devices go beyond traditional timekeeping. Monitor your health, receive notifications, and stay connected with cutting-edge features. With sleek designs and intuitive interfaces, our smartwatches empower you to navigate your day effortlessly, combining fashion and innovation on your wrist.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Smart watches" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("07ff4b23-b509-41e2-b932-37eae200181c"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("431bbfe3-7e5d-4d90-b590-e20fb631ac3d"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("7587c8cc-2cc2-4eb4-8c87-48f540a759e1"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("8d60aefa-e6cb-4b90-9e90-0de7d4d01a7b"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("aab6cbec-dc48-4d4f-a480-137c3e8605c9"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("b0f7748c-02cf-46e3-9c82-412c284240d1"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("d4b8a5c2-c4db-4e3f-aa3f-3d389f5a1aeb"));
        }
    }
}
