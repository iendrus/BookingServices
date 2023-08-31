using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingServices.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class changes_to_the_Entity_ServicePerformance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "ServicePerformances");

            migrationBuilder.AddColumn<bool>(
                name: "IsFinished",
                table: "ServicePerformances",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
                table: "ServiceProducts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 19, 14, 56, 586, DateTimeKind.Local).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "ServiceProducts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 19, 14, 56, 586, DateTimeKind.Local).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "ServiceProducts",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFinished",
                table: "ServicePerformances");

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "ServicePerformances",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                table: "ServiceProducts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 16, 38, 4, 524, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "ServiceProducts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 8, 16, 38, 4, 524, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "ServiceProducts",
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
    }
}
