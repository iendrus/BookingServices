using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookingServices.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Industries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Industries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceRecipients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email_UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email_DomainName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceRecipients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceProviders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Nip = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Number = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email_UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email_DomainName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndustryId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceProviders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceProviders_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonPerformings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email_UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email_DomainName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ServiceProviderId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonPerformings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonPerformings_ServiceProviders_ServiceProviderId",
                        column: x => x.ServiceProviderId,
                        principalTable: "ServiceProviders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceProviderId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceProducts_ServiceProviders_ServiceProviderId",
                        column: x => x.ServiceProviderId,
                        principalTable: "ServiceProviders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServicePerformances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceRecipientId = table.Column<int>(type: "int", nullable: false),
                    PersonPerformingId = table.Column<int>(type: "int", nullable: false),
                    ServiceProductId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    ServiceRecipientComments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartOfService = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndOfService = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicePerformances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServicePerformances_PersonPerformings_PersonPerformingId",
                        column: x => x.PersonPerformingId,
                        principalTable: "PersonPerformings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServicePerformances_ServiceProducts_ServiceProductId",
                        column: x => x.ServiceProductId,
                        principalTable: "ServiceProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServicePerformances_ServiceRecipients_ServiceRecipientId",
                        column: x => x.ServiceRecipientId,
                        principalTable: "ServiceRecipients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServicePersonPerforming",
                columns: table => new
                {
                    PersonPerformingsId = table.Column<int>(type: "int", nullable: false),
                    ServiceProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicePersonPerforming", x => new { x.PersonPerformingsId, x.ServiceProductsId });
                    table.ForeignKey(
                        name: "FK_ServicePersonPerforming_PersonPerformings_PersonPerformingsId",
                        column: x => x.PersonPerformingsId,
                        principalTable: "PersonPerformings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServicePersonPerforming_ServiceProducts_ServiceProductsId",
                        column: x => x.ServiceProductsId,
                        principalTable: "ServiceProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Industries",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "IsActive", "ModifiedAt", "ModifiedBy", "Name" },
                values: new object[] { 1, new DateTime(2023, 8, 5, 18, 49, 13, 791, DateTimeKind.Local).AddTicks(4237), 1, "Uroda; Styl życia", true, null, null, "Beauty" });

            migrationBuilder.InsertData(
                table: "ServiceRecipients",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "ModifiedAt", "ModifiedBy", "Phone", "Email_DomainName", "Email_UserName", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 5, 18, 49, 13, 791, DateTimeKind.Local).AddTicks(5489), 1, true, null, null, "500500500", "dw.pl", "rob", "Robert", "Laskowski" },
                    { 2, new DateTime(2023, 8, 5, 18, 49, 13, 791, DateTimeKind.Local).AddTicks(5495), 1, true, null, null, "603604605", "pkp.pl", "asiaf", "Joanna", "Ferdel" }
                });

            migrationBuilder.InsertData(
                table: "ServiceProviders",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "IndustryId", "IsActive", "ModifiedAt", "ModifiedBy", "Name", "Nip", "Phone", "FirstName", "LastName", "Email_DomainName", "Email_UserName", "City", "Number", "Street", "ZipCode" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 5, 18, 49, 13, 791, DateTimeKind.Local).AddTicks(4734), 1, null, 1, true, null, null, "Prześwietny Salon Art-Design", null, null, "Bob", "Kaminski", "op.pl", "art-design", "Dulcza", "14", "Miła", "33-220" },
                    { 2, new DateTime(2023, 8, 5, 18, 49, 13, 791, DateTimeKind.Local).AddTicks(4745), 1, null, 1, true, null, null, "Colormix", null, null, "Lukas", "Kolorowy", "wp.pl", "color", "Flismanowa", "234A", null, "32-120" }
                });

            migrationBuilder.InsertData(
                table: "PersonPerformings",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "ModifiedAt", "ModifiedBy", "Phone", "ServiceProviderId", "Email_DomainName", "Email_UserName", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 5, 18, 49, 13, 791, DateTimeKind.Local).AddTicks(5837), 1, true, null, null, "200300400", 2, "op.pl", "kaska", "Kasia", "Łaskawa" },
                    { 2, new DateTime(2023, 8, 5, 18, 49, 13, 791, DateTimeKind.Local).AddTicks(5849), 1, true, null, null, "500666444", 1, "wp.pl", "janko", "Janusz", "Obeznany" },
                    { 3, new DateTime(2023, 8, 5, 18, 49, 13, 791, DateTimeKind.Local).AddTicks(5852), 1, true, null, null, "505606707", 1, "zix.com", "zenobio", "Zenon", "Gruszka" }
                });

            migrationBuilder.InsertData(
                table: "ServiceProducts",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "IsActive", "ModifiedAt", "ModifiedBy", "Name", "ServiceProviderId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 5, 18, 49, 13, 791, DateTimeKind.Local).AddTicks(5436), 1, "Beauty", true, null, null, "Idealny Makeup", 1 },
                    { 2, new DateTime(2023, 8, 5, 18, 49, 13, 791, DateTimeKind.Local).AddTicks(5450), 1, "", true, null, null, "Golenie jak złoto", 1 },
                    { 3, new DateTime(2023, 8, 5, 18, 49, 13, 791, DateTimeKind.Local).AddTicks(5454), 1, "", true, null, null, "Kolor za zeta", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonPerformings_ServiceProviderId",
                table: "PersonPerformings",
                column: "ServiceProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceProducts_ServiceProviderId",
                table: "ServiceProducts",
                column: "ServiceProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_ServicePerformances_PersonPerformingId",
                table: "ServicePerformances",
                column: "PersonPerformingId");

            migrationBuilder.CreateIndex(
                name: "IX_ServicePerformances_ServiceProductId",
                table: "ServicePerformances",
                column: "ServiceProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ServicePerformances_ServiceRecipientId",
                table: "ServicePerformances",
                column: "ServiceRecipientId");

            migrationBuilder.CreateIndex(
                name: "IX_ServicePersonPerforming_ServiceProductsId",
                table: "ServicePersonPerforming",
                column: "ServiceProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceProviders_IndustryId",
                table: "ServiceProviders",
                column: "IndustryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServicePerformances");

            migrationBuilder.DropTable(
                name: "ServicePersonPerforming");

            migrationBuilder.DropTable(
                name: "ServiceRecipients");

            migrationBuilder.DropTable(
                name: "PersonPerformings");

            migrationBuilder.DropTable(
                name: "ServiceProducts");

            migrationBuilder.DropTable(
                name: "ServiceProviders");

            migrationBuilder.DropTable(
                name: "Industries");
        }
    }
}
