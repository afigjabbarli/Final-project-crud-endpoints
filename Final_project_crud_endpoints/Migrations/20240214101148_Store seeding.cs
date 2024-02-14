using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class Storeseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "Id", "Address", "CreatedAt", "LastUpdatedAt", "Name", "Phisical_image_name", "Phone_Number", "State", "Store_Code" },
                values: new object[,]
                {
                    { new Guid("0aa85fc2-699f-4fd7-8c38-e70ae3148b22"), "1733 14th St NW, Washington, DC 20009, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Logan Circle", "", "+18002500668", "WASHINGTON DC", "" },
                    { new Guid("0bdabb75-6a32-4201-8f25-b34b4ead47c5"), "40481 Murrieta Hot Springs Rd, Murrieta, CA 92563, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Murrieta", "", "+18002500668", "CALIFORNIA", "" },
                    { new Guid("192b3df2-6d78-4ff1-9b3c-50d0de1051d5"), "3116 Illinois Rte 59 Ste #104, Naperville, IL 60564, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Naperville", "", "+18002500668", "ILLINOIS", "" },
                    { new Guid("1a8820b1-488f-4720-b7a7-647f9f69f7c8"), "11340 South St, Cerritos, CA 90703, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Cerritos", "", "+18002500668", "CALIFORNIA", "" },
                    { new Guid("1f5b3eb3-e5eb-4d09-a15c-47736c12bab7"), "7201 W 24th St, North Riverside, IL 60546, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "North Riverside Harlem", "", "+18002500668", "ILLINOIS", "" },
                    { new Guid("22f41d38-c1b7-4448-a9ae-fd9abe96d4df"), "30 E Ridgewood Ave, Paramus, NJ 07652, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Paramus", "", "+18002500668", "NEW JERSEY", "" },
                    { new Guid("2bf29450-24fb-4498-8408-21fb24283062"), "610 E Pike St, Seattle, WA 98122, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "AVA Capitol Hill", "", "+18002500668", "WASHINGTON STATE", "" },
                    { new Guid("2c65e1af-7afc-4c76-b2c7-c0a58cefe765"), "1701 S Commons, Federal Way, WA 98003, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Federal Way", "", "+18002500668", "WASHINGTON STATE", "" },
                    { new Guid("2e710c0d-f9cd-4f36-b4ee-37db6d663dc9"), "1100 S Harbor Blvd, Fullerton, CA 92832, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Fullerton", "", "+18002500668", "CALIFORNIA", "" },
                    { new Guid("3089c262-f54e-4f4a-8a1e-31bc3454a460"), "16 A E Golf Rd, Schaumburg, IL 60173, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Schaumburg", "", "+18002500668", "ILLINOIS", "" },
                    { new Guid("45e40f90-50a3-4654-8ddf-1a1fbef4c86c"), "6939 Dempster St, Morton Grove, IL 60053, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Morton Grove", "", "+18002500668", "ILLINOIS", "" },
                    { new Guid("466c2a14-1b49-4df2-8805-3b7cfe296f4b"), "16325 Ventura Blvd, Encino, CA 91436, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Encino", "", "+18002500668", "CALIFORNIA", "" },
                    { new Guid("499f4d09-6c58-408e-ac8a-06eb9ff17f6d"), "1550 Crystal Dr, Arlington, VA 22202, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Arlington", "", "+18002500668", "VIRGINIA", "" },
                    { new Guid("4ebb2028-7c05-41a6-80e2-fbc4812bdf2a"), "1610 W Imperial Hwy Ste 200, La Habra, CA 90631, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "La Habra", "", "+18002500668", "CALIFORNIA", "" },
                    { new Guid("4ec05f08-5235-42fe-99b6-bc12cdb73680"), "4031 W 95th St, Oak Lawn, IL 60453, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Oak Lawn", "", "+18002500668", "ILLINOIS", "" },
                    { new Guid("577b69ad-9ec9-45de-8f83-c3b6765e2525"), "140 Promenade Way Thousand Oaks, CA 91362", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Westlake Village", "", "+18002500668", "CALIFORNIA", "" },
                    { new Guid("598e21f5-65e8-41ab-a8bb-7467b97a83d7"), "1351 E Ogden Ave, Naperville, IL 60563, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Naperville - Ogden", "", "+18002500668", "ILLINOIS", "" },
                    { new Guid("5cd241db-8bf2-4d59-a9a6-adc0c8862744"), "742 Los Angeles Ave, Moorpark, CA 93021, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Moorpark", "", "+18002500668", "CALIFORNIA", "" },
                    { new Guid("672bae49-d39c-42f4-9e68-15fc73f5671f"), "6245 CA-27, Woodland Hills, CA 91367, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Woodland Hills", "", "+18002500668", "CALIFORNIA", "" },
                    { new Guid("751fe878-76d2-408e-9182-e1220a7372ac"), "6811 Warner Ave, Huntington Beach, CA 92647, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Huntington Beach", "", "+18002500668", "CALIFORNIA", "" },
                    { new Guid("78a284d4-f35e-4cbe-b927-b557bbe27682"), "2924 Springfield Rd, Broomall, PA 19008, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Broomall", "", "+18002500668", "PENNSYLVANIA", "" },
                    { new Guid("78eda735-b162-4db7-9986-9e77364ee786"), "30 W 63rd St, Westmont, IL 60559, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Westmont", "", "+18002500668", "ILLINOIS", "" },
                    { new Guid("7b19420e-42b2-4c30-80c0-89ace1329ea0"), "3901 Factoria Square Mall SE, Bellevue, WA 98006, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Factoria", "", "+18002500668", "WASHINGTON STATE", "" },
                    { new Guid("7fd60b2c-a704-4e79-84bc-dfcddf3cf495"), "3425 E Colorado Blvd, Pasadena, CA 91107, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Pasadena", "", "+18002500668", "CALIFORNIA", "" },
                    { new Guid("96cfa05c-a8a4-43c1-97b9-605bbc0c6f49"), "389 Easton Rd, Warrington, PA 18976, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Warrington", "", "+18002500668", "PENNSYLVANIA", "" },
                    { new Guid("974ccf65-52f1-4fcc-add3-47e7376deea6"), "19340 Rinaldi St, Northridge, CA 91326, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Northridge", "", "+18002500668", "CALIFORNIA", "" },
                    { new Guid("9bcfc1ee-6718-447d-a1a3-487c4273fede"), "6855 S La Cienega Blvd, Los Angeles, CA 90045, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Los Angeles - Ladera Heights", "", "+18002500668", "CALIFORNIA", "" },
                    { new Guid("ae7dba7c-1759-4550-8058-d31519a770ca"), "26940 Crown Valley Pkwy, Mission Viejo, CA 92691, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Mission Viejo", "", "+18002500668", "CALIFORNIA", "" },
                    { new Guid("b30dcd36-4946-41f1-8145-315168dc6450"), "5463 Wisconsin Ave, Chevy Chase, MD 20815, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Chevy Chase", "", "+18002500668", "MARYLAND", "" },
                    { new Guid("b3997060-302a-42af-9538-bdd4a8d38146"), "6235 E Spring St, Long Beach, CA 90808, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Long Beach", "", "+18002500668", "CALIFORNIA", "" },
                    { new Guid("b8ebfcad-62c0-4ad8-abd4-74e71792fee7"), "15225 Whittier Blvd, Whittier, CA 90603, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Whittier", "", "+18002500668", "CALIFORNIA", "" },
                    { new Guid("b9154194-71ad-45d4-984e-c250d3bb3017"), "5101 Lankershim Blvd, North Hollywood, CA 91601, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "North Hollywood", "", "+18002500668", "CALIFORNIA", "" },
                    { new Guid("c10d56c2-86b7-4458-a403-94a8f7f7bfe5"), "at 7-Eleven, 9056 Liberia Ave, Manassas, VA 20110, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Manassas", "", "+18002500668", "VIRGINIA", "" },
                    { new Guid("c4677cb2-1ae4-420c-b989-fcae530c97fe"), "13205 Aurora Ave N, Seattle, WA 98133, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Seattle - Aurora", "", "+18002500668", "WASHINGTON STATE", "" },
                    { new Guid("c6040b82-7df7-4a6e-9519-98c93f04e8f2"), "7005 Manchester Blvd, Franconia, VA 22310, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Franconia", "", "+18002500668", "VIRGINIA", "" },
                    { new Guid("c85cab4a-4173-4dbc-a42c-b0fcd42c084d"), "9409 Lorton Market St, Lorton, VA 22079, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Lorton", "", "+18002500668", "VIRGINIA", "" },
                    { new Guid("df0abae4-94ef-4529-947b-c17e491f6865"), "10360 Fairfax Blvd, Fairfax, VA 22030, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Fairfax", "", "+18002500668", "VIRGINIA", "" },
                    { new Guid("e08e2464-6753-4efd-90b6-d74e91152a70"), "2229 Foothill Blvd, La Verne, CA 91750, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "La Verne", "", "+18002500668", "CALIFORNIA", "" },
                    { new Guid("e0f3067a-ce4b-4a1b-b345-8d113e3fb0a7"), "404 W Army Trail Rd, Bloomingdale, IL 60108, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Bloomingdale", "", "+18002500668", "ILLINOIS", "" },
                    { new Guid("e2017c16-ed2f-4b1b-9aa5-d870645c6aa7"), "4211 N Harlem Ave, Norridge, IL 60706, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Norridge", "", "+18002500668", "ILLINOIS", "" },
                    { new Guid("f0fa7eb6-6c54-4f18-bc89-15e541e792aa"), "2301 S Jackson St, Seattle, WA 98144, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Seattle - Jackson St", "", "+18002500668", "WASHINGTON STATE", "" },
                    { new Guid("f2965119-f9c2-4e43-91be-1497fd84cfbc"), "13672 Jamboree Rd, Irvine, CA 92602, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Irvine", "", "+18002500668", "CALIFORNIA", "" },
                    { new Guid("fe7b900a-fe4c-4f67-b967-6f8d4faa0cdb"), "5463 Wisconsin Ave, Chevy Chase - Lake Terrace, MD 20815, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Chevy Chase - Lake Terrace", "", "+18002500668", "MARYLAND", "" },
                    { new Guid("ff9e1838-f134-4671-8cfb-008e91de11ea"), "3620 Long Beach Rd, Oceanside, NY 11572, United States", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Oceanside", "", "+18002500668", "NEW YORK", "" }
                });

            migrationBuilder.UpdateData(
                table: "Warranties",
                keyColumn: "Id",
                keyValue: new Guid("29b6f35a-db7c-43f6-bb3b-5d0a2bd794d6"),
                column: "Name",
                value: "V.I.P. Warranty");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("0aa85fc2-699f-4fd7-8c38-e70ae3148b22"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("0bdabb75-6a32-4201-8f25-b34b4ead47c5"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("192b3df2-6d78-4ff1-9b3c-50d0de1051d5"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("1a8820b1-488f-4720-b7a7-647f9f69f7c8"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("1f5b3eb3-e5eb-4d09-a15c-47736c12bab7"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("22f41d38-c1b7-4448-a9ae-fd9abe96d4df"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("2bf29450-24fb-4498-8408-21fb24283062"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("2c65e1af-7afc-4c76-b2c7-c0a58cefe765"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("2e710c0d-f9cd-4f36-b4ee-37db6d663dc9"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("3089c262-f54e-4f4a-8a1e-31bc3454a460"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("45e40f90-50a3-4654-8ddf-1a1fbef4c86c"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("466c2a14-1b49-4df2-8805-3b7cfe296f4b"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("499f4d09-6c58-408e-ac8a-06eb9ff17f6d"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("4ebb2028-7c05-41a6-80e2-fbc4812bdf2a"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("4ec05f08-5235-42fe-99b6-bc12cdb73680"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("577b69ad-9ec9-45de-8f83-c3b6765e2525"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("598e21f5-65e8-41ab-a8bb-7467b97a83d7"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("5cd241db-8bf2-4d59-a9a6-adc0c8862744"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("672bae49-d39c-42f4-9e68-15fc73f5671f"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("751fe878-76d2-408e-9182-e1220a7372ac"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("78a284d4-f35e-4cbe-b927-b557bbe27682"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("78eda735-b162-4db7-9986-9e77364ee786"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("7b19420e-42b2-4c30-80c0-89ace1329ea0"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("7fd60b2c-a704-4e79-84bc-dfcddf3cf495"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("96cfa05c-a8a4-43c1-97b9-605bbc0c6f49"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("974ccf65-52f1-4fcc-add3-47e7376deea6"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("9bcfc1ee-6718-447d-a1a3-487c4273fede"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("ae7dba7c-1759-4550-8058-d31519a770ca"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("b30dcd36-4946-41f1-8145-315168dc6450"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("b3997060-302a-42af-9538-bdd4a8d38146"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("b8ebfcad-62c0-4ad8-abd4-74e71792fee7"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("b9154194-71ad-45d4-984e-c250d3bb3017"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("c10d56c2-86b7-4458-a403-94a8f7f7bfe5"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("c4677cb2-1ae4-420c-b989-fcae530c97fe"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("c6040b82-7df7-4a6e-9519-98c93f04e8f2"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("c85cab4a-4173-4dbc-a42c-b0fcd42c084d"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("df0abae4-94ef-4529-947b-c17e491f6865"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("e08e2464-6753-4efd-90b6-d74e91152a70"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("e0f3067a-ce4b-4a1b-b345-8d113e3fb0a7"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("e2017c16-ed2f-4b1b-9aa5-d870645c6aa7"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("f0fa7eb6-6c54-4f18-bc89-15e541e792aa"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("f2965119-f9c2-4e43-91be-1497fd84cfbc"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("fe7b900a-fe4c-4f67-b967-6f8d4faa0cdb"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("ff9e1838-f134-4671-8cfb-008e91de11ea"));

            migrationBuilder.UpdateData(
                table: "Warranties",
                keyColumn: "Id",
                keyValue: new Guid("29b6f35a-db7c-43f6-bb3b-5d0a2bd794d6"),
                column: "Name",
                value: "V.I.P Warranty");
        }
    }
}
