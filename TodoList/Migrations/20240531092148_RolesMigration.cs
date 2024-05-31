using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TodoList.Migrations
{
    /// <inheritdoc />
    public partial class RolesMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "42651d20-cf2c-498b-b381-9a9012e9c6a3", null, "seller", "seller" },
                    { "46449113-fad6-47c4-91f6-eec80592ec17", null, "admin", "admin" },
                    { "d3c8e54d-4185-4e2d-bd6f-fff9da9d6d2d", null, "client", "client" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42651d20-cf2c-498b-b381-9a9012e9c6a3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46449113-fad6-47c4-91f6-eec80592ec17");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3c8e54d-4185-4e2d-bd6f-fff9da9d6d2d");
        }
    }
}
