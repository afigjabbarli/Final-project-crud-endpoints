using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class Test14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("1f875c75-491b-44e2-976e-a5c4e06c6d93"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Optimize control and efficiency with a Management Hub. Streamline operations, monitor performance, and make informed decisions seamlessly from this centralized management solution.", "Management hub" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("1f92ffa3-5a8e-4eab-a776-b0ced62195fb"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Empower your devices with precision using advanced Sensors. From motion detection to environmental monitoring, our sensors deliver accurate data for enhanced functionality and automation.", "Sensors" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("2d4efe70-0f73-40ed-a431-0cecb3fe8601"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Illuminate intelligently with Smart Lighting. Customize ambiance, control remotely, and save energy through innovative, connected lighting solutions for modern living spaces.", "Lighting" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("38e612bc-d08a-49e7-bba7-e89b99860825"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Ensure security with IP Video Surveillance Cameras. Experience high-definition monitoring, remote access, and advanced features for comprehensive and reliable video surveillance in any environment.", "IP video surveillance cameras" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("acb0d8a7-79b7-44d8-8082-c786ccddc5d7"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Upgrade security effortlessly with Smart Locks. Enjoy keyless entry, remote control, and personalized access, enhancing convenience and peace of mind in your connected home or business.", "Smart locks" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("af4df39e-8846-4424-a3f4-2fd70333485b"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Effortlessly manage your devices with Smart Electrical Sockets. Control remotely, set schedules, and monitor energy usage for a smarter, more efficient home or office environment.", "Smart electrical sockets" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("c1abc056-125a-4dc6-b953-620eb65fdea2"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Enhance communication with Intercom Systems. Streamline interactions, monitor entrances, and ensure seamless connectivity for secure and efficient communication within your home or business.", "Intercoms" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("e7c9d156-dd96-42bb-b6a0-1884a3a5009f"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Transform your home with Smart Electric Switches. Enjoy remote control, voice activation, and scheduling features for convenient and energy-efficient lighting and appliance management.", "Smart electric switches" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("1f875c75-491b-44e2-976e-a5c4e06c6d93"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Enhance communication with Intercom Systems. Streamline interactions, monitor entrances, and ensure seamless connectivity for secure and efficient communication within your home or business.", "Intercoms" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("1f92ffa3-5a8e-4eab-a776-b0ced62195fb"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Upgrade security effortlessly with Smart Locks. Enjoy keyless entry, remote control, and personalized access, enhancing convenience and peace of mind in your connected home or business.", "Smart locks" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("2d4efe70-0f73-40ed-a431-0cecb3fe8601"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Transform your home with Smart Electric Switches. Enjoy remote control, voice activation, and scheduling features for convenient and energy-efficient lighting and appliance management.", "Smart electric switches" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("38e612bc-d08a-49e7-bba7-e89b99860825"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Empower your devices with precision using advanced Sensors. From motion detection to environmental monitoring, our sensors deliver accurate data for enhanced functionality and automation.", "Sensors" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("acb0d8a7-79b7-44d8-8082-c786ccddc5d7"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Effortlessly manage your devices with Smart Electrical Sockets. Control remotely, set schedules, and monitor energy usage for a smarter, more efficient home or office environment.", "Smart electrical sockets" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("af4df39e-8846-4424-a3f4-2fd70333485b"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Ensure security with IP Video Surveillance Cameras. Experience high-definition monitoring, remote access, and advanced features for comprehensive and reliable video surveillance in any environment.", "IP video surveillance cameras" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("c1abc056-125a-4dc6-b953-620eb65fdea2"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Illuminate intelligently with Smart Lighting. Customize ambiance, control remotely, and save energy through innovative, connected lighting solutions for modern living spaces.", "Lighting" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("e7c9d156-dd96-42bb-b6a0-1884a3a5009f"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Optimize control and efficiency with a Management Hub. Streamline operations, monitor performance, and make informed decisions seamlessly from this centralized management solution.", "Management hub" });
        }
    }
}
