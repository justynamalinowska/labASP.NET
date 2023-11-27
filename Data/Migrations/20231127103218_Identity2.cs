using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Identity2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b45bcf0f-599f-4409-b765-4ffd841b2c27", "bd637902-9bdb-44f9-bd64-fed1fa954b62" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b45bcf0f-599f-4409-b765-4ffd841b2c27");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd637902-9bdb-44f9-bd64-fed1fa954b62");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "669b7037-89fa-4f4a-a3f3-e7daabb840f3", "669b7037-89fa-4f4a-a3f3-e7daabb840f3", "user", "USER" },
                    { "b8e3ff89-31fb-4e46-aa39-0769e3188c99", "b8e3ff89-31fb-4e46-aa39-0769e3188c99", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "43e5e54f-1375-471a-86e2-924cfb35004c", 0, "6f0e3867-2f5c-47f8-a4b2-d1b0d6243a50", "marek@wsei.pl", true, false, null, "MAREK@WSEI.PL", "MAREK", "AQAAAAEAACcQAAAAELIEYMkWYdogt8Z67aUAwJgyIu8VyTzlq5o72sIjqxs405x6PH/m0yVw9Fb2rVM70w==", null, false, "f4a57976-7a05-4f3b-a1e7-2f1249591bd0", false, "marek" },
                    { "d93db747-5b6c-4e82-ad1f-dd7442c79b90", 0, "b451e861-d190-4147-b330-24d9b784a5b8", "justyna.malinowska2001@op.pl", true, false, null, "JUSTYNA.MALINOWSKA2001@OP.PL", "JUSTYNA", "AQAAAAEAACcQAAAAEPREod3bF725LAdjv79ltuXhzHj2XpbX1GtR3gNM0dhHPtPfaMK2FIr/SX+NSE+JfQ==", null, false, "ec0ac971-ce95-4745-a22e-07e27357ebc3", false, "justyna" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b8e3ff89-31fb-4e46-aa39-0769e3188c99", "43e5e54f-1375-471a-86e2-924cfb35004c" },
                    { "b8e3ff89-31fb-4e46-aa39-0769e3188c99", "d93db747-5b6c-4e82-ad1f-dd7442c79b90" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "669b7037-89fa-4f4a-a3f3-e7daabb840f3");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b8e3ff89-31fb-4e46-aa39-0769e3188c99", "43e5e54f-1375-471a-86e2-924cfb35004c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b8e3ff89-31fb-4e46-aa39-0769e3188c99", "d93db747-5b6c-4e82-ad1f-dd7442c79b90" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8e3ff89-31fb-4e46-aa39-0769e3188c99");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43e5e54f-1375-471a-86e2-924cfb35004c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d93db747-5b6c-4e82-ad1f-dd7442c79b90");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b45bcf0f-599f-4409-b765-4ffd841b2c27", "b45bcf0f-599f-4409-b765-4ffd841b2c27", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bd637902-9bdb-44f9-bd64-fed1fa954b62", 0, "73b0b358-8dd4-4ba4-94cb-731ad17a0d4a", "justyna.malinowska2001@op.pl", true, false, null, "JUSTYNA.MALINOWSKA2001@OP.PL", null, null, null, false, "206dd981-ae90-462e-96fb-28acfd4568a4", false, "justyna.malinowska2001@op.pl" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b45bcf0f-599f-4409-b765-4ffd841b2c27", "bd637902-9bdb-44f9-bd64-fed1fa954b62" });
        }
    }
}
