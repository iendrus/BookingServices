using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingServices.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class SD_4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 19, 16, 39, 42, 134, DateTimeKind.Local).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "PersonPerformings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 19, 16, 39, 42, 134, DateTimeKind.Local).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "PersonPerformings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 19, 16, 39, 42, 134, DateTimeKind.Local).AddTicks(2020));

            migrationBuilder.InsertData(
                table: "PersonPerformings",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "ModifiedAt", "ModifiedBy", "Phone", "ServiceProviderId", "Email_DomainName", "Email_UserName", "FirstName", "LastName" },
                values: new object[] { 3, new DateTime(2023, 6, 19, 16, 39, 42, 134, DateTimeKind.Local).AddTicks(2024), 1, true, null, null, "505606707", 1, "zix.com", "zenobio", "Zenon", "Gruszka" });

            migrationBuilder.UpdateData(
                table: "ServiceProviders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 19, 16, 39, 42, 134, DateTimeKind.Local).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "ServiceProviders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 19, 16, 39, 42, 134, DateTimeKind.Local).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "ServiceRecipients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 19, 16, 39, 42, 134, DateTimeKind.Local).AddTicks(1546));

            migrationBuilder.UpdateData(
                table: "ServiceRecipients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 19, 16, 39, 42, 134, DateTimeKind.Local).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 19, 16, 39, 42, 134, DateTimeKind.Local).AddTicks(1495));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 19, 16, 39, 42, 134, DateTimeKind.Local).AddTicks(1507));

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "IsActive", "ModifiedAt", "ModifiedBy", "Name", "ServiceProviderId" },
                values: new object[] { 3, new DateTime(2023, 6, 19, 16, 39, 42, 134, DateTimeKind.Local).AddTicks(1511), 1, "", true, null, null, "Kolor za zeta", 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PersonPerformings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 16, 10, 50, 42, 160, DateTimeKind.Local).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "PersonPerformings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 16, 10, 50, 42, 160, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "PersonPerformings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 16, 10, 50, 42, 161, DateTimeKind.Local).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "ServiceProviders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 16, 10, 50, 42, 160, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "ServiceProviders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 16, 10, 50, 42, 160, DateTimeKind.Local).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "ServiceRecipients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 16, 10, 50, 42, 160, DateTimeKind.Local).AddTicks(9653));

            migrationBuilder.UpdateData(
                table: "ServiceRecipients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 16, 10, 50, 42, 160, DateTimeKind.Local).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 16, 10, 50, 42, 160, DateTimeKind.Local).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 16, 10, 50, 42, 160, DateTimeKind.Local).AddTicks(9617));
        }
    }
}
