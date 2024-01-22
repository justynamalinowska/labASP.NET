using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class addIsFavouriteColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "IsFavourite",
                table: "Products",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4deee73b-6f59-49ac-b3f1-7da0475d9f3e", "4deee73b-6f59-49ac-b3f1-7da0475d9f3e", "user", "USER" },
                    { "65a3a35e-fa46-4519-a98b-0cf4f3eddaed", "65a3a35e-fa46-4519-a98b-0cf4f3eddaed", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "26803a35-1830-4203-9eb8-550ad532cf52", 0, "8944e9c1-91f9-4f04-b088-8c7af6f0dbc4", "justyna.malinowska2001@op.pl", true, false, null, "JUSTYNA.MALINOWSKA2001@OP.PL", "JUSTYNA", "AQAAAAEAACcQAAAAEP2qPoPdsi+TnN4/Wf0FvxBri6CJRFTMlUeqVqt1qNSKRwUsGyEXT3t5BNaT9e66GA==", null, false, "c6937f8d-e257-40f8-b0a4-5503725efded", false, "justyna" },
                    { "a4eca405-6baa-454b-b290-b4f915e815cd", 0, "4bb42eba-f712-4f77-a198-a52519c6a3fe", "marek@wsei.pl", true, false, null, "MAREK@WSEI.PL", "MAREK", "AQAAAAEAACcQAAAAEK7Mmx8aonBdec45OsxPRU+snSNGwNJ9n5r8rYYXaLZZjwB3EPfiNJv9vV6Dh0ywlQ==", null, false, "aa71b611-11f7-4b8e-bef5-ea9b67b03d5f", false, "marek" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsFavourite",
                value: false);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateOfProduction", "Description", "IsFavourite", "Price", "ProducentId", "ProductName", "Quality" },
                values: new object[] { 2, new DateTime(2023, 11, 8, 15, 30, 0, 0, DateTimeKind.Unspecified), "ładny stół", true, 199m, 2, "Table", 4 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "65a3a35e-fa46-4519-a98b-0cf4f3eddaed", "26803a35-1830-4203-9eb8-550ad532cf52" },
                    { "65a3a35e-fa46-4519-a98b-0cf4f3eddaed", "a4eca405-6baa-454b-b290-b4f915e815cd" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4deee73b-6f59-49ac-b3f1-7da0475d9f3e");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "65a3a35e-fa46-4519-a98b-0cf4f3eddaed", "26803a35-1830-4203-9eb8-550ad532cf52" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "65a3a35e-fa46-4519-a98b-0cf4f3eddaed", "a4eca405-6baa-454b-b290-b4f915e815cd" });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65a3a35e-fa46-4519-a98b-0cf4f3eddaed");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26803a35-1830-4203-9eb8-550ad532cf52");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4eca405-6baa-454b-b290-b4f915e815cd");

            migrationBuilder.DropColumn(
                name: "IsFavourite",
                table: "Products");

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
    }
}
