using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Deepcategories",
                columns: new[] { "Id", "CreatedAt", "Current_Subcategory_Id", "Description", "LastUpdatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("06c69235-4012-476e-9daf-6023eaad3bd4"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("d7f7fc67-7e84-4b72-90eb-99ab9a1fe1a8"), "Cut the cords and embrace freedom with our collection of Bluetooth wireless headphones. From over-ear to in-ear options, our curated selection offers convenience and high-quality audio. Explore comfortable designs, advanced features like noise cancellation, and long-lasting battery life. Elevate your listening experience with our thoughtfully chosen Bluetooth wireless headphones, providing the perfect blend of portability and immersive sound for music, calls, and more.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Bluetooth wireless headphones" },
                    { new Guid("e61649b9-3499-469f-bc75-f9de4857488c"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("d7f7fc67-7e84-4b72-90eb-99ab9a1fe1a8"), "Experience true wireless freedom with our collection of TWS (True Wireless Stereo) headphones. From compact earbuds to stylish charging cases, our curated selection offers seamless connectivity and impressive audio quality. Explore comfortable designs, touch controls, and features like noise isolation for an immersive listening experience. Elevate your audio journey with our carefully chosen TWS wireless headphones, providing the perfect combination of convenience and exceptional sound quality for music, calls, and more.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "TWS wireless headphones" },
                    { new Guid("f4ce55d0-37cb-415c-9a1b-367676a0d696"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("d7f7fc67-7e84-4b72-90eb-99ab9a1fe1a8"), "Stay connected to your music and calls with our range of reliable wired headphones. From classic over-ear designs to comfortable in-ear options, our curated selection prioritizes durability and high-quality audio. Explore features like noise isolation and built-in microphones for added convenience. Elevate your listening experience with our carefully chosen wired headphones, ensuring a reliable and immersive sound for your music, podcasts, and hands-free communication.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Wired headphones" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("06c69235-4012-476e-9daf-6023eaad3bd4"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("e61649b9-3499-469f-bc75-f9de4857488c"));

            migrationBuilder.DeleteData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("f4ce55d0-37cb-415c-9a1b-367676a0d696"));
        }
    }
}
