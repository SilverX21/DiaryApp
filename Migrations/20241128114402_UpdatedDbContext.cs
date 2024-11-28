using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedDbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "Created", "Title" },
                values: new object[,]
                {
                    { 1, "Went hiking with Joe", new DateTime(2024, 11, 28, 11, 43, 29, 92, DateTimeKind.Local).AddTicks(7770), "Went Hiking" },
                    { 2, "Went shopping with Joe", new DateTime(2024, 11, 28, 11, 43, 29, 92, DateTimeKind.Local).AddTicks(8026), "Went Shopping" },
                    { 3, "Went diving with Joe", new DateTime(2024, 11, 28, 11, 43, 29, 92, DateTimeKind.Local).AddTicks(8029), "Went Diving" }
                });
        }
    }
}
