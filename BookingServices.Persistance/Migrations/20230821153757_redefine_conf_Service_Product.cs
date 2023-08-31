using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingServices.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class redefine_conf_Service_Product : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ServiceProducts",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 37, 57, 110, DateTimeKind.Local).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 37, 57, 110, DateTimeKind.Local).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "PersonPerformings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 37, 57, 110, DateTimeKind.Local).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "PersonPerformings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 37, 57, 110, DateTimeKind.Local).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "PersonPerformings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 37, 57, 110, DateTimeKind.Local).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "ServiceProducts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 37, 57, 110, DateTimeKind.Local).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "ServiceProducts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 37, 57, 110, DateTimeKind.Local).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "ServiceProducts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 37, 57, 110, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "ServiceProviders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 37, 57, 110, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "ServiceProviders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 37, 57, 110, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "ServiceRecipients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 37, 57, 110, DateTimeKind.Local).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "ServiceRecipients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 37, 57, 110, DateTimeKind.Local).AddTicks(9031));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ServiceProducts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 30, 49, 387, DateTimeKind.Local).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 30, 49, 387, DateTimeKind.Local).AddTicks(4321));

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
    }
}
