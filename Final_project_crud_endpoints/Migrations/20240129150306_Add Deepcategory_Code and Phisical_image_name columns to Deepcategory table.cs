using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class AddDeepcategory_CodeandPhisical_image_namecolumnstoDeepcategorytable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Deepcategory_Code",
                table: "Deepcategories",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phisical_image_name",
                table: "Deepcategories",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("011cd970-d173-45aa-95ba-242b3442809e"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("02b84dde-1ae8-4e03-81f9-c164ef536b19"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("06c69235-4012-476e-9daf-6023eaad3bd4"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("087d5394-9fb8-46f0-beba-a6c8df2c0114"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("0d2689e3-cce8-4ef7-b152-a193594a0e0e"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("0f810786-43f5-41f1-929d-89d80b9a9235"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("10fd68cf-6503-4f17-9cb5-0b157093b4d0"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("1201990f-f7fa-486c-a98b-40065fd130cb"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("14db8bd4-4b22-4726-8058-4b02e2a16b73"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("15a950de-af6e-4f43-9ad0-f25fcb42e8ab"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("1a39bd74-4a89-43df-9fd9-b34710b1d221"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("1a97e5e2-07b6-4388-bce0-c16c99e3262a"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("1f875c75-491b-44e2-976e-a5c4e06c6d93"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("1f92ffa3-5a8e-4eab-a776-b0ced62195fb"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("28f7b326-391f-407c-9fb8-ec4b6458ddd5"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("2d4efe70-0f73-40ed-a431-0cecb3fe8601"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("320dfc5c-fb01-45d0-9f93-0b71dcc393b6"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("332253aa-aa2f-4c83-b69b-2ef5afd1395a"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("380d07fd-a2a4-4477-ab6f-7b95fafb0c88"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("38e612bc-d08a-49e7-bba7-e89b99860825"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("3b23c2f5-658a-4dc7-90d3-d5349c7cf6ef"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("40c96dfe-6df4-420b-9fb2-807cd31535bb"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("462f1143-3776-42a1-9e70-7adc31fdff93"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("4848fc7f-44a6-497a-907c-ae9acb6e88ed"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("4a51d1c9-2415-4eb4-8aae-a5bf732ddd89"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("4fe68c8c-130d-471a-bac4-eabd7eab4ee3"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("536bf179-64e7-4fd4-a944-1ad6a33ef352"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("592c0caf-47ac-4095-a39d-b7ffbd4ec886"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("599c9f12-b1c9-4dc0-8854-1af53d3bc2f0"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("5eaf8632-b8c7-45c4-b049-70bd6cf34739"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("686bdcfd-4a8c-4a46-8f2f-5c0221e26d95"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("68db1da6-3858-4d97-a42b-359c0ad8e332"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("738e7941-fce5-4fd0-8bc1-a615c67aa73a"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("7c5cb09e-76ef-4307-9012-fbd1db7e0a26"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("8047875e-f8ea-429c-bef9-5813d22f3a42"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("81a2378e-4dd7-4f06-8ff1-8d390afcd4d0"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("838f5b32-13c6-4910-9b43-bb06174d2165"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("8505c965-4e9d-4726-bf56-9be79d7d61e3"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("87f60f99-e88a-4a8b-9269-d67d4cc0106e"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("89e8df38-d10f-4d21-b688-03adde4890b3"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("89ff430a-a0cd-41b7-a803-c47fa04c2569"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("8b282235-99da-449e-a0ca-c0a755cf5087"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("8c7b2f7f-6122-4770-ba40-23a0c034bcdf"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("900c0cfb-12e2-4917-a69e-741271adb6ae"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("99554967-268f-461e-854b-9998bc8ef977"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("a00e3c68-146c-42a9-b794-0538a68c0cc2"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("a039a892-bf21-440b-869f-d8ee4155d18c"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("a98d197d-5d1b-46d7-8190-90cea77a73ff"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("aacd89bd-f53a-40e6-8cb5-045ac969da2d"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("ab334357-7842-4f11-82e9-91706f1cd590"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("aba63da0-0281-413b-9148-f68e2e0275cc"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("ac1807be-c7b3-483a-8a29-48da827ecd1f"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("acb0d8a7-79b7-44d8-8082-c786ccddc5d7"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("af4df39e-8846-4424-a3f4-2fd70333485b"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("af939c28-8161-411c-a6fe-7193b79e1e6c"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("b0823bd2-809c-4e25-bfb4-db44fe708dc8"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("b18e82d5-c4c5-4295-b9fa-99b82101a58f"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("c0e1f0e5-cc6c-4bdf-b23e-840441c9fde2"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("c1abc056-125a-4dc6-b953-620eb65fdea2"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("c3f67629-5dca-4a53-9432-247321f507e5"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("c3f67823-5dca-4a53-9432-247321f107e5"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("c3f97827-5dca-4a53-9432-247321f407e5"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("ca0e67f6-20c4-49f1-8f91-d7cd17e374a3"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("cce8806d-26a8-4601-80e5-acbcfc0dc553"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("d6211952-48af-4029-95b7-d6fc7844429c"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("dc0f0d97-95e1-478f-b6d9-2562e00d2193"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("e041cb2a-39b1-4ee1-95bb-60b806a99822"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("e59993b4-0e5f-4972-96d6-2b9928af3296"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("e61649b9-3499-469f-bc75-f9de4857488c"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("e7c9d156-dd96-42bb-b6a0-1884a3a5009f"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("e9281b7d-cb0c-45da-bf83-962bcd4ba656"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("e9e58617-65d6-4eec-9ec6-64b51559059d"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("f4ce55d0-37cb-415c-9a1b-367676a0d696"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("f5142e73-d14d-421e-8cac-3d5c9e3fdd42"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("f54296e5-2946-4e90-bc3c-0de027289e8d"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("f6afa27e-a06c-457e-bbad-9d536eedca4d"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("f8623b5a-756b-4b4e-89ad-3204dd8088d1"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("fc34b77b-6812-41fa-b942-998c92a77854"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("fd235119-1ca2-40f2-956e-17b040dd0d3a"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Deepcategories",
                keyColumn: "Id",
                keyValue: new Guid("ff7f0ed7-33f4-4067-8278-d291bc6cab0b"),
                columns: new[] { "Deepcategory_Code", "Phisical_image_name" },
                values: new object[] { "", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deepcategory_Code",
                table: "Deepcategories");

            migrationBuilder.DropColumn(
                name: "Phisical_image_name",
                table: "Deepcategories");
        }
    }
}
