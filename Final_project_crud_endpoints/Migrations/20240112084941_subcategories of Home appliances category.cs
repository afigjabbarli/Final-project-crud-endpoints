using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class subcategoriesofHomeappliancescategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "CreatedAt", "Current_Category_Id", "Description", "LastUpdatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("3c718a9b-8d43-4f45-8450-dce3627c3b04"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("9214f8c7-7c65-4c6d-852c-9f6f6c232a21"), "Create a comfortable and controlled environment with our advanced climate technology solutions. From smart thermostats and energy-efficient air purifiers to innovative heating and cooling systems, our collection is designed to enhance your indoor comfort. Experience the latest in climate control technology, optimizing energy efficiency and providing personalized settings for your home or office. Elevate your living and working spaces with our cutting-edge climate technology for a healthier, more comfortable environment.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Climate technology" },
                    { new Guid("6e8a719f-1c35-49a3-9209-6a9f132d2f0f"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("9214f8c7-7c65-4c6d-852c-9f6f6c232a21"), "Enhance your control over the indoor environment with our range of climate accessories. From smart thermostats and air purifiers to efficient humidifiers and space heaters, our collection complements your climate control system. Create a personalized and comfortable atmosphere in every room with accessories designed for efficiency and convenience. Elevate your indoor experience with our climate accessories, ensuring a tailored and enjoyable environment throughout the seasons.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Climate accessories" },
                    { new Guid("9d7f5e6a-20e3-4a57-b529-6d6f104e86c9"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("9214f8c7-7c65-4c6d-852c-9f6f6c232a21"), "Optimize the functionality and style of your home appliances with our range of accessories. From specialized attachments for kitchen appliances to add-ons for cleaning and maintenance tools, our collection is designed to enhance the performance and versatility of your household equipment. Explore thoughtful additions that cater to every need, ensuring a seamless and efficient experience with your appliances. Elevate the utility of your home appliances with our curated selection of accessories.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Accessories for home appliances" },
                    { new Guid("a1f5c6b3-509d-43a8-8d38-745e20d8f48b"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("9214f8c7-7c65-4c6d-852c-9f6f6c232a21"), "Elevate your home living experience with our curated selection of small appliances. From compact coffee makers and versatile food processors to space-saving irons and efficient hand blenders, our collection combines functionality and style. Streamline daily tasks and add convenience to your routine with these thoughtfully designed appliances. Discover the perfect blend of performance and aesthetics, enhancing both the functionality and charm of your living space.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Small appliances for the home" },
                    { new Guid("d0e3a99d-8d16-4a2a-81d6-5a9db9a40b28"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("9214f8c7-7c65-4c6d-852c-9f6f6c232a21"), "Transform your home into a haven of convenience and efficiency with our collection of great home appliances. From high-performance vacuum cleaners and energy-efficient washing machines to smart thermostats and innovative home security systems, our appliances enhance comfort and streamline daily tasks. Experience the latest in technology and design, ensuring that each appliance not only serves a purpose but also elevates your home living experience. Welcome to a smarter, more comfortable home with our range of great appliances.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Great appliances for the home" },
                    { new Guid("f2c4d60a-8e3a-4aa6-b8c6-754497a65a5b"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("9214f8c7-7c65-4c6d-852c-9f6f6c232a21"), "Discover a world of convenience and efficiency with our diverse range of household products. From cleaning essentials like vacuum cleaners and mops to organization solutions like storage containers and shelving units, our collection is designed to streamline your daily tasks. Experience the perfect blend of functionality and style as our household products enhance the comfort and aesthetics of your living space. Elevate your home living with our thoughtfully curated selection of essential household items.", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Household products" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("3c718a9b-8d43-4f45-8450-dce3627c3b04"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("6e8a719f-1c35-49a3-9209-6a9f132d2f0f"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("9d7f5e6a-20e3-4a57-b529-6d6f104e86c9"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("a1f5c6b3-509d-43a8-8d38-745e20d8f48b"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("d0e3a99d-8d16-4a2a-81d6-5a9db9a40b28"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("f2c4d60a-8e3a-4aa6-b8c6-754497a65a5b"));
        }
    }
}
