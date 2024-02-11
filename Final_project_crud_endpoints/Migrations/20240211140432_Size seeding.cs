using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class Sizeseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Size",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Size", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("13fd75d0-496f-49cb-bb8c-b7bd75b81d74"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "XL" },
                    { new Guid("5b1dfdff-da43-4d89-a7c4-b70ea1059f11"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "M" },
                    { new Guid("8bd829a6-34ba-44a7-8b4d-0ad93f90d484"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "XXS" },
                    { new Guid("9041cdfa-244d-4f0d-bbd1-704f28c406a2"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "S" },
                    { new Guid("ac49680d-c4d1-49c0-a73c-55fb4eeeec78"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "XXL" },
                    { new Guid("df31d3cc-7b41-43f0-af17-125cdd195c3f"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "L" },
                    { new Guid("eb3f62f7-cc00-4398-8f29-3c517fb1f6c7"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "XS" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Size");
        }
    }
}
