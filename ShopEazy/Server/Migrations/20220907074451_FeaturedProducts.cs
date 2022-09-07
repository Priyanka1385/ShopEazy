using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopEazy.Server.Migrations
{
    public partial class FeaturedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.AddColumn<bool>(
                name: "Featured",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2022, 9, 7, 13, 14, 50, 277, DateTimeKind.Local).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2022, 9, 7, 13, 14, 50, 277, DateTimeKind.Local).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "created_at",
                value: new DateTime(2022, 9, 7, 13, 14, 50, 277, DateTimeKind.Local).AddTicks(5234));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Featured" },
                values: new object[] { new DateTime(2022, 9, 7, 13, 14, 50, 277, DateTimeKind.Local).AddTicks(5423), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 13, 14, 50, 277, DateTimeKind.Local).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 13, 14, 50, 277, DateTimeKind.Local).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 13, 14, 50, 277, DateTimeKind.Local).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Featured" },
                values: new object[] { new DateTime(2022, 9, 7, 13, 14, 50, 277, DateTimeKind.Local).AddTicks(5451), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 13, 14, 50, 277, DateTimeKind.Local).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 13, 14, 50, 277, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 13, 14, 50, 277, DateTimeKind.Local).AddTicks(5465));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Featured" },
                values: new object[] { new DateTime(2022, 9, 7, 13, 14, 50, 277, DateTimeKind.Local).AddTicks(5470), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 13, 14, 50, 277, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 13, 14, 50, 277, DateTimeKind.Local).AddTicks(5477));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Featured",
                table: "Products");

           

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2022, 9, 6, 11, 34, 43, 792, DateTimeKind.Local).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2022, 9, 6, 11, 34, 43, 792, DateTimeKind.Local).AddTicks(3138));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "created_at",
                value: new DateTime(2022, 9, 6, 11, 34, 43, 792, DateTimeKind.Local).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 6, 11, 34, 43, 792, DateTimeKind.Local).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 6, 11, 34, 43, 792, DateTimeKind.Local).AddTicks(3171));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 6, 11, 34, 43, 792, DateTimeKind.Local).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 6, 11, 34, 43, 792, DateTimeKind.Local).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 6, 11, 34, 43, 792, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 6, 11, 34, 43, 792, DateTimeKind.Local).AddTicks(3183));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 6, 11, 34, 43, 792, DateTimeKind.Local).AddTicks(3186));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 6, 11, 34, 43, 792, DateTimeKind.Local).AddTicks(3188));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 6, 11, 34, 43, 792, DateTimeKind.Local).AddTicks(3191));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 6, 11, 34, 43, 792, DateTimeKind.Local).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 6, 11, 34, 43, 792, DateTimeKind.Local).AddTicks(3195));
        }
    }
}
