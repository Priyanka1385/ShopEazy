using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopEazy.Server.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2022, 8, 31, 12, 55, 24, 407, DateTimeKind.Local).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2022, 8, 31, 12, 55, 24, 407, DateTimeKind.Local).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "created_at",
                value: new DateTime(2022, 8, 31, 12, 55, 24, 407, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 31, 12, 55, 24, 407, DateTimeKind.Local).AddTicks(6798));

            //migrationBuilder.UpdateData(
            //    table: "Products",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    column: "CreatedAt",
            //    value: new DateTime(2022, 8, 31, 12, 55, 24, 407, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 31, 12, 55, 24, 407, DateTimeKind.Local).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 31, 12, 55, 24, 407, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 31, 12, 55, 24, 407, DateTimeKind.Local).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 31, 12, 55, 24, 407, DateTimeKind.Local).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 31, 12, 55, 24, 407, DateTimeKind.Local).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 31, 12, 55, 24, 407, DateTimeKind.Local).AddTicks(6821));

            //migrationBuilder.UpdateData(
            //    table: "Products",
            //    keyColumn: "Id",
            //    keyValue: 9,
            //    column: "CreatedAt",
            //    value: new DateTime(2022, 8, 31, 12, 55, 24, 407, DateTimeKind.Local).AddTicks(6823));

            //migrationBuilder.UpdateData(
            //    table: "Products",
            //    keyColumn: "Id",
            //    keyValue: 10,
            //    column: "CreatedAt",
            //    value: new DateTime(2022, 8, 31, 12, 55, 24, 407, DateTimeKind.Local).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 31, 12, 55, 24, 407, DateTimeKind.Local).AddTicks(6828));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2022, 8, 30, 18, 57, 17, 582, DateTimeKind.Local).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2022, 8, 30, 18, 57, 17, 582, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "created_at",
                value: new DateTime(2022, 8, 30, 18, 57, 17, 582, DateTimeKind.Local).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 30, 18, 57, 17, 582, DateTimeKind.Local).AddTicks(9572));

            //migrationBuilder.UpdateData(
            //    table: "Products",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    column: "CreatedAt",
            //    value: new DateTime(2022, 8, 30, 18, 57, 17, 582, DateTimeKind.Local).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 30, 18, 57, 17, 582, DateTimeKind.Local).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 30, 18, 57, 17, 582, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 30, 18, 57, 17, 582, DateTimeKind.Local).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 30, 18, 57, 17, 582, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 30, 18, 57, 17, 582, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 30, 18, 57, 17, 582, DateTimeKind.Local).AddTicks(9596));

            //migrationBuilder.UpdateData(
            //    table: "Products",
            //    keyColumn: "Id",
            //    keyValue: 9,
            //    column: "CreatedAt",
            //    value: new DateTime(2022, 8, 30, 18, 57, 17, 582, DateTimeKind.Local).AddTicks(9599));

            //migrationBuilder.UpdateData(
            //    table: "Products",
            //    keyColumn: "Id",
            //    keyValue: 10,
            //    column: "CreatedAt",
            //    value: new DateTime(2022, 8, 30, 18, 57, 17, 582, DateTimeKind.Local).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 30, 18, 57, 17, 582, DateTimeKind.Local).AddTicks(9699));
        }
    }
}
