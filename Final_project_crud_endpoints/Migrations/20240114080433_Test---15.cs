using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class Test15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Deepcategories",
                columns: new[] { "Id", "CreatedAt", "Current_Subcategory_Id", "Description", "LastUpdatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("89e8df38-d10f-4d21-b688-03adde4890b3"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("b0f7748c-02cf-46e3-9c82-412c284240d1"), "Experience wireless freedom with Bluetooth Wireless Headphones. Immerse yourself in high-quality sound, hands-free convenience, and stylish designs for an elevated audio experience on the go.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Bluetooth wireless headphones" },
                    { new Guid("a00e3c68-146c-42a9-b794-0538a68c0cc2"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("b0f7748c-02cf-46e3-9c82-412c284240d1"), "Stay connected to your music and calls with our range of reliable wired headphones. From classic over-ear designs to comfortable in-ear options, our curated selection prioritizes durability and high-quality audio. Explore features like noise isolation and built-in microphones for added convenience. Elevate your listening experience with our carefully chosen wired headphones, ensuring a reliable and immersive sound for your music, podcasts, and hands-free communication.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Wired headphones" },
                    { new Guid("e041cb2a-39b1-4ee1-95bb-60b806a99822"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("b0f7748c-02cf-46e3-9c82-412c284240d1"), "Experience true wireless freedom with our collection of TWS (True Wireless Stereo) headphones. From compact earbuds to stylish charging cases, our curated selection offers seamless connectivity and impressive audio quality. Explore comfortable designs, touch controls, and features like noise isolation for an immersive listening experience. Elevate your audio journey with our carefully chosen TWS wireless headphones, providing the perfect combination of convenience and exceptional sound quality for music, calls, and more.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "TWS wireless headphones" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("89e8df38-d10f-4d21-b688-03adde4890b3"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("a00e3c68-146c-42a9-b794-0538a68c0cc2"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("e041cb2a-39b1-4ee1-95bb-60b806a99822"));
        }
    }
}
