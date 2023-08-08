using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingServices.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class _2030808 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 16, 38, 4, 524, DateTimeKind.Local).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "PersonPerformings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 16, 38, 4, 524, DateTimeKind.Local).AddTicks(4895));

            migrationBuilder.UpdateData(
                table: "PersonPerformings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 16, 38, 4, 524, DateTimeKind.Local).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "PersonPerformings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 16, 38, 4, 524, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 16, 38, 4, 524, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 16, 38, 4, 524, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 16, 38, 4, 524, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "ServiceProviders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 16, 38, 4, 524, DateTimeKind.Local).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "ServiceProviders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 16, 38, 4, 524, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "ServiceRecipients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 16, 38, 4, 524, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "ServiceRecipients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 16, 38, 4, 524, DateTimeKind.Local).AddTicks(4415));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 5, 18, 49, 13, 791, DateTimeKind.Local).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "PersonPerformings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 5, 18, 49, 13, 791, DateTimeKind.Local).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "PersonPerformings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 5, 18, 49, 13, 791, DateTimeKind.Local).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "PersonPerformings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 5, 18, 49, 13, 791, DateTimeKind.Local).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 5, 18, 49, 13, 791, DateTimeKind.Local).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 5, 18, 49, 13, 791, DateTimeKind.Local).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 5, 18, 49, 13, 791, DateTimeKind.Local).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "ServiceProviders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 5, 18, 49, 13, 791, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "ServiceProviders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 5, 18, 49, 13, 791, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "ServiceRecipients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 5, 18, 49, 13, 791, DateTimeKind.Local).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "ServiceRecipients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 5, 18, 49, 13, 791, DateTimeKind.Local).AddTicks(5495));
        }
    }
}
