using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddImageProductTabel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(maxLength: 200, nullable: false),
                    Caption = table.Column<string>(maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    FileSize = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("1688d3fb-4141-4cdd-9127-670ed67eda0a"),
                column: "ConcurrencyStamp",
                value: "c9fd3d28-4aee-4b2a-beea-9b6cf907ad4c");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("7b8209d5-d3bd-4475-a20a-0eb3a8f4ee82"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d1f55649-16bf-466d-b04c-91034572777a", "AQAAAAEAACcQAAAAEBzhH1vu90v8XVm0zOwCmEhvAIcrQwQ4kWQWT6TFZC3QSkv1zEH/0HP/tkS4CigWMA==" });

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
                value: new DateTime(2023, 3, 7, 22, 36, 56, 38, DateTimeKind.Local).AddTicks(384));
        }
    }
}
