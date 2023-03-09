using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class changeFileLenghtType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("1688d3fb-4141-4cdd-9127-670ed67eda0a"),
                column: "ConcurrencyStamp",
                value: "3da624e4-3cfa-494c-b8d1-ea4686193934");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("7b8209d5-d3bd-4475-a20a-0eb3a8f4ee82"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "943e5f0f-8dd1-4ec9-869e-fced3b40d95e", "AQAAAAEAACcQAAAAEMYHjJwzf/tth1C/5TmLMMiZP4bZiwAh0MByhyZiyur1F51YS7OuFcyY/JW0Fd4Cbw==" });

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
                value: new DateTime(2023, 3, 8, 13, 56, 7, 573, DateTimeKind.Local).AddTicks(8718));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

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
    }
}
