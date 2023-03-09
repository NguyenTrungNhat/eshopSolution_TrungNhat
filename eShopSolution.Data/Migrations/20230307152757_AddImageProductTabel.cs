using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddImageProductTabel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("1688d3fb-4141-4cdd-9127-670ed67eda0a"),
                column: "ConcurrencyStamp",
                value: "d2d650b4-28bf-460b-9564-378624148ef7");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("7b8209d5-d3bd-4475-a20a-0eb3a8f4ee82"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "78db5014-e72a-4324-8a17-f0c4a0304af8", "AQAAAAEAACcQAAAAEAKjCSxC/ZUFY/tRjBXnOqlfN87O37SXxdMZ9fXKbO2X1VPZBoKYC4iefGRbWtvP2w==" });

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
                value: new DateTime(2023, 3, 7, 22, 27, 57, 116, DateTimeKind.Local).AddTicks(6474));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("1688d3fb-4141-4cdd-9127-670ed67eda0a"),
                column: "ConcurrencyStamp",
                value: "2b2f4802-efec-43ac-9830-2aa662047a1f");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("7b8209d5-d3bd-4475-a20a-0eb3a8f4ee82"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "57089e6c-7541-4338-9a9b-6ddcc8991c1b", "AQAAAAEAACcQAAAAELoyZ2b+fohMqkCRcaNMeRWxPxHswomHxsI+AL12kgqmLWfyVcWu7iKD2+7sVI2Heg==" });

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
                value: new DateTime(2023, 3, 7, 22, 24, 20, 557, DateTimeKind.Local).AddTicks(2560));
        }
    }
}
