using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Identity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7eced0d6-c0f1-4075-b399-1cff1251afce", "dc104ad3-22be-4729-bc0c-dacda462ec4f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7eced0d6-c0f1-4075-b399-1cff1251afce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc104ad3-22be-4729-bc0c-dacda462ec4f");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "7eced0d6-c0f1-4075-b399-1cff1251afce", "7eced0d6-c0f1-4075-b399-1cff1251afce", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dc104ad3-22be-4729-bc0c-dacda462ec4f", 0, "13953da0-3f5d-4b38-8e5f-6c33cb414568", "justyna.malinowska2001@op.pl", true, false, null, "JUSTYNA.MALINOWSKA2001@OP.PL", null, null, null, false, "cd097dd8-9835-4cad-873c-1efa86cc7dcd", false, "justyna.malinowska2001@op.pl" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7eced0d6-c0f1-4075-b399-1cff1251afce", "dc104ad3-22be-4729-bc0c-dacda462ec4f" });
        }
    }
}
