using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_project_crud_endpoints.Migrations
{
    public partial class AddingPhisical_image_nameandSubcategory_CodecolumnstoSubcategorytable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Phisical_image_name",
                table: "Subcategories",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Subcategory_Code",
                table: "Subcategories",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("026d0440-e16e-406f-a211-cb3c574cc6db"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("042a0d33-d091-4a01-b63c-e676d879d4c8"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("07ff4b23-b509-41e2-b932-37eae200181c"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("0a273bfb-28e6-4d34-a497-6ef2e24e4b5a"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("11b9a66a-7c72-45e8-a235-5472d0081112"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("17bbd60c-503a-46f4-9910-c44d2b7efba6"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("17f2c0cc-38d3-452e-88ce-510090de2b92"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("1a3f6c8e-cd94-4ac8-84b9-02c3f9d8e0b6"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("1a9d6e8f-cd3b-4f80-8c65-3a0e5d8f6b1a"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("1d6e8b7f-94c0-4838-9e6e-ec91f0f8f57b"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("1eb107f7-8525-4ed0-af50-8e01f7731d0b"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("1f6e8d24-8653-4270-8e3d-6cfe922a4b8a"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("1f9db05a-b5cc-4ea7-8e6d-93e12b5b8d5d"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("23f8c33a-16fc-4eaa-9c3e-b97e130dce9d"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("29c45e6f-6a5e-4c46-a5ec-71a7c6ee81f8"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("2a5c3d18-7a9e-4df0-9321-6d5a8a9b5d89"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("2b3fde56-118a-4f41-8a93-6fd157f2c4b5"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("2c6e7f8d-af34-48bd-b2a1-c5c8d39a6e4f"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("2d61c82b-9ba7-4528-9e14-d8de745f32b3"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("330a3663-3ed2-45ed-a1b4-8108d27c2a1a"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("3a6b95f8-eda4-45b8-9dd1-1aa64e2eeb8c"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("3c718a9b-8d43-4f45-8450-dce3627c3b04"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("431bbfe3-7e5d-4d90-b590-e20fb631ac3d"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("45c89a7f-fa4d-4c3d-9f21-827f11a9c834"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("47bd8a53-93c2-4bc7-b77b-9c6d8e9352c6"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("4c2f7b9d-b8a3-4f5c-8369-9e0d4f1e7c2d"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("4c9b5a81-7f8c-4ee0-8ba2-ead63a7dc6f3"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("4e9b8c5a-d0e2-4af6-b6cf-d91c2f8e5b7a"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("528871d0-4cf0-4299-a359-84402b024ef6"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("59053d5f-cd74-4e42-8e4a-42ebd80d1c1d"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("5a4f8ec3-291e-4e65-9db3-fb4e5c9d8a1d"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("5c0a8f1d-4d7e-4950-abe6-3e8d6f9b2c8a"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("5e8c4f2d-7a19-4d5e-a18b-9c32f6d8c5b7"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("63ad6b9b-4b3a-4b1f-b823-276db0a0c28f"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("6d8b2a4e-1c3d-4e46-88c7-9f5ea13c1f8d"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("6e8a719f-1c35-49a3-9209-6a9f132d2f0f"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("6f1d8a61-5b88-4e67-a11f-651b3d09a432"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("734b7def-3aa0-4081-96aa-227aaefd10ba"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("7587c8cc-2cc2-4eb4-8c87-48f540a759e1"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("77d68ed5-b2cb-41a3-84f0-c6d0cbfb11a0"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("7a28c90b-9a2e-4ab6-8255-7c7e6c653685"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("7a92b0cd-7d8d-4ee9-8a82-4f482b4c4a95"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("7b4c1e8d-36a2-42b1-af95-98d36aefb37d"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("7dfe9a0c-2457-4db2-9c59-0f3705dbde44"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("7f6a8e21-8fe1-4f0f-93b9-af14ab0f86c1"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("7f9e65a1-6c4c-4dbb-a3d1-9e1c2b5b35b0"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("8725ff1b-d64d-4f14-b0c1-663c16fdd554"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("8a9d6f1c-5b0e-487e-9c7f-2e01a963e6b7"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("8b9c3aef-6154-4c9d-ae56-7a3df134f71b"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("8d2a5c6f-4e0b-495f-96b8-fd37a1c9e8d6"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("8d60aefa-e6cb-4b90-9e90-0de7d4d01a7b"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("8f5c3a1d-62b9-4b82-9d8f-ace75eab8e7b"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("94bd67a9-3c6a-4d1f-b2b2-0f8915ac5c2a"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("9a1d8e5b-8c0f-4e2a-af0d-7d5f3e6c4b0a"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("9d7f5e6a-20e3-4a57-b529-6d6f104e86c9"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("9e4b6a3d-5e32-4ea7-bff4-34bc47eeef71"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("9e7a2c3b-0b15-4f33-ba7d-8cf9e4a1b5a8"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("9f2ef2e1-15a5-4c93-bbfb-15a95c50d5e8"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("a1f5c6b3-509d-43a8-8d38-745e20d8f48b"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("a41241d1-45ac-4715-8e92-9cbf9f9b3ef7"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("a85e1a45-741c-47b7-8dfb-df7f5e87c76b"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("a8b7c3d6-5e29-4d18-9c7a-e6f85d1c2b4c"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("aab6cbec-dc48-4d4f-a480-137c3e8605c9"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("afe0d8b2-4f44-4821-a6b9-5e1e77d892db"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("b0f7748c-02cf-46e3-9c82-412c284240d1"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("b6e5f66a-db43-4003-a38e-43ce1fbd085f"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("b8a3d6c9-7fe0-4fbb-9b48-f4c11c0d48a7"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("b8c2a1d4-6d8c-42e4-98fe-8c31a26a6a2c"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("c09b1a8d-6922-47d2-8b9c-845c4a3cf79c"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("c17aef02-ad65-4b0c-9a67-95ff2351ca3d"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("c1a5eab4-fcb5-4a76-8447-cbe95f4a4cc4"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("c517b2c7-b756-49a6-9e5f-3b5414a0ee04"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("cf5446f0-7c6b-44fc-8505-a7497ec84e18"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("d0d7aa6e-bcb3-4c14-96f9-0a45e9149a67"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("d0e3a99d-8d16-4a2a-81d6-5a9db9a40b28"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("d1bba8aa-b0d4-42a7-b08f-71b5e7757cb3"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("d1e39c7c-5d2d-42f1-982d-cf6b3f46b9a1"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("d4b8a5c2-c4db-4e3f-aa3f-3d389f5a1aeb"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("d7f7fc67-7e84-4b72-90eb-99ab9a1fe1a8"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("d9c6e8f5-742e-4d8f-a7e6-13d6c9b2a1d5"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("dbbba1f1-e5fc-4f0e-bc4d-263d2cfe9290"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("dd5be212-cda5-44d3-abbc-7782ff8ed14d"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("e2f1a8b3-58e8-4962-a7b8-9e7c3ecb301c"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("e3e9a6a7-6f1c-43bb-b0ac-6f646fa307fd"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("e4bc6462-c946-4903-87ab-861656ebc56a"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("e8a4d6b2-0b4f-4372-8292-665ae7d3f29e"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("f2c4d60a-8e3a-4aa6-b8c6-754497a65a5b"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("f6c2d95e-4d7d-41f2-aa1a-23a40dd8b4b9"),
                columns: new[] { "Phisical_image_name", "Subcategory_Code" },
                values: new object[] { "", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phisical_image_name",
                table: "Subcategories");

            migrationBuilder.DropColumn(
                name: "Subcategory_Code",
                table: "Subcategories");
        }
    }
}
