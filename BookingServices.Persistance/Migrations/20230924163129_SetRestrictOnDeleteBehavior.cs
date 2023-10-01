using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingServices.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class SetRestrictOnDeleteBehavior : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Offers_OfferId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Recipients_RecipientId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Performers_Providers_ProviderId",
                table: "Performers");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Providers_ProviderId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Providers_Industries_IndustryId",
                table: "Providers");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(1631));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndOfService", "StartOfService" },
                values: new object[] { new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(9678), new DateTime(2023, 9, 26, 23, 0, 0, 979, DateTimeKind.Local).AddTicks(9666), new DateTime(2023, 9, 26, 22, 0, 0, 979, DateTimeKind.Local).AddTicks(9624) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndOfService", "StartOfService" },
                values: new object[] { new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(9712), new DateTime(2023, 9, 27, 21, 0, 0, 979, DateTimeKind.Local).AddTicks(9699), new DateTime(2023, 9, 27, 20, 0, 0, 979, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndOfService", "StartOfService" },
                values: new object[] { new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(9807), new DateTime(2023, 9, 28, 20, 0, 0, 979, DateTimeKind.Local).AddTicks(9794), new DateTime(2023, 9, 28, 19, 0, 0, 979, DateTimeKind.Local).AddTicks(9739) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndOfService", "StartOfService" },
                values: new object[] { new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(9840), new DateTime(2023, 9, 25, 20, 0, 0, 979, DateTimeKind.Local).AddTicks(9828), new DateTime(2023, 9, 25, 19, 0, 0, 979, DateTimeKind.Local).AddTicks(9814) });

            migrationBuilder.UpdateData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "Recipients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "Recipients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(7178));

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Offers_OfferId",
                table: "Bookings",
                column: "OfferId",
                principalTable: "Offers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Recipients_RecipientId",
                table: "Bookings",
                column: "RecipientId",
                principalTable: "Recipients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Performers_Providers_ProviderId",
                table: "Performers",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Providers_ProviderId",
                table: "Products",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Providers_Industries_IndustryId",
                table: "Providers",
                column: "IndustryId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Offers_OfferId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Recipients_RecipientId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Performers_Providers_ProviderId",
                table: "Performers");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Providers_ProviderId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Providers_Industries_IndustryId",
                table: "Providers");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 14, 48, 40, 997, DateTimeKind.Local).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 24, 14, 48, 40, 997, DateTimeKind.Local).AddTicks(9941));

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

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Offers_OfferId",
                table: "Bookings",
                column: "OfferId",
                principalTable: "Offers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Recipients_RecipientId",
                table: "Bookings",
                column: "RecipientId",
                principalTable: "Recipients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Performers_Providers_ProviderId",
                table: "Performers",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Providers_ProviderId",
                table: "Products",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Providers_Industries_IndustryId",
                table: "Providers",
                column: "IndustryId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
