using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookingServices.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 14, 44, 11, 651, DateTimeKind.Local).AddTicks(7893));

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 14, 44, 11, 651, DateTimeKind.Local).AddTicks(7954));

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "Cost", "CreatedAt", "CreatedBy", "EndOfService", "IsActive", "IsAvailable", "ModifiedAt", "ModifiedBy", "PerformerId", "ProductId", "StartOfService" },
                values: new object[,]
                {
                    { 1, 150m, new DateTime(2023, 9, 24, 14, 44, 11, 652, DateTimeKind.Local).AddTicks(273), 1, new DateTime(2023, 9, 26, 19, 0, 0, 652, DateTimeKind.Local).AddTicks(265), true, true, null, null, 1, 3, new DateTime(2023, 9, 26, 18, 0, 0, 652, DateTimeKind.Local).AddTicks(245) },
                    { 2, 100m, new DateTime(2023, 9, 24, 14, 44, 11, 652, DateTimeKind.Local).AddTicks(290), 1, new DateTime(2023, 9, 27, 17, 0, 0, 652, DateTimeKind.Local).AddTicks(284), true, true, null, null, 2, 1, new DateTime(2023, 9, 27, 16, 0, 0, 652, DateTimeKind.Local).AddTicks(277) },
                    { 3, 200m, new DateTime(2023, 9, 24, 14, 44, 11, 652, DateTimeKind.Local).AddTicks(306), 1, new DateTime(2023, 9, 28, 16, 0, 0, 652, DateTimeKind.Local).AddTicks(299), true, true, null, null, 4, 4, new DateTime(2023, 9, 28, 15, 0, 0, 652, DateTimeKind.Local).AddTicks(293) },
                    { 5, 60m, new DateTime(2023, 9, 24, 14, 44, 11, 652, DateTimeKind.Local).AddTicks(322), 1, new DateTime(2023, 9, 25, 16, 0, 0, 652, DateTimeKind.Local).AddTicks(316), true, true, null, null, 3, 2, new DateTime(2023, 9, 25, 15, 0, 0, 652, DateTimeKind.Local).AddTicks(309) }
                });

            migrationBuilder.UpdateData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 14, 44, 11, 651, DateTimeKind.Local).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 14, 44, 11, 651, DateTimeKind.Local).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 14, 44, 11, 651, DateTimeKind.Local).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 14, 44, 11, 651, DateTimeKind.Local).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 14, 44, 11, 651, DateTimeKind.Local).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 14, 44, 11, 651, DateTimeKind.Local).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 14, 44, 11, 651, DateTimeKind.Local).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 14, 44, 11, 651, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 14, 44, 11, 651, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 14, 44, 11, 651, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 14, 44, 11, 651, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "Recipients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 14, 44, 11, 651, DateTimeKind.Local).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "Recipients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 14, 44, 11, 651, DateTimeKind.Local).AddTicks(9286));

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "Cost", "CreatedAt", "CreatedBy", "IsActive", "ModifiedAt", "ModifiedBy", "OfferId", "RecipientId", "State" },
                values: new object[,]
                {
                    { 1, 0m, new DateTime(2023, 9, 24, 14, 44, 11, 652, DateTimeKind.Local).AddTicks(368), 1, true, null, null, 1, 2, 0 },
                    { 2, 0m, new DateTime(2023, 9, 24, 14, 44, 11, 652, DateTimeKind.Local).AddTicks(374), 1, true, null, null, 2, 1, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 13, 58, 58, 630, DateTimeKind.Local).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 13, 58, 58, 630, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 13, 58, 58, 630, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 13, 58, 58, 630, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 13, 58, 58, 630, DateTimeKind.Local).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 13, 58, 58, 630, DateTimeKind.Local).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 13, 58, 58, 630, DateTimeKind.Local).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 13, 58, 58, 630, DateTimeKind.Local).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 13, 58, 58, 630, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 13, 58, 58, 630, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 13, 58, 58, 630, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 13, 58, 58, 630, DateTimeKind.Local).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 13, 58, 58, 630, DateTimeKind.Local).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "Recipients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 13, 58, 58, 630, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "Recipients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 13, 58, 58, 630, DateTimeKind.Local).AddTicks(6576));
        }
    }
}
