using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class seedingvaluessubcategoryofSmartphonesandaccessories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "CreatedAt", "Current_Category_Id", "Description", "LastUpdatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("23f8c33a-16fc-4eaa-9c3e-b97e130dce9d"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("4c0298b4-09c2-46e1-8baa-10b8395ebd94"), "Experience simplicity and reliability with our push-button phones. Effortlessly dial numbers with user-friendly keypads, ensuring quick and convenient communication. These phones combine classic design with modern functionality, providing a straightforward and dependable means of staying connected in the digital age.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Push-button phones" },
                    { new Guid("59053d5f-cd74-4e42-8e4a-42ebd80d1c1d"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("4c0298b4-09c2-46e1-8baa-10b8395ebd94"), "Explore the versatility of modern technology with our range of tablets. Sleek and portable, these devices offer a seamless blend of productivity and entertainment. Whether you're browsing, working, or enjoying multimedia content, our tablets deliver stunning visuals and efficient performance. Stay connected on the go with these compact and feature-rich companions, redefining the way you experience digital mobility.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Tablets" },
                    { new Guid("7a92b0cd-7d8d-4ee9-8a82-4f482b4c4a95"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("4c0298b4-09c2-46e1-8baa-10b8395ebd94"), "Smartphones have become indispensable in our daily lives, serving as multifunctional devices that go beyond mere communication.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Smartphones" },
                    { new Guid("9f2ef2e1-15a5-4c93-bbfb-15a95c50d5e8"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("4c0298b4-09c2-46e1-8baa-10b8395ebd94"), "Elevate your mobile experience with our diverse range of phone accessories. From stylish cases that provide protection to chargers that keep you powered up, our collection enhances the functionality and style of your device. Explore a variety of accessories, including screen protectors, stands, and innovative gadgets, ensuring your phone is both personalized and optimized for your lifestyle.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Phone accessories" },
                    { new Guid("c1a5eab4-fcb5-4a76-8447-cbe95f4a4cc4"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("4c0298b4-09c2-46e1-8baa-10b8395ebd94"), "Stay connected effortlessly with our range of home and office phones. Designed for convenience, these phones blend functionality with sleek aesthetics, offering reliable communication solutions. Whether you're organizing your home or optimizing your office, our phones provide crystal-clear audio and user-friendly features for seamless conversations.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Home and office phones" },
                    { new Guid("d7f7fc67-7e84-4b72-90eb-99ab9a1fe1a8"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("4c0298b4-09c2-46e1-8baa-10b8395ebd94"), "Dive into superior sound quality with our sleek and comfortable headphones. Whether wireless or wired, enjoy immersive audio and noise cancellation, making them an essential accessory for music lovers and gamers alike.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Headphones" },
                    { new Guid("e3e9a6a7-6f1c-43bb-b0ac-6f646fa307fd"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("4c0298b4-09c2-46e1-8baa-10b8395ebd94"), "Enhance your audio experience with our range of headphone accessories. From comfortable ear cushions to tangle-free cables, our collection ensures optimal comfort and convenience. Explore accessories like stylish cases, adapters, and stands to complement your headphones, allowing you to personalize and elevate your listening setup effortlessly.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Headphone accessories" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("23f8c33a-16fc-4eaa-9c3e-b97e130dce9d"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("59053d5f-cd74-4e42-8e4a-42ebd80d1c1d"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("7a92b0cd-7d8d-4ee9-8a82-4f482b4c4a95"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("9f2ef2e1-15a5-4c93-bbfb-15a95c50d5e8"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("c1a5eab4-fcb5-4a76-8447-cbe95f4a4cc4"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("d7f7fc67-7e84-4b72-90eb-99ab9a1fe1a8"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("e3e9a6a7-6f1c-43bb-b0ac-6f646fa307fd"));
        }
    }
}
