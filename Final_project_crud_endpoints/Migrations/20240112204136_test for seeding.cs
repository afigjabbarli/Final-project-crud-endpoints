using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class testforseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("026d0440-e16e-406f-a211-cb3c574cc6db"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("11b9a66a-7c72-45e8-a235-5472d0081112"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("330a3663-3ed2-45ed-a1b4-8108d27c2a1a"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("528871d0-4cf0-4299-a359-84402b024ef6"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("734b7def-3aa0-4081-96aa-227aaefd10ba"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("b6e5f66a-db43-4003-a38e-43ce1fbd085f"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("c17aef02-ad65-4b0c-9a67-95ff2351ca3d"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("c517b2c7-b756-49a6-9e5f-3b5414a0ee04"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("cf5446f0-7c6b-44fc-8505-a7497ec84e18"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("dd5be212-cda5-44d3-abbc-7782ff8ed14d"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("e4bc6462-c946-4903-87ab-861656ebc56a"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "CreatedAt", "Current_Category_Id", "Description", "LastUpdatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("026d0440-e16e-406f-a211-cb3c574cc6db"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("5b9e0bd5-927c-4d4b-9534-9b67ef7235b2"), "Efficiently water your garden or landscape with our range of drip systems. From drip irrigation kits to individual components like tubing, emitters, and filters, our collection is designed to provide a precise and water-efficient solution for plant hydration. Explore carefully curated items that cater to various garden sizes and layouts, ensuring you have the right components for an effective drip irrigation system. Elevate your gardening experience with our selection of drip systems, promoting water conservation and healthy plant growth.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Drip systems" },
                    { new Guid("11b9a66a-7c72-45e8-a235-5472d0081112"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("5b9e0bd5-927c-4d4b-9534-9b67ef7235b2"), "Power up your devices with our reliable range of batteries. From everyday essentials like AA and AAA batteries to specialty sizes for cameras and watches, our collection ensures a dependable energy source for various electronics. Explore long-lasting options from trusted brands, designed to meet the diverse needs of your devices. Elevate your battery experience with our carefully curated selection, providing the essential power you need for a wide range of applications.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Batteries" },
                    { new Guid("330a3663-3ed2-45ed-a1b4-8108d27c2a1a"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("5b9e0bd5-927c-4d4b-9534-9b67ef7235b2"), "Nurture your outdoor haven with our range of reliable garden equipment. From robust lawnmowers and versatile trimmers to ergonomic hand tools and efficient watering systems, our collection is designed to enhance your gardening experience. Explore carefully curated items that cater to both novice and experienced gardeners, ensuring a well-maintained and thriving garden. Elevate your outdoor space with our selection of garden equipment, providing the essential tools for cultivating a beautiful and flourishing garden.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Garden equipment" },
                    { new Guid("528871d0-4cf0-4299-a359-84402b024ef6"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("5b9e0bd5-927c-4d4b-9534-9b67ef7235b2"), "Dive into relaxation with our selection of pool and equipment essentials. From durable pool accessories and comfortable loungers to efficient cleaning equipment and safety gear, our collection is designed to enhance your pool experience. Explore carefully curated items that prioritize both fun and functionality. Elevate your poolside oasis with our range of products, ensuring a refreshing and enjoyable environment for relaxation, entertainment, and aquatic activities.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Pool and equipment" },
                    { new Guid("734b7def-3aa0-4081-96aa-227aaefd10ba"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("5b9e0bd5-927c-4d4b-9534-9b67ef7235b2"), "Nurture your garden with our comprehensive range of garden supplies. From premium soil and fertilizers to durable gardening tools and stylish planters, our collection is designed to cater to the diverse needs of garden enthusiasts. Explore carefully curated items that prioritize both functionality and aesthetics, ensuring you have the essentials for successful gardening. Elevate your outdoor space with our selection of garden supplies, providing the tools and materials needed for a thriving and beautiful garden.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Garden supplies" },
                    { new Guid("b6e5f66a-db43-4003-a38e-43ce1fbd085f"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("5b9e0bd5-927c-4d4b-9534-9b67ef7235b2"), "Celebrate the New Year in style with our festive collection of products. From sparkling decorations and elegant party supplies to thoughtful gifts and accessories, our range is designed to add joy and flair to your New Year's festivities. Explore carefully curated items that bring a touch of celebration to your home and gatherings. Elevate your New Year's experience with our selection of products that make ringing in the new chapter both memorable and enjoyable.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "New Year products" },
                    { new Guid("c17aef02-ad65-4b0c-9a67-95ff2351ca3d"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("5b9e0bd5-927c-4d4b-9534-9b67ef7235b2"), "Illuminate your space with our diverse collection of lighting solutions. From stylish pendant lights and modern floor lamps to versatile LED strips and innovative smart lighting, our range caters to various design preferences and functional needs. Explore carefully curated lighting options that add ambiance and functionality to every room. Elevate your living spaces with our thoughtfully selected collection, ensuring you find the perfect lighting solutions to create the desired atmosphere in your home.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Lighting" },
                    { new Guid("c517b2c7-b756-49a6-9e5f-3b5414a0ee04"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("5b9e0bd5-927c-4d4b-9534-9b67ef7235b2"), "Transform your living space into an intelligent and efficient hub with our range of smart home solutions. From smart thermostats and lighting systems to security cameras and voice-activated assistants, our collection integrates cutting-edge technology to enhance comfort, convenience, and security in your home. Explore innovative devices that allow you to control and automate various aspects of your living space. Elevate your lifestyle with our carefully curated selection of smart home products, bringing connectivity and intelligence to every corner of your home.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Smart home" },
                    { new Guid("cf5446f0-7c6b-44fc-8505-a7497ec84e18"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("5b9e0bd5-927c-4d4b-9534-9b67ef7235b2"), "Travel in style with our curated collection of suitcases. From durable hard-shell luggage to versatile soft-sided options, our range caters to various travel needs and preferences. Explore carefully selected suitcases that prioritize both functionality and aesthetics, ensuring you have the right travel companion for your journey. Elevate your travel experience with our thoughtfully curated selection of suitcases, providing durability, convenience, and style for your adventures near and far.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Suitcases" },
                    { new Guid("dd5be212-cda5-44d3-abbc-7782ff8ed14d"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("5b9e0bd5-927c-4d4b-9534-9b67ef7235b2"), "Elevate your living spaces with our curated collection of home decors. From stylish wall art and elegant vases to cozy throw pillows and modern lighting fixtures, our range is designed to add personality and charm to your home. Explore carefully selected items that cater to various tastes and interior styles, ensuring you find the perfect accents to complement your decor. Transform your living spaces and express your unique style with our thoughtfully curated selection of home decor items.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Home decors" },
                    { new Guid("e4bc6462-c946-4903-87ab-861656ebc56a"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("5b9e0bd5-927c-4d4b-9534-9b67ef7235b2"), "Secure your valuables with our range of safes designed for both home and office use. From compact personal safes to larger fire-resistant options, our collection prioritizes reliable security for your important documents, jewelry, and belongings. Explore carefully curated safes that feature advanced locking mechanisms, durable construction, and various size options. Elevate your peace of mind with our thoughtfully selected safes, providing a secure and organized storage solution for your most valuable possessions.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Safes" }
                });
        }
    }
}
