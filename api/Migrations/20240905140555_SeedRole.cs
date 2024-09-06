using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class SeedRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17e40f0d-20e6-493a-b2c8-a18dfa4c2fbb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbb0f4fc-e3f8-424f-9c7b-1c865d9c5f9d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4622260f-281a-4d9a-93bc-bbf9cbb73a4a", null, "User", "USER" },
                    { "ed4e5ec1-04f0-4c09-9a2b-13deb3db5ff0", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4622260f-281a-4d9a-93bc-bbf9cbb73a4a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed4e5ec1-04f0-4c09-9a2b-13deb3db5ff0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "17e40f0d-20e6-493a-b2c8-a18dfa4c2fbb", null, "Admin", "ADMIN" },
                    { "dbb0f4fc-e3f8-424f-9c7b-1c865d9c5f9d", null, "User", "USER" }
                });
        }
    }
}
