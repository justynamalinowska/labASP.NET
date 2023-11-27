using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Producents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Location_ProducentId",
                table: "Producents");

            migrationBuilder.DropColumn(
                name: "Address_ContactId",
                table: "Organizations");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Location_ProducentId",
                table: "Producents",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Address_ContactId",
                table: "Organizations",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5657a86c-8c82-41b8-878e-e193040523ad", "5657a86c-8c82-41b8-878e-e193040523ad", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d607179f-964d-4f69-bd3e-94cbc5eb732d", 0, "1e82d056-99a3-41b0-ab36-0d99e9d19bf1", "justyna.malinowska2001@op.pl", true, false, null, "JUSTYNA.MALINOWSKA2001@OP.PL", null, null, null, false, "5e8cedeb-3651-4e11-8f09-7faa995c4515", false, "justyna.malinowska2001@op.pl" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Address_ContactId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Address_ContactId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Producents",
                keyColumn: "Id",
                keyValue: 1,
                column: "Location_ProducentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Producents",
                keyColumn: "Id",
                keyValue: 2,
                column: "Location_ProducentId",
                value: null);

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5657a86c-8c82-41b8-878e-e193040523ad", "d607179f-964d-4f69-bd3e-94cbc5eb732d" });
        }
    }
}
