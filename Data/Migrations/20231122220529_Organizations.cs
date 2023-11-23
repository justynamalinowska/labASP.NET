using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Organizations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d0d75b61-44d8-41b3-b4d5-2296a17e10e5", "7ba190a4-16e4-4426-af15-87ece1263a11" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0d75b61-44d8-41b3-b4d5-2296a17e10e5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ba190a4-16e4-4426-af15-87ece1263a11");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5657a86c-8c82-41b8-878e-e193040523ad", "5657a86c-8c82-41b8-878e-e193040523ad", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d607179f-964d-4f69-bd3e-94cbc5eb732d", 0, "1e82d056-99a3-41b0-ab36-0d99e9d19bf1", "justyna.malinowska2001@op.pl", true, false, null, "JUSTYNA.MALINOWSKA2001@OP.PL", null, null, null, false, "5e8cedeb-3651-4e11-8f09-7faa995c4515", false, "justyna.malinowska2001@op.pl" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5657a86c-8c82-41b8-878e-e193040523ad", "d607179f-964d-4f69-bd3e-94cbc5eb732d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5657a86c-8c82-41b8-878e-e193040523ad", "d607179f-964d-4f69-bd3e-94cbc5eb732d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5657a86c-8c82-41b8-878e-e193040523ad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d607179f-964d-4f69-bd3e-94cbc5eb732d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d0d75b61-44d8-41b3-b4d5-2296a17e10e5", "d0d75b61-44d8-41b3-b4d5-2296a17e10e5", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7ba190a4-16e4-4426-af15-87ece1263a11", 0, "d24cb608-eecd-4682-bc64-16e0398484c2", "justyna.malinowska2001@op.pl", true, false, null, "JUSTYNA.MALINOWSKA2001@OP.PL", null, null, null, false, "9fb4dd09-8ce7-4080-b86c-1581dce6a8e3", false, "justyna.malinowska2001@op.pl" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d0d75b61-44d8-41b3-b4d5-2296a17e10e5", "7ba190a4-16e4-4426-af15-87ece1263a11" });
        }
    }
}
