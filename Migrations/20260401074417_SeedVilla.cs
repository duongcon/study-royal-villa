using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RoyalVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class SeedVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villa",
                keyColumn: "Id",
                keyValue: "7f55a011-b647-4773-9432-68cb814e3c92");

            migrationBuilder.DeleteData(
                table: "Villa",
                keyColumn: "Id",
                keyValue: "d25c022f-3b66-4481-8b3f-d63c4a1b5f32");

            migrationBuilder.DeleteData(
                table: "Villa",
                keyColumn: "Id",
                keyValue: "fc9dfc3e-2f3a-4018-bcc5-e06ff6717fc5");

            migrationBuilder.DeleteData(
                table: "Villa",
                keyColumn: "Id",
                keyValue: "fd4a4a92-a781-4eda-b7cb-ba4f1b282c1e");

            migrationBuilder.DeleteData(
                table: "Villa",
                keyColumn: "Id",
                keyValue: "ff6807ce-eb84-44b8-8639-b3666f709214");

            migrationBuilder.InsertData(
                table: "Villa",
                columns: new[] { "Id", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { "1", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the Royal Villa", "", "Royal Villa", 4, 200.0, 550, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "2", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the Premium Pool Villa", "", "Premium Pool Villa", 4, 300.0, 550, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "3", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the Luxury Pool Villa", "", "Luxury Pool Villa", 4, 400.0, 750, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "4", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the Diamond Villa", "", "Diamond Villa", 4, 550.0, 900, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "5", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the Diamond Pool Villa", "", "Diamond Pool Villa", 4, 600.0, 1100, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villa",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Villa",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Villa",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Villa",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Villa",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.InsertData(
                table: "Villa",
                columns: new[] { "Id", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { "7f55a011-b647-4773-9432-68cb814e3c92", new DateTime(2026, 4, 1, 2, 42, 19, 145, DateTimeKind.Local).AddTicks(9806), "This is the Diamond Villa", "", "Diamond Villa", 4, 550.0, 900, new DateTime(2026, 4, 1, 2, 42, 19, 145, DateTimeKind.Local).AddTicks(9807) },
                    { "d25c022f-3b66-4481-8b3f-d63c4a1b5f32", new DateTime(2026, 4, 1, 2, 42, 19, 145, DateTimeKind.Local).AddTicks(9811), "This is the Diamond Pool Villa", "", "Diamond Pool Villa", 4, 600.0, 1100, new DateTime(2026, 4, 1, 2, 42, 19, 145, DateTimeKind.Local).AddTicks(9812) },
                    { "fc9dfc3e-2f3a-4018-bcc5-e06ff6717fc5", new DateTime(2026, 4, 1, 2, 42, 19, 143, DateTimeKind.Local).AddTicks(4261), "This is the Royal Villa", "", "Royal Villa", 4, 200.0, 550, new DateTime(2026, 4, 1, 2, 42, 19, 145, DateTimeKind.Local).AddTicks(9156) },
                    { "fd4a4a92-a781-4eda-b7cb-ba4f1b282c1e", new DateTime(2026, 4, 1, 2, 42, 19, 145, DateTimeKind.Local).AddTicks(9795), "This is the Premium Pool Villa", "", "Premium Pool Villa", 4, 300.0, 550, new DateTime(2026, 4, 1, 2, 42, 19, 145, DateTimeKind.Local).AddTicks(9797) },
                    { "ff6807ce-eb84-44b8-8639-b3666f709214", new DateTime(2026, 4, 1, 2, 42, 19, 145, DateTimeKind.Local).AddTicks(9802), "This is the Luxury Pool Villa", "", "Luxury Pool Villa", 4, 400.0, 750, new DateTime(2026, 4, 1, 2, 42, 19, 145, DateTimeKind.Local).AddTicks(9802) }
                });
        }
    }
}
