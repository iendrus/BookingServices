using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingServices.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class SD_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 16, 10, 27, 34, 402, DateTimeKind.Local).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "ServiceProviders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 16, 10, 27, 34, 402, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.InsertData(
                table: "ServiceProviders",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "IndustryId", "IsActive", "ModifiedAt", "ModifiedBy", "Name", "Nip", "Phone", "FirstName", "LastName", "Email_DomainName", "Email_UserName" },
                values: new object[] { 2, new DateTime(2023, 6, 16, 10, 27, 34, 402, DateTimeKind.Local).AddTicks(1272), 1, null, 1, true, null, null, "Colormix", null, null, "Lukas", "Kolorowy", "wp.pl", "color" });

            migrationBuilder.InsertData(
                table: "ServiceRecipients",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "ModifiedAt", "ModifiedBy", "Phone", "Email_DomainName", "Email_UserName", "FirstName", "LastName" },
                values: new object[] { 1, new DateTime(2023, 6, 16, 10, 27, 34, 402, DateTimeKind.Local).AddTicks(1743), 1, true, null, null, "500500500", "dd.pl", "rob", "Robert", "Laskowski" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 16, 10, 27, 34, 402, DateTimeKind.Local).AddTicks(1696));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 16, 10, 27, 34, 402, DateTimeKind.Local).AddTicks(1707));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ServiceProviders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ServiceRecipients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 16, 9, 24, 39, 694, DateTimeKind.Local).AddTicks(3143));

            migrationBuilder.UpdateData(
                table: "ServiceProviders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 16, 9, 24, 39, 694, DateTimeKind.Local).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 16, 9, 24, 39, 694, DateTimeKind.Local).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 16, 9, 24, 39, 694, DateTimeKind.Local).AddTicks(4093));
        }
    }
}
