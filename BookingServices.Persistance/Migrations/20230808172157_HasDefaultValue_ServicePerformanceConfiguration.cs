using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingServices.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class HasDefaultValue_ServicePerformanceConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsFinished",
                table: "ServicePerformances",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 19, 21, 56, 834, DateTimeKind.Local).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "PersonPerformings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 19, 21, 56, 834, DateTimeKind.Local).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "PersonPerformings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 19, 21, 56, 834, DateTimeKind.Local).AddTicks(9769));

            migrationBuilder.UpdateData(
                table: "PersonPerformings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 19, 21, 56, 834, DateTimeKind.Local).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 19, 21, 56, 834, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 19, 21, 56, 834, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 19, 21, 56, 834, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "ServiceProviders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 19, 21, 56, 834, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "ServiceProviders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 19, 21, 56, 834, DateTimeKind.Local).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "ServiceRecipients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 19, 21, 56, 834, DateTimeKind.Local).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "ServiceRecipients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 19, 21, 56, 834, DateTimeKind.Local).AddTicks(8502));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsFinished",
                table: "ServicePerformances",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 19, 14, 56, 586, DateTimeKind.Local).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "PersonPerformings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 19, 14, 56, 586, DateTimeKind.Local).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "PersonPerformings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 19, 14, 56, 586, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "PersonPerformings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 19, 14, 56, 586, DateTimeKind.Local).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 19, 14, 56, 586, DateTimeKind.Local).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 19, 14, 56, 586, DateTimeKind.Local).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 19, 14, 56, 586, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "ServiceProviders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 19, 14, 56, 586, DateTimeKind.Local).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "ServiceProviders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 19, 14, 56, 586, DateTimeKind.Local).AddTicks(7613));

            migrationBuilder.UpdateData(
                table: "ServiceRecipients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 19, 14, 56, 586, DateTimeKind.Local).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "ServiceRecipients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 19, 14, 56, 586, DateTimeKind.Local).AddTicks(8367));
        }
    }
}
