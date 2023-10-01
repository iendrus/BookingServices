using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingServices.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class Seed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Cost", "CreatedAt" },
                values: new object[] { 150m, new DateTime(2023, 9, 24, 14, 48, 40, 997, DateTimeKind.Local).AddTicks(9936) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Cost", "CreatedAt", "State" },
                values: new object[] { 100m, new DateTime(2023, 9, 24, 14, 48, 40, 997, DateTimeKind.Local).AddTicks(9941), 1 });

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 14, 48, 40, 997, DateTimeKind.Local).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 14, 48, 40, 997, DateTimeKind.Local).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndOfService", "StartOfService" },
                values: new object[] { new DateTime(2023, 9, 24, 14, 48, 40, 997, DateTimeKind.Local).AddTicks(9842), new DateTime(2023, 9, 26, 19, 0, 0, 997, DateTimeKind.Local).AddTicks(9835), new DateTime(2023, 9, 26, 18, 0, 0, 997, DateTimeKind.Local).AddTicks(9816) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndOfService", "StartOfService" },
                values: new object[] { new DateTime(2023, 9, 24, 14, 48, 40, 997, DateTimeKind.Local).AddTicks(9858), new DateTime(2023, 9, 27, 17, 0, 0, 997, DateTimeKind.Local).AddTicks(9852), new DateTime(2023, 9, 27, 16, 0, 0, 997, DateTimeKind.Local).AddTicks(9846) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndOfService", "StartOfService" },
                values: new object[] { new DateTime(2023, 9, 24, 14, 48, 40, 997, DateTimeKind.Local).AddTicks(9874), new DateTime(2023, 9, 28, 16, 0, 0, 997, DateTimeKind.Local).AddTicks(9868), new DateTime(2023, 9, 28, 15, 0, 0, 997, DateTimeKind.Local).AddTicks(9862) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndOfService", "StartOfService" },
                values: new object[] { new DateTime(2023, 9, 24, 14, 48, 40, 997, DateTimeKind.Local).AddTicks(9890), new DateTime(2023, 9, 25, 16, 0, 0, 997, DateTimeKind.Local).AddTicks(9884), new DateTime(2023, 9, 25, 15, 0, 0, 997, DateTimeKind.Local).AddTicks(9878) });

            migrationBuilder.UpdateData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 14, 48, 40, 997, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 14, 48, 40, 997, DateTimeKind.Local).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 14, 48, 40, 997, DateTimeKind.Local).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 14, 48, 40, 997, DateTimeKind.Local).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 14, 48, 40, 997, DateTimeKind.Local).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 14, 48, 40, 997, DateTimeKind.Local).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 14, 48, 40, 997, DateTimeKind.Local).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 14, 48, 40, 997, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 14, 48, 40, 997, DateTimeKind.Local).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 14, 48, 40, 997, DateTimeKind.Local).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 14, 48, 40, 997, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "Recipients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 14, 48, 40, 997, DateTimeKind.Local).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "Recipients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 14, 48, 40, 997, DateTimeKind.Local).AddTicks(8823));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Cost", "CreatedAt" },
                values: new object[] { 0m, new DateTime(2023, 9, 24, 14, 44, 11, 652, DateTimeKind.Local).AddTicks(368) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Cost", "CreatedAt", "State" },
                values: new object[] { 0m, new DateTime(2023, 9, 24, 14, 44, 11, 652, DateTimeKind.Local).AddTicks(374), 0 });

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

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndOfService", "StartOfService" },
                values: new object[] { new DateTime(2023, 9, 24, 14, 44, 11, 652, DateTimeKind.Local).AddTicks(273), new DateTime(2023, 9, 26, 19, 0, 0, 652, DateTimeKind.Local).AddTicks(265), new DateTime(2023, 9, 26, 18, 0, 0, 652, DateTimeKind.Local).AddTicks(245) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndOfService", "StartOfService" },
                values: new object[] { new DateTime(2023, 9, 24, 14, 44, 11, 652, DateTimeKind.Local).AddTicks(290), new DateTime(2023, 9, 27, 17, 0, 0, 652, DateTimeKind.Local).AddTicks(284), new DateTime(2023, 9, 27, 16, 0, 0, 652, DateTimeKind.Local).AddTicks(277) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndOfService", "StartOfService" },
                values: new object[] { new DateTime(2023, 9, 24, 14, 44, 11, 652, DateTimeKind.Local).AddTicks(306), new DateTime(2023, 9, 28, 16, 0, 0, 652, DateTimeKind.Local).AddTicks(299), new DateTime(2023, 9, 28, 15, 0, 0, 652, DateTimeKind.Local).AddTicks(293) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndOfService", "StartOfService" },
                values: new object[] { new DateTime(2023, 9, 24, 14, 44, 11, 652, DateTimeKind.Local).AddTicks(322), new DateTime(2023, 9, 25, 16, 0, 0, 652, DateTimeKind.Local).AddTicks(316), new DateTime(2023, 9, 25, 15, 0, 0, 652, DateTimeKind.Local).AddTicks(309) });

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
        }
    }
}
