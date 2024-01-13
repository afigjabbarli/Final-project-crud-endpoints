using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class seedofsubcategoriesofKitchenappliances : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "CreatedAt", "Current_Category_Id", "Description", "LastUpdatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("2b3fde56-118a-4f41-8a93-6fd157f2c4b5"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("f6b3406c-6046-486f-8ba8-a896ac26fe90"), "Upgrade your kitchen with our installed kitchen appliances, seamlessly blending form and function. From sleek built-in ovens and stylish cooktops to integrated refrigerators and advanced dishwashers, our collection combines modern design with cutting-edge technology. Experience the convenience of a well-equipped kitchen, where appliances are seamlessly integrated for a cohesive and efficient cooking space. Elevate your culinary environment with our range of installed kitchen appliances.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Installed kitchen appliances" },
                    { new Guid("45c89a7f-fa4d-4c3d-9f21-827f11a9c834"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("f6b3406c-6046-486f-8ba8-a896ac26fe90"), "Optimize your food preparation process with our comprehensive collection of kitchen equipment. From high-performance blenders and food processors to reliable mixers and efficient chopping tools, our range is designed to enhance your culinary experience. Experience the joy of cooking with precision and ease using our innovative kitchen equipment. Elevate your culinary skills and create delicious meals with the right tools for every step of the preparation journey.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Kitchen equipment for food preparation" },
                    { new Guid("7f9e65a1-6c4c-4dbb-a3d1-9e1c2b5b35b0"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("f6b3406c-6046-486f-8ba8-a896ac26fe90"), "Transform your kitchen into a culinary haven with our collection of great kitchen appliances. From high-performance blenders and versatile food processors to sleek coffee makers and efficient toasters, our appliances combine innovation and style. Experience the joy of cooking and entertaining with reliable, easy-to-use appliances that enhance your culinary skills. Elevate your kitchen experience with our range of appliances designed to make every meal a delight.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Great kitchen appliances" },
                    { new Guid("c09b1a8d-6922-47d2-8b9c-845c4a3cf79c"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("f6b3406c-6046-486f-8ba8-a896ac26fe90"), "Craft the perfect beverage with our premium drink preparation essentials. From state-of-the-art coffee makers and efficient tea infusers to innovative blenders for smoothies and cocktails, our collection ensures a delightful drink experience. Elevate your moments with precision and style, whether brewing your favorite coffee blend or concocting refreshing beverages. Embrace the art of drink preparation with our high-quality tools designed to enhance every sip.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Preparation of drink" },
                    { new Guid("e8a4d6b2-0b4f-4372-8292-665ae7d3f29e"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("f6b3406c-6046-486f-8ba8-a896ac26fe90"), "Elevate your dining experience with our exquisite collection of dishes. From elegant dinnerware sets to versatile serving plates, our dishes combine style and functionality. Explore a variety of designs, materials, and patterns to suit every occasion, from casual meals to formal gatherings. Create a visually appealing table setting with our high-quality dishes that add a touch of sophistication to your dining space.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Dishes" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("2b3fde56-118a-4f41-8a93-6fd157f2c4b5"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("45c89a7f-fa4d-4c3d-9f21-827f11a9c834"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("7f9e65a1-6c4c-4dbb-a3d1-9e1c2b5b35b0"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("c09b1a8d-6922-47d2-8b9c-845c4a3cf79c"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("e8a4d6b2-0b4f-4372-8292-665ae7d3f29e"));
        }
    }
}
