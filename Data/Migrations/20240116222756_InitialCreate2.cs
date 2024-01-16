using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99bca169-f772-4f05-9416-31cf375da7bd");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d781a77b-32a5-4f05-9a89-8c914eb883ac", "175785c5-22eb-4c81-a975-2362ebc17ab3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d781a77b-32a5-4f05-9a89-8c914eb883ac", "327d0dee-d2b8-46e0-af1f-7ff885de6a93" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d781a77b-32a5-4f05-9a89-8c914eb883ac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "175785c5-22eb-4c81-a975-2362ebc17ab3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "327d0dee-d2b8-46e0-af1f-7ff885de6a93");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7629d37a-ce86-47f8-be09-ec9278a1da79", "7629d37a-ce86-47f8-be09-ec9278a1da79", "admin", "ADMIN" },
                    { "a4bb93c0-57fe-4a92-963d-dd1824cc3934", "a4bb93c0-57fe-4a92-963d-dd1824cc3934", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "950b41cb-9295-4460-ba46-77f88fc54a68", 0, "1272b63b-99fb-4411-a005-6b5c44133cd8", "justyna.malinowska2001@op.pl", true, false, null, "JUSTYNA.MALINOWSKA2001@OP.PL", "JUSTYNA", "AQAAAAEAACcQAAAAEIfkM3YCQAu1Lf8TZyDXwfQjns9/5FO3yquv3HISdrYvr4YsXnOyQXMzg4cwbiJaPQ==", null, false, "a6fe6e98-158d-423f-ba0f-119077d72105", false, "justyna" },
                    { "f9b617bb-0ba5-4877-bf20-cac18bb5ef03", 0, "93dafdf8-b08b-44f5-becf-56a1d116edb0", "marek@wsei.pl", true, false, null, "MAREK@WSEI.PL", "MAREK", "AQAAAAEAACcQAAAAEPjwr8f1FX+2kRBLj8nbgxh3u8LFibTxtQj0Ehw3zIKbeaSD0HN3/HwUCb+kbNDi3A==", null, false, "c2a37602-9d52-4052-b2da-ad2c7222282d", false, "marek" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "7629d37a-ce86-47f8-be09-ec9278a1da79", "950b41cb-9295-4460-ba46-77f88fc54a68" },
                    { "7629d37a-ce86-47f8-be09-ec9278a1da79", "f9b617bb-0ba5-4877-bf20-cac18bb5ef03" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4bb93c0-57fe-4a92-963d-dd1824cc3934");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7629d37a-ce86-47f8-be09-ec9278a1da79", "950b41cb-9295-4460-ba46-77f88fc54a68" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7629d37a-ce86-47f8-be09-ec9278a1da79", "f9b617bb-0ba5-4877-bf20-cac18bb5ef03" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7629d37a-ce86-47f8-be09-ec9278a1da79");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "950b41cb-9295-4460-ba46-77f88fc54a68");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9b617bb-0ba5-4877-bf20-cac18bb5ef03");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "99bca169-f772-4f05-9416-31cf375da7bd", "99bca169-f772-4f05-9416-31cf375da7bd", "user", "USER" },
                    { "d781a77b-32a5-4f05-9a89-8c914eb883ac", "d781a77b-32a5-4f05-9a89-8c914eb883ac", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "175785c5-22eb-4c81-a975-2362ebc17ab3", 0, "2022d920-d0b2-462b-b29a-ffdac8481986", "justyna.malinowska2001@op.pl", true, false, null, "JUSTYNA.MALINOWSKA2001@OP.PL", "JUSTYNA", "AQAAAAEAACcQAAAAEKW2p5uSo2H7m72ba957kt+pVfy39mLoz+dctyFi41VpS95kzYwTzCbS+MLCjqpMdg==", null, false, "9d2f03fe-700d-4f21-9e6d-ced10564f8f7", false, "justyna" },
                    { "327d0dee-d2b8-46e0-af1f-7ff885de6a93", 0, "2e82a122-2fd1-42c2-8deb-79212c3f6944", "marek@wsei.pl", true, false, null, "MAREK@WSEI.PL", "MAREK", "AQAAAAEAACcQAAAAEAKEqgbiFLTxGFfxpfDLz4FFPO/7HsYK7lxMZKPiUyIuL3ohpkCIcJWwYluaFJifBg==", null, false, "0889a015-97bf-41fc-ae80-e114988eadc7", false, "marek" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "d781a77b-32a5-4f05-9a89-8c914eb883ac", "175785c5-22eb-4c81-a975-2362ebc17ab3" },
                    { "d781a77b-32a5-4f05-9a89-8c914eb883ac", "327d0dee-d2b8-46e0-af1f-7ff885de6a93" }
                });
        }
    }
}
