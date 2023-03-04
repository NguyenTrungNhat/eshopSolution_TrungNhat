using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 4, 16, 15, 47, 770, DateTimeKind.Local).AddTicks(7527),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 4, 16, 1, 49, 501, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.InsertData(
                table: "AppRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("1688d3fb-4141-4cdd-9127-670ed67eda0a"), "1144852d-4e92-4f64-8982-0dba705e778a", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("7b8209d5-d3bd-4475-a20a-0eb3a8f4ee82"), new Guid("1688d3fb-4141-4cdd-9127-670ed67eda0a") });

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirsName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("7b8209d5-d3bd-4475-a20a-0eb3a8f4ee82"), 0, "61e791b6-4e49-411a-9e62-090681849dc8", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "nhatnguyen20102002@gmail.com", true, "Nguyen", "Nhat", false, null, "nhatnguyen20102002@gmail.com", "admin", "AQAAAAEAACcQAAAAEKE+Ewzvs8SyXe+vGANgLDHAxCIqNEgtTeRKac1waH+ClVYNe/v+VLiIbhZoUmK2Bw==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 3, 4, 16, 15, 47, 792, DateTimeKind.Local).AddTicks(7369));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("1688d3fb-4141-4cdd-9127-670ed67eda0a"));

            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("7b8209d5-d3bd-4475-a20a-0eb3a8f4ee82"), new Guid("1688d3fb-4141-4cdd-9127-670ed67eda0a") });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("7b8209d5-d3bd-4475-a20a-0eb3a8f4ee82"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 4, 16, 1, 49, 501, DateTimeKind.Local).AddTicks(3380),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 3, 4, 16, 15, 47, 770, DateTimeKind.Local).AddTicks(7527));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 3, 4, 16, 1, 49, 519, DateTimeKind.Local).AddTicks(1966));
        }
    }
}
