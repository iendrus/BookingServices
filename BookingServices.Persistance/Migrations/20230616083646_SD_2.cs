using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookingServices.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class SD_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 16, 10, 36, 45, 789, DateTimeKind.Local).AddTicks(5279));

            migrationBuilder.InsertData(
                table: "PersonPerformings",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "ModifiedAt", "ModifiedBy", "Phone", "ServiceProviderId", "Email_DomainName", "Email_UserName", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 16, 10, 36, 45, 789, DateTimeKind.Local).AddTicks(7817), 1, true, null, null, "200300400", 2, "op.pl", "kaska", "Kasia", "Łaskawa" },
                    { 2, new DateTime(2023, 6, 16, 10, 36, 45, 789, DateTimeKind.Local).AddTicks(7847), 1, true, null, null, "500666444", 1, "wp.pl", "janko", "Janusz", "Obeznany" }
                });

            migrationBuilder.UpdateData(
                table: "ServiceProviders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 16, 10, 36, 45, 789, DateTimeKind.Local).AddTicks(5653));

            migrationBuilder.UpdateData(
                table: "ServiceProviders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 16, 10, 36, 45, 789, DateTimeKind.Local).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "ServiceRecipients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email_DomainName" },
                values: new object[] { new DateTime(2023, 6, 16, 10, 36, 45, 789, DateTimeKind.Local).AddTicks(6208), "dw.pl" });

            migrationBuilder.InsertData(
                table: "ServiceRecipients",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "ModifiedAt", "ModifiedBy", "Phone", "Email_DomainName", "Email_UserName", "FirstName", "LastName" },
                values: new object[] { 2, new DateTime(2023, 6, 16, 10, 36, 45, 789, DateTimeKind.Local).AddTicks(6214), 1, true, null, null, "603604605", "pkp.pl", "asiaf", "Joanna", "Ferdel" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 16, 10, 36, 45, 789, DateTimeKind.Local).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 16, 10, 36, 45, 789, DateTimeKind.Local).AddTicks(6174));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PersonPerformings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PersonPerformings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ServiceRecipients",
                keyColumn: "Id",
                keyValue: 2);

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

            migrationBuilder.UpdateData(
                table: "ServiceProviders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 16, 10, 27, 34, 402, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "ServiceRecipients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email_DomainName" },
                values: new object[] { new DateTime(2023, 6, 16, 10, 27, 34, 402, DateTimeKind.Local).AddTicks(1743), "dd.pl" });

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
    }
}
