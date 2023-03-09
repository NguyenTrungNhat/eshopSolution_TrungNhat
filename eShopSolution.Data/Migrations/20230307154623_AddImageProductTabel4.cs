using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddImageProductTabel4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 7, 22, 45, 5, 233, DateTimeKind.Local).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("1688d3fb-4141-4cdd-9127-670ed67eda0a"),
                column: "ConcurrencyStamp",
                value: "fc24afa0-05bc-49b1-a92f-2c29ed376b28");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("7b8209d5-d3bd-4475-a20a-0eb3a8f4ee82"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2f4335e1-17ef-4107-80c6-c5db51d200dc", "AQAAAAEAACcQAAAAEJRtYrk1OV7Iz5BJdw3Ir1Xc4ypgSPtSIlnfGtiQ/YFSnBqxaM94m5PWev+lnPae4A==" });

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
                value: new DateTime(2023, 3, 7, 22, 46, 22, 735, DateTimeKind.Local).AddTicks(3995));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 7, 22, 45, 5, 233, DateTimeKind.Local).AddTicks(275),
                oldClrType: typeof(DateTime));

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
    }
}
