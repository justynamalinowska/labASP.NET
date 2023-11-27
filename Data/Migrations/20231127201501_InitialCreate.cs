using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[,]
                {
                    { "bc6e83ce-a5da-4371-ade8-101b2adb255b", "bc6e83ce-a5da-4371-ade8-101b2adb255b", "user", "USER" },
                    { "bd9abb6e-6593-4517-a6ba-623be5b1deeb", "bd9abb6e-6593-4517-a6ba-623be5b1deeb", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0d3312ec-3dcf-4695-bc16-9490d3a83b57", 0, "4a5efc79-a9b7-46b3-9004-de8716ee4f2f", "marek@wsei.pl", true, false, null, "MAREK@WSEI.PL", "MAREK", "AQAAAAEAACcQAAAAEMLaBTsDZXwXUs53Kck4szA27JIlCWylTPdPFDVqCHsnilRaxH7ltl4yN+NT1/bPFw==", null, false, "d7959c77-5012-4e56-be90-0c682b6979b5", false, "marek" },
                    { "c15189a8-3399-44d2-a95a-33ee82e2f276", 0, "a88ccae0-74b7-4543-8373-1d225252f45c", "justyna.malinowska2001@op.pl", true, false, null, "JUSTYNA.MALINOWSKA2001@OP.PL", "JUSTYNA", "AQAAAAEAACcQAAAAEMWETYzt7Jc9qsKFGWl5fduwkPuz50oGEaKB1f7CBxvaLfWfUGXu9wCZzy8M+WsfmQ==", null, false, "389bc6c1-1ef6-47a6-a0e1-a63234e5a039", false, "justyna" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "bd9abb6e-6593-4517-a6ba-623be5b1deeb", "0d3312ec-3dcf-4695-bc16-9490d3a83b57" },
                    { "bd9abb6e-6593-4517-a6ba-623be5b1deeb", "c15189a8-3399-44d2-a95a-33ee82e2f276" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc6e83ce-a5da-4371-ade8-101b2adb255b");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bd9abb6e-6593-4517-a6ba-623be5b1deeb", "0d3312ec-3dcf-4695-bc16-9490d3a83b57" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bd9abb6e-6593-4517-a6ba-623be5b1deeb", "c15189a8-3399-44d2-a95a-33ee82e2f276" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd9abb6e-6593-4517-a6ba-623be5b1deeb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d3312ec-3dcf-4695-bc16-9490d3a83b57");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c15189a8-3399-44d2-a95a-33ee82e2f276");

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
    }
}
