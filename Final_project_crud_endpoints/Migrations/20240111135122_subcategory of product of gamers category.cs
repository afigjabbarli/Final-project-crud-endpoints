using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class subcategoryofproductofgamerscategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "CreatedAt", "Current_Category_Id", "Description", "LastUpdatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("17bbd60c-503a-46f4-9910-c44d2b7efba6"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("cdb59c3a-487c-42e5-bc0e-58ad5cfb93d3"), "Elevate your gaming setup with our premium game peripherals. From responsive keyboards and precision mice to immersive headsets and customizable controllers, our collection is designed to enhance every aspect of your gaming experience. Explore cutting-edge technology, ergonomic designs, and customizable features that cater to both casual and competitive gamers. Level up your gaming performance and immerse yourself in a world of unparalleled control and precision with our game peripherals.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Game peripherals" },
                    { new Guid("17f2c0cc-38d3-452e-88ce-510090de2b92"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("cdb59c3a-487c-42e5-bc0e-58ad5cfb93d3"), "Unleash the power of gaming on the go with our cutting-edge gaming smartphones. Engineered for high-performance gaming experiences, these devices combine top-tier processors, advanced cooling systems, and immersive displays. Enjoy seamless gameplay, stunning graphics, and responsive controls as you dive into your favorite mobile games. Elevate your gaming journey with our gaming smartphones, where technology meets the thrill of unparalleled mobile gaming.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Gaming smartphones" },
                    { new Guid("29c45e6f-6a5e-4c46-a5ec-71a7c6ee81f8"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("cdb59c3a-487c-42e5-bc0e-58ad5cfb93d3"), "Dive into the world of immersive gaming with our high-performance gaming monitors. Engineered for speed and precision, these monitors boast high refresh rates, low input lag, and vibrant displays. Experience fluid graphics, sharp details, and responsive gameplay as you immerse yourself in your favorite titles. Whether you're a casual gamer or a competitive esports enthusiast, our gaming monitors redefine visual excellence for an unparalleled gaming experience.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Gaming monitors" },
                    { new Guid("7a28c90b-9a2e-4ab6-8255-7c7e6c653685"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("cdb59c3a-487c-42e5-bc0e-58ad5cfb93d3"), "Dive into a world of immersive gaming with the PlayStation console series. Whether you're a solo player or enjoy multiplayer experiences, PlayStation delivers cutting-edge technology, stunning graphics, and a vast library of games. From the latest releases to beloved classics, the PlayStation ecosystem offers entertainment for every gaming enthusiast. Elevate your gaming experience with the iconic PlayStation console, where innovation meets unparalleled gameplay.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "PlayStation" },
                    { new Guid("8725ff1b-d64d-4f14-b0c1-663c16fdd554"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("cdb59c3a-487c-42e5-bc0e-58ad5cfb93d3"), "Upgrade and optimize your computing experience with our comprehensive range of computer parts. Explore powerful processors, high-capacity storage solutions, cutting-edge graphics cards, and fast memory options. Whether you're building a custom PC, enhancing gaming performance, or improving productivity, our selection of computer parts ensures top-tier quality, compatibility, and reliability for your computing needs.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Computer parts" },
                    { new Guid("a41241d1-45ac-4715-8e92-9cbf9f9b3ef7"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("cdb59c3a-487c-42e5-bc0e-58ad5cfb93d3"), "Dive into an immersive gaming experience with our high-performance gaming monitors. Designed for speed and precision, these monitors deliver high refresh rates, low input lag, and vibrant displays. Enjoy fluid graphics, sharp details, and responsive gameplay as you plunge into your favorite titles. Whether you're a casual gamer or an esports enthusiast, our gaming monitors redefine visual excellence, offering an unparalleled and responsive gaming environment.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Gaming monitors" },
                    { new Guid("d0d7aa6e-bcb3-4c14-96f9-0a45e9149a67"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("cdb59c3a-487c-42e5-bc0e-58ad5cfb93d3"), "Unleash gaming excellence on the go with our cutting-edge gaming notebooks. Engineered for portable power, these laptops feature high-performance processors, powerful graphics cards, and high-refresh-rate displays. Immerse yourself in vivid graphics and responsive gameplay wherever you go. Whether you're a casual gamer or a competitive enthusiast, our gaming notebooks provide a perfect blend of performance, portability, and style for an exceptional gaming experience on the move.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Gaming notebooks" },
                    { new Guid("d1bba8aa-b0d4-42a7-b08f-71b5e7757cb3"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("cdb59c3a-487c-42e5-bc0e-58ad5cfb93d3"), "Dive into the gaming world with the Xbox console series. Designed for unparalleled entertainment, Xbox offers a vast library of games, stunning graphics, and immersive experiences. From the latest releases to classic favorites, the Xbox ecosystem caters to gamers of all tastes and preferences. Elevate your gaming journey with cutting-edge technology and a community that celebrates the love of gaming. Welcome to the next level of entertainment with Xbox.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Xbox" },
                    { new Guid("dbbba1f1-e5fc-4f0e-bc4d-263d2cfe9290"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("cdb59c3a-487c-42e5-bc0e-58ad5cfb93d3"), "Enhance your mobile gaming experience with our gamepad for smartphones. Designed for comfort and precision, these controllers bring console-like gaming to your fingertips. With ergonomic designs and customizable buttons, our gamepads offer seamless control for a wide range of games. Elevate your mobile gaming adventures and enjoy immersive gameplay with the convenience of our responsive and versatile gamepads.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Gamepad for smartphone" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("17bbd60c-503a-46f4-9910-c44d2b7efba6"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("17f2c0cc-38d3-452e-88ce-510090de2b92"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("29c45e6f-6a5e-4c46-a5ec-71a7c6ee81f8"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("7a28c90b-9a2e-4ab6-8255-7c7e6c653685"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("8725ff1b-d64d-4f14-b0c1-663c16fdd554"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("a41241d1-45ac-4715-8e92-9cbf9f9b3ef7"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("d0d7aa6e-bcb3-4c14-96f9-0a45e9149a67"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("d1bba8aa-b0d4-42a7-b08f-71b5e7757cb3"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("dbbba1f1-e5fc-4f0e-bc4d-263d2cfe9290"));
        }
    }
}
