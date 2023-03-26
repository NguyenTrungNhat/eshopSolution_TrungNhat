using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddImageProductTabel3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 7, 22, 45, 5, 233, DateTimeKind.Local).AddTicks(275),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("1688d3fb-4141-4cdd-9127-670ed67eda0a"),
                column: "ConcurrencyStamp",
                value: "84fa03d5-1678-460a-bbc3-d7541237d1b6");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("7b8209d5-d3bd-4475-a20a-0eb3a8f4ee82"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7a464e02-522b-48e6-b96e-77cbe57ef5d6", "AQAAAAEAACcQAAAAEPKewdI6/8Nl7WFWovT3l+rVAPJu3cK71KFfluK43OXNBwxNVCT/5t/vQ+GQSk/tqQ==" });

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
                value: new DateTime(2023, 3, 7, 22, 45, 5, 255, DateTimeKind.Local).AddTicks(4157));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 3, 7, 22, 45, 5, 233, DateTimeKind.Local).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("1688d3fb-4141-4cdd-9127-670ed67eda0a"),
                column: "ConcurrencyStamp",
                value: "5e0772f9-e289-438a-b4fa-c56f8b422e03");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("7b8209d5-d3bd-4475-a20a-0eb3a8f4ee82"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ec8a32cb-3397-41c0-8058-c4ecaca7d7ab", "AQAAAAEAACcQAAAAEBv8+JrRRwNXCZHeTPwRFhZWXIYboFxKVzsjwRqRXQ7I8Bq6ZMteJOC0r1C/H7mvCg==" });

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
                value: new DateTime(2023, 3, 7, 22, 39, 19, 342, DateTimeKind.Local).AddTicks(6443));
        }
    }
}
