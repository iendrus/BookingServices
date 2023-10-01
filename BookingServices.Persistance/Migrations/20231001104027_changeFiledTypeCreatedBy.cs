using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingServices.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class changeFiledTypeCreatedBy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Recipients",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Recipients",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Providers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Providers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Products",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Products",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Performers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Performers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Offers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Offers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Industries",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Industries",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Bookings",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Bookings",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedBy" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 688, DateTimeKind.Local).AddTicks(1360), "BobSmith@email.com", null });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedBy" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 688, DateTimeKind.Local).AddTicks(1367), "BobSmith@email.com", null });

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedBy" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 687, DateTimeKind.Local).AddTicks(8917), "BobSmith@email.com", null });

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedBy" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 687, DateTimeKind.Local).AddTicks(8977), "BobSmith@email.com", null });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "EndOfService", "ModifiedBy", "StartOfService" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 688, DateTimeKind.Local).AddTicks(1262), "BobSmith@email.com", new DateTime(2023, 10, 3, 17, 0, 0, 688, DateTimeKind.Local).AddTicks(1255), null, new DateTime(2023, 10, 3, 16, 0, 0, 688, DateTimeKind.Local).AddTicks(1235) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "EndOfService", "ModifiedBy", "StartOfService" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 688, DateTimeKind.Local).AddTicks(1279), "BobSmith@email.com", new DateTime(2023, 10, 4, 15, 0, 0, 688, DateTimeKind.Local).AddTicks(1272), null, new DateTime(2023, 10, 4, 14, 0, 0, 688, DateTimeKind.Local).AddTicks(1266) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "EndOfService", "ModifiedBy", "StartOfService" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 688, DateTimeKind.Local).AddTicks(1297), "BobSmith@email.com", new DateTime(2023, 10, 5, 14, 0, 0, 688, DateTimeKind.Local).AddTicks(1290), null, new DateTime(2023, 10, 5, 13, 0, 0, 688, DateTimeKind.Local).AddTicks(1283) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "EndOfService", "ModifiedBy", "StartOfService" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 688, DateTimeKind.Local).AddTicks(1313), "BobSmith@email.com", new DateTime(2023, 10, 2, 14, 0, 0, 688, DateTimeKind.Local).AddTicks(1306), null, new DateTime(2023, 10, 2, 13, 0, 0, 688, DateTimeKind.Local).AddTicks(1300) });

            migrationBuilder.UpdateData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedBy" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 688, DateTimeKind.Local).AddTicks(646), "BobSmith@email.com", null });

            migrationBuilder.UpdateData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedBy" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 688, DateTimeKind.Local).AddTicks(719), "BobSmith@email.com", null });

            migrationBuilder.UpdateData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedBy" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 688, DateTimeKind.Local).AddTicks(724), "BobSmith@email.com", null });

            migrationBuilder.UpdateData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedBy" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 688, DateTimeKind.Local).AddTicks(728), "BobSmith@email.com", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedBy" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 688, DateTimeKind.Local).AddTicks(175), "BobSmith@email.com", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedBy" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 688, DateTimeKind.Local).AddTicks(188), "BobSmith@email.com", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedBy" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 688, DateTimeKind.Local).AddTicks(191), "BobSmith@email.com", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedBy" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 688, DateTimeKind.Local).AddTicks(195), "BobSmith@email.com", null });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedBy" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 687, DateTimeKind.Local).AddTicks(9354), "BobSmith@email.com", null });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedBy" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 687, DateTimeKind.Local).AddTicks(9363), "BobSmith@email.com", null });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedBy" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 687, DateTimeKind.Local).AddTicks(9366), "BobSmith@email.com", null });

            migrationBuilder.UpdateData(
                table: "Recipients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedBy" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 688, DateTimeKind.Local).AddTicks(244), "BobSmith@email.com", null });

            migrationBuilder.UpdateData(
                table: "Recipients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedBy" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 688, DateTimeKind.Local).AddTicks(250), "BobSmith@email.com", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ModifiedBy",
                table: "Recipients",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "Recipients",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedBy",
                table: "Providers",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "Providers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedBy",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedBy",
                table: "Performers",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "Performers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedBy",
                table: "Offers",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "Offers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedBy",
                table: "Industries",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "Industries",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedBy",
                table: "Bookings",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "Bookings",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedBy" },
                values: new object[] { new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(9932), 1, null });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedBy" },
                values: new object[] { new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(9945), 1, null });

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedBy" },
                values: new object[] { new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(1452), 1, null });

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedBy" },
                values: new object[] { new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(1631), 1, null });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "EndOfService", "ModifiedBy", "StartOfService" },
                values: new object[] { new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(9678), 1, new DateTime(2023, 9, 26, 23, 0, 0, 979, DateTimeKind.Local).AddTicks(9666), null, new DateTime(2023, 9, 26, 22, 0, 0, 979, DateTimeKind.Local).AddTicks(9624) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "EndOfService", "ModifiedBy", "StartOfService" },
                values: new object[] { new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(9712), 1, new DateTime(2023, 9, 27, 21, 0, 0, 979, DateTimeKind.Local).AddTicks(9699), null, new DateTime(2023, 9, 27, 20, 0, 0, 979, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "EndOfService", "ModifiedBy", "StartOfService" },
                values: new object[] { new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(9807), 1, new DateTime(2023, 9, 28, 20, 0, 0, 979, DateTimeKind.Local).AddTicks(9794), null, new DateTime(2023, 9, 28, 19, 0, 0, 979, DateTimeKind.Local).AddTicks(9739) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "EndOfService", "ModifiedBy", "StartOfService" },
                values: new object[] { new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(9840), 1, new DateTime(2023, 9, 25, 20, 0, 0, 979, DateTimeKind.Local).AddTicks(9828), null, new DateTime(2023, 9, 25, 19, 0, 0, 979, DateTimeKind.Local).AddTicks(9814) });

            migrationBuilder.UpdateData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedBy" },
                values: new object[] { new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(8178), 1, null });

            migrationBuilder.UpdateData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedBy" },
                values: new object[] { new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(8202), 1, null });

            migrationBuilder.UpdateData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedBy" },
                values: new object[] { new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(8207), 1, null });

            migrationBuilder.UpdateData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedBy" },
                values: new object[] { new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(8212), 1, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedBy" },
                values: new object[] { new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(6957), 1, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedBy" },
                values: new object[] { new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(7032), 1, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedBy" },
                values: new object[] { new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(7039), 1, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedBy" },
                values: new object[] { new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(7044), 1, null });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedBy" },
                values: new object[] { new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(2654), 1, null });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedBy" },
                values: new object[] { new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(2677), 1, null });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedBy" },
                values: new object[] { new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(2684), 1, null });

            migrationBuilder.UpdateData(
                table: "Recipients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedBy" },
                values: new object[] { new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(7154), 1, null });

            migrationBuilder.UpdateData(
                table: "Recipients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedBy" },
                values: new object[] { new DateTime(2023, 9, 24, 18, 31, 28, 979, DateTimeKind.Local).AddTicks(7178), 1, null });
        }
    }
}
