using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingServices.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class Rename_Product_Class : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 30, 49, 387, DateTimeKind.Local).AddTicks(4257));

            migrationBuilder.InsertData(
                table: "Industries",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "IsActive", "ModifiedAt", "ModifiedBy", "Name" },
                values: new object[] { 2, new DateTime(2023, 8, 21, 17, 30, 49, 387, DateTimeKind.Local).AddTicks(4321), 1, "Rozrywka, zabawa", true, null, null, "Fun" });

            migrationBuilder.UpdateData(
                table: "PersonPerformings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 30, 49, 387, DateTimeKind.Local).AddTicks(5776));

            migrationBuilder.UpdateData(
                table: "PersonPerformings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 30, 49, 387, DateTimeKind.Local).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "PersonPerformings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 30, 49, 387, DateTimeKind.Local).AddTicks(5791));

            migrationBuilder.UpdateData(
                table: "ServiceProducts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 30, 49, 387, DateTimeKind.Local).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "ServiceProducts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 30, 49, 387, DateTimeKind.Local).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "ServiceProducts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 30, 49, 387, DateTimeKind.Local).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "ServiceProviders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 30, 49, 387, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "ServiceProviders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 30, 49, 387, DateTimeKind.Local).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "ServiceRecipients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 30, 49, 387, DateTimeKind.Local).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "ServiceRecipients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 30, 49, 387, DateTimeKind.Local).AddTicks(5437));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 2);

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
                table: "ServiceProducts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 19, 21, 56, 834, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "ServiceProducts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 19, 21, 56, 834, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "ServiceProducts",
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
    }
}
