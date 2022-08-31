using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopEazy.Server.Migrations
{
    public partial class Categories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_Product",
            //    table: "Product");

            //migrationBuilder.RenameTable(
            //    name: "Product",
            //    newName: "Products");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Products",
                type: "bit",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Products",
            //    table: "Products",
            //    column: "Id");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    modified_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "created_at", "Description", "IsActive", "modified_at", "Name", "Url" },
                values: new object[] { 1, new DateTime(2022, 8, 30, 18, 57, 17, 582, DateTimeKind.Local).AddTicks(9357), "Description for Category", true, null, "Books", "books" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "created_at", "Description", "IsActive", "modified_at", "Name", "Url" },
                values: new object[] { 2, new DateTime(2022, 8, 30, 18, 57, 17, 582, DateTimeKind.Local).AddTicks(9372), "Description for Category", true, null, "Movies", "movies" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "created_at", "Description", "IsActive", "modified_at", "Name", "Url" },
                values: new object[] { 3, new DateTime(2022, 8, 30, 18, 57, 17, 582, DateTimeKind.Local).AddTicks(9374), "Description for Category", true, null, "Video Games", "video-games" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedAt", "IsActive" },
                values: new object[] { 1, new DateTime(2022, 8, 30, 18, 57, 17, 582, DateTimeKind.Local).AddTicks(9572), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedAt", "IsActive" },
                values: new object[] { 1, new DateTime(2022, 8, 30, 18, 57, 17, 582, DateTimeKind.Local).AddTicks(9578), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedAt", "IsActive" },
                values: new object[] { 1, new DateTime(2022, 8, 30, 18, 57, 17, 582, DateTimeKind.Local).AddTicks(9581), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedAt", "IsActive" },
                values: new object[] { 2, new DateTime(2022, 8, 30, 18, 57, 17, 582, DateTimeKind.Local).AddTicks(9584), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedAt", "IsActive" },
                values: new object[] { 2, new DateTime(2022, 8, 30, 18, 57, 17, 582, DateTimeKind.Local).AddTicks(9586), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedAt", "IsActive" },
                values: new object[] { 2, new DateTime(2022, 8, 30, 18, 57, 17, 582, DateTimeKind.Local).AddTicks(9590), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedAt", "IsActive" },
                values: new object[] { 3, new DateTime(2022, 8, 30, 18, 57, 17, 582, DateTimeKind.Local).AddTicks(9593), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedAt", "IsActive" },
                values: new object[] { 3, new DateTime(2022, 8, 30, 18, 57, 17, 582, DateTimeKind.Local).AddTicks(9596), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedAt", "IsActive" },
                values: new object[] { 3, new DateTime(2022, 8, 30, 18, 57, 17, 582, DateTimeKind.Local).AddTicks(9599), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedAt", "IsActive" },
                values: new object[] { 3, new DateTime(2022, 8, 30, 18, 57, 17, 582, DateTimeKind.Local).AddTicks(9602), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "CreatedAt", "IsActive" },
                values: new object[] { 3, new DateTime(2022, 8, 30, 18, 57, 17, 582, DateTimeKind.Local).AddTicks(9699), true });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.AlterColumn<byte>(
                name: "IsActive",
                table: "Product",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2022, 8, 29, 16, 59, 13, 110, DateTimeKind.Local).AddTicks(9574), (byte)1 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2022, 8, 29, 16, 59, 13, 110, DateTimeKind.Local).AddTicks(9597), (byte)1 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2022, 8, 29, 16, 59, 13, 110, DateTimeKind.Local).AddTicks(9602), (byte)1 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2022, 8, 29, 16, 59, 13, 110, DateTimeKind.Local).AddTicks(9609), (byte)1 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2022, 8, 29, 16, 59, 13, 110, DateTimeKind.Local).AddTicks(9612), (byte)1 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2022, 8, 29, 16, 59, 13, 110, DateTimeKind.Local).AddTicks(9619), (byte)1 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2022, 8, 29, 16, 59, 13, 110, DateTimeKind.Local).AddTicks(9623), (byte)1 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2022, 8, 29, 16, 59, 13, 110, DateTimeKind.Local).AddTicks(9626), (byte)1 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2022, 8, 29, 16, 59, 13, 110, DateTimeKind.Local).AddTicks(9633), (byte)1 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2022, 8, 29, 16, 59, 13, 110, DateTimeKind.Local).AddTicks(9637), (byte)1 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2022, 8, 29, 16, 59, 13, 110, DateTimeKind.Local).AddTicks(9644), (byte)1 });
        }
    }
}
