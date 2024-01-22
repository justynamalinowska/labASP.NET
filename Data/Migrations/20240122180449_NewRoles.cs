using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class NewRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "64f939e4-0f99-4072-b11f-0c4aec228a06", "64f939e4-0f99-4072-b11f-0c4aec228a06", "admin", "ADMIN" },
                    { "76482de6-dbbe-4f2d-8e92-a66ffce7eef3", "76482de6-dbbe-4f2d-8e92-a66ffce7eef3", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b62e442e-af4c-4457-abc2-e12daf4ae069", 0, "38d5f225-82ea-4fc8-8b61-3dcbbd7c2fce", "justyna.malinowska2001@op.pl", true, false, null, "JUSTYNA.MALINOWSKA2001@OP.PL", "JUSTYNA", "AQAAAAEAACcQAAAAEBpGNM2x/50HAyVIKy5QsbaKs6m8AxZqjWa4T3BsojWgF6kkbtFEv5n7IXj32gXRHg==", null, false, "8af08597-566e-4efd-bb8b-da735a02a8c0", false, "justyna" },
                    { "ef391aff-9130-4074-ae0c-22d6ee95883f", 0, "2da1b8c9-fe9d-4aad-afe3-7efbb483b0df", "marek@wsei.pl", true, false, null, "MAREK@WSEI.PL", "MAREK", "AQAAAAEAACcQAAAAEAVCSv6UleNhWc/yUDqpx38WKhJEnKuYNtZFoVK20K5Z53Uq/g01R11ynRGc6AC2mQ==", null, false, "b565dc37-74ec-470e-8d6d-1b59b08d2250", false, "marek" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "64f939e4-0f99-4072-b11f-0c4aec228a06", "b62e442e-af4c-4457-abc2-e12daf4ae069" },
                    { "76482de6-dbbe-4f2d-8e92-a66ffce7eef3", "ef391aff-9130-4074-ae0c-22d6ee95883f" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "64f939e4-0f99-4072-b11f-0c4aec228a06", "b62e442e-af4c-4457-abc2-e12daf4ae069" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "76482de6-dbbe-4f2d-8e92-a66ffce7eef3", "ef391aff-9130-4074-ae0c-22d6ee95883f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64f939e4-0f99-4072-b11f-0c4aec228a06");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76482de6-dbbe-4f2d-8e92-a66ffce7eef3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b62e442e-af4c-4457-abc2-e12daf4ae069");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef391aff-9130-4074-ae0c-22d6ee95883f");

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "65a3a35e-fa46-4519-a98b-0cf4f3eddaed", "26803a35-1830-4203-9eb8-550ad532cf52" },
                    { "65a3a35e-fa46-4519-a98b-0cf4f3eddaed", "a4eca405-6baa-454b-b290-b4f915e815cd" }
                });
        }
    }
}
