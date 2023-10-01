using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingServices.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class ChangingFieldType_IsActive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IsActive",
                table: "Recipients",
                type: "int",
                maxLength: 1,
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "IsActive",
                table: "Providers",
                type: "int",
                maxLength: 1,
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "IsActive",
                table: "Products",
                type: "int",
                maxLength: 1,
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "IsActive",
                table: "Performers",
                type: "int",
                maxLength: 1,
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "IsActive",
                table: "Offers",
                type: "int",
                maxLength: 1,
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "IsActive",
                table: "Industries",
                type: "int",
                maxLength: 1,
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "IsActive",
                table: "Bookings",
                type: "int",
                maxLength: 1,
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 35, 249, DateTimeKind.Local).AddTicks(3899), 1 });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 35, 249, DateTimeKind.Local).AddTicks(3905), 1 });

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 35, 249, DateTimeKind.Local).AddTicks(1484), 1 });

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 35, 249, DateTimeKind.Local).AddTicks(1543), 1 });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndOfService", "IsActive", "StartOfService" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 35, 249, DateTimeKind.Local).AddTicks(3808), new DateTime(2023, 10, 3, 22, 0, 0, 249, DateTimeKind.Local).AddTicks(3801), 1, new DateTime(2023, 10, 3, 21, 0, 0, 249, DateTimeKind.Local).AddTicks(3781) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndOfService", "IsActive", "StartOfService" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 35, 249, DateTimeKind.Local).AddTicks(3824), new DateTime(2023, 10, 4, 20, 0, 0, 249, DateTimeKind.Local).AddTicks(3818), 1, new DateTime(2023, 10, 4, 19, 0, 0, 249, DateTimeKind.Local).AddTicks(3812) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndOfService", "IsActive", "StartOfService" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 35, 249, DateTimeKind.Local).AddTicks(3840), new DateTime(2023, 10, 5, 19, 0, 0, 249, DateTimeKind.Local).AddTicks(3834), 1, new DateTime(2023, 10, 5, 18, 0, 0, 249, DateTimeKind.Local).AddTicks(3828) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndOfService", "IsActive", "StartOfService" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 35, 249, DateTimeKind.Local).AddTicks(3856), new DateTime(2023, 10, 2, 19, 0, 0, 249, DateTimeKind.Local).AddTicks(3850), 1, new DateTime(2023, 10, 2, 18, 0, 0, 249, DateTimeKind.Local).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 35, 249, DateTimeKind.Local).AddTicks(3194), 1 });

            migrationBuilder.UpdateData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 35, 249, DateTimeKind.Local).AddTicks(3206), 1 });

            migrationBuilder.UpdateData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 35, 249, DateTimeKind.Local).AddTicks(3210), 1 });

            migrationBuilder.UpdateData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 35, 249, DateTimeKind.Local).AddTicks(3213), 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 35, 249, DateTimeKind.Local).AddTicks(2738), 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 35, 249, DateTimeKind.Local).AddTicks(2751), 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 35, 249, DateTimeKind.Local).AddTicks(2755), 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 35, 249, DateTimeKind.Local).AddTicks(2758), 1 });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 35, 249, DateTimeKind.Local).AddTicks(1921), 1 });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 35, 249, DateTimeKind.Local).AddTicks(1930), 1 });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 35, 249, DateTimeKind.Local).AddTicks(1934), 1 });

            migrationBuilder.UpdateData(
                table: "Recipients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 35, 249, DateTimeKind.Local).AddTicks(2803), 1 });

            migrationBuilder.UpdateData(
                table: "Recipients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 35, 249, DateTimeKind.Local).AddTicks(2810), 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Recipients",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 1,
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Providers",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 1,
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Products",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 1,
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Performers",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 1,
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Offers",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 1,
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Industries",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 1,
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Bookings",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 1,
                oldDefaultValue: 1);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 688, DateTimeKind.Local).AddTicks(1360), 1 });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 688, DateTimeKind.Local).AddTicks(1367), 1 });

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 687, DateTimeKind.Local).AddTicks(8917), 1 });

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 687, DateTimeKind.Local).AddTicks(8977), 1 });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndOfService", "IsActive", "StartOfService" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 688, DateTimeKind.Local).AddTicks(1262), new DateTime(2023, 10, 3, 17, 0, 0, 688, DateTimeKind.Local).AddTicks(1255), 1, new DateTime(2023, 10, 3, 16, 0, 0, 688, DateTimeKind.Local).AddTicks(1235) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndOfService", "IsActive", "StartOfService" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 688, DateTimeKind.Local).AddTicks(1279), new DateTime(2023, 10, 4, 15, 0, 0, 688, DateTimeKind.Local).AddTicks(1272), 1, new DateTime(2023, 10, 4, 14, 0, 0, 688, DateTimeKind.Local).AddTicks(1266) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndOfService", "IsActive", "StartOfService" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 688, DateTimeKind.Local).AddTicks(1297), new DateTime(2023, 10, 5, 14, 0, 0, 688, DateTimeKind.Local).AddTicks(1290), 1, new DateTime(2023, 10, 5, 13, 0, 0, 688, DateTimeKind.Local).AddTicks(1283) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndOfService", "IsActive", "StartOfService" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 688, DateTimeKind.Local).AddTicks(1313), new DateTime(2023, 10, 2, 14, 0, 0, 688, DateTimeKind.Local).AddTicks(1306), 1, new DateTime(2023, 10, 2, 13, 0, 0, 688, DateTimeKind.Local).AddTicks(1300) });

            migrationBuilder.UpdateData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 688, DateTimeKind.Local).AddTicks(646), 1 });

            migrationBuilder.UpdateData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 688, DateTimeKind.Local).AddTicks(719), 1 });

            migrationBuilder.UpdateData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 688, DateTimeKind.Local).AddTicks(724), 1 });

            migrationBuilder.UpdateData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 688, DateTimeKind.Local).AddTicks(728), 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 688, DateTimeKind.Local).AddTicks(175), 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 688, DateTimeKind.Local).AddTicks(188), 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 688, DateTimeKind.Local).AddTicks(191), 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 688, DateTimeKind.Local).AddTicks(195), 1 });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 687, DateTimeKind.Local).AddTicks(9354), 1 });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 687, DateTimeKind.Local).AddTicks(9363), 1 });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 687, DateTimeKind.Local).AddTicks(9366), 1 });

            migrationBuilder.UpdateData(
                table: "Recipients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 688, DateTimeKind.Local).AddTicks(244), 1 });

            migrationBuilder.UpdateData(
                table: "Recipients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2023, 10, 1, 12, 40, 26, 688, DateTimeKind.Local).AddTicks(250), 1 });
        }
    }
}
