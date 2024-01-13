using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class seedingsubcategoriesofHobbyandentertainmentcategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Color",
                table: "Color");

            migrationBuilder.RenameTable(
                name: "Color",
                newName: "Colors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Colors",
                table: "Colors",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "CreatedAt", "Current_Category_Id", "Description", "LastUpdatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("1d6e8b7f-94c0-4838-9e6e-ec91f0f8f57b"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("b654a618-ec4f-4d7f-a90e-0c5ea3eaa0e1"), "Dive into unparalleled gaming experiences with the PlayStation console series. From stunning graphics to a vast library of games, the PlayStation ecosystem offers entertainment for every gaming enthusiast. Explore the latest releases, engage in multiplayer adventures, and enjoy a platform that continues to redefine interactive entertainment. Elevate your gaming journey with cutting-edge technology and an immersive gaming community. Welcome to the world of PlayStation, where innovation meets unparalleled gameplay.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "PlayStation" },
                    { new Guid("2a5c3d18-7a9e-4df0-9321-6d5a8a9b5d89"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("b654a618-ec4f-4d7f-a90e-0c5ea3eaa0e1"), "Dive into the exciting world of video games with our extensive collection. From immersive story-driven adventures to heart-pounding action and multiplayer experiences, our selection caters to gamers of all preferences. Explore the latest releases and classic favorites across various genres, ensuring there's something for every gaming enthusiast. Elevate your gaming experience with our diverse range of video games, where entertainment and excitement come together for unforgettable virtual adventures.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Video games" },
                    { new Guid("5a4f8ec3-291e-4e65-9db3-fb4e5c9d8a1d"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("b654a618-ec4f-4d7f-a90e-0c5ea3eaa0e1"), "Explore seamless mobility with our diverse range of transportation solutions. From eco-friendly electric vehicles and efficient bicycles to innovative scooters and smart city commuting solutions, our collection is designed to redefine the way you move. Discover cutting-edge technology that prioritizes sustainability, efficiency, and connectivity, ensuring your journeys are both enjoyable and eco-conscious. Elevate your transportation experience with our thoughtfully curated selection of products that cater to modern mobility needs.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Transportation" },
                    { new Guid("6d8b2a4e-1c3d-4e46-88c7-9f5ea13c1f8d"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("b654a618-ec4f-4d7f-a90e-0c5ea3eaa0e1"), "Embark on whimsical adventures and classic gaming fun with Nintendo. From iconic franchises like Mario and Zelda to innovative gaming consoles like the Nintendo Switch, our collection offers a diverse range of games and experiences. Explore family-friendly titles, engaging multiplayer options, and the charm of Nintendo's unique gaming world. Elevate your gaming with the creativity, nostalgia, and timeless joy that Nintendo brings to players of all ages.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Nintendo" },
                    { new Guid("8a9d6f1c-5b0e-487e-9c7f-2e01a963e6b7"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("b654a618-ec4f-4d7f-a90e-0c5ea3eaa0e1"), "Unleash your musical passion with our extensive collection of musical instruments. From classic guitars and versatile keyboards to powerful drums and wind instruments, our range caters to musicians of all levels and genres. Explore high-quality craftsmanship, innovative designs, and a variety of accessories that enhance your playing experience. Elevate your musical journey with our carefully curated selection of instruments, ensuring you have the tools to express yourself and create beautiful melodies.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Musical instruments" },
                    { new Guid("8f5c3a1d-62b9-4b82-9d8f-ace75eab8e7b"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("b654a618-ec4f-4d7f-a90e-0c5ea3eaa0e1"), "Maximize your performance and embrace an active lifestyle with our range of sports products. From high-quality athletic wear and supportive footwear to cutting-edge equipment for various sports, our collection caters to enthusiasts of all levels. Explore gear that prioritizes comfort, durability, and performance, ensuring you have the right tools for your fitness journey. Elevate your sports experience with our carefully curated selection of products designed to inspire and support your active endeavors.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Sports products" },
                    { new Guid("b8a3d6c9-7fe0-4fbb-9b48-f4c11c0d48a7"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("b654a618-ec4f-4d7f-a90e-0c5ea3eaa0e1"), "Optimize your creative space with our curated selection of studio accessories. From adjustable lighting and ergonomic furniture to cable management solutions and versatile storage options, our collection is designed to enhance functionality and aesthetics in your studio. Explore accessories that cater to the specific needs of photographers, artists, musicians, and content creators. Elevate your studio environment with thoughtfully chosen accessories that bring efficiency and style to your creative workspace.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Studio accessories" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Colors",
                table: "Colors");

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("1d6e8b7f-94c0-4838-9e6e-ec91f0f8f57b"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("2a5c3d18-7a9e-4df0-9321-6d5a8a9b5d89"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("5a4f8ec3-291e-4e65-9db3-fb4e5c9d8a1d"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("6d8b2a4e-1c3d-4e46-88c7-9f5ea13c1f8d"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("8a9d6f1c-5b0e-487e-9c7f-2e01a963e6b7"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("8f5c3a1d-62b9-4b82-9d8f-ace75eab8e7b"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("b8a3d6c9-7fe0-4fbb-9b48-f4c11c0d48a7"));

            migrationBuilder.RenameTable(
                name: "Colors",
                newName: "Color");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Color",
                table: "Color",
                column: "Id");
        }
    }
}
