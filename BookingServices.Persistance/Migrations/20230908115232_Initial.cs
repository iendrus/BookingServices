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
                name: "Recipients",
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
                    table.PrimaryKey("PK_Recipients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Providers",
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
                    table.PrimaryKey("PK_Providers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Providers_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Performers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email_UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email_DomainName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ProviderId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Performers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Performers_Providers_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Providers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Providers_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Providers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PerformerId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(9,2)", precision: 9, scale: 2, nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
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
                    table.PrimaryKey("PK_Offers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Offers_Performers_PerformerId",
                        column: x => x.PerformerId,
                        principalTable: "Performers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Offers_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductPerformers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    PerformerId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPerformers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductPerformers_Performers_PerformerId",
                        column: x => x.PerformerId,
                        principalTable: "Performers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductPerformers_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OfferId = table.Column<int>(type: "int", nullable: false),
                    PerformerId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    RecipientId = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(9,2)", precision: 9, scale: 2, nullable: false),
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
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Offers_OfferId",
                        column: x => x.OfferId,
                        principalTable: "Offers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bookings_Performers_PerformerId",
                        column: x => x.PerformerId,
                        principalTable: "Performers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bookings_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bookings_Recipients_RecipientId",
                        column: x => x.RecipientId,
                        principalTable: "Recipients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Industries",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "IsActive", "ModifiedAt", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 8, 13, 52, 32, 446, DateTimeKind.Local).AddTicks(4609), 1, "Uroda; Styl życia", true, null, null, "Beauty" },
                    { 2, new DateTime(2023, 9, 8, 13, 52, 32, 446, DateTimeKind.Local).AddTicks(4669), 1, "Rozrywka, zabawa", true, null, null, "Fun" }
                });

            migrationBuilder.InsertData(
                table: "Recipients",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "ModifiedAt", "ModifiedBy", "Phone", "Email_DomainName", "Email_UserName", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 8, 13, 52, 32, 446, DateTimeKind.Local).AddTicks(5807), 1, true, null, null, "500500500", "dw.pl", "rob", "Robert", "Laskowski" },
                    { 2, new DateTime(2023, 9, 8, 13, 52, 32, 446, DateTimeKind.Local).AddTicks(5813), 1, true, null, null, "603604605", "pkp.pl", "asiaf", "Joanna", "Ferdel" }
                });

            migrationBuilder.InsertData(
                table: "Providers",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "IndustryId", "IsActive", "ModifiedAt", "ModifiedBy", "Name", "Nip", "Phone", "FirstName", "LastName", "Email_DomainName", "Email_UserName", "City", "Number", "Street", "ZipCode" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 8, 13, 52, 32, 446, DateTimeKind.Local).AddTicks(5069), 1, null, 1, true, null, null, "Prześwietny Salon Art-Design", null, null, "Bob", "Kaminski", "op.pl", "art-design", "Dulcza", "14", "Miła", "33-220" },
                    { 2, new DateTime(2023, 9, 8, 13, 52, 32, 446, DateTimeKind.Local).AddTicks(5078), 1, null, 1, true, null, null, "Colormix", null, null, "Lukas", "Kolorowy", "wp.pl", "color", "Flismanowa", "234A", null, "32-120" }
                });

            migrationBuilder.InsertData(
                table: "Performers",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "ModifiedAt", "ModifiedBy", "Phone", "ProviderId", "Email_DomainName", "Email_UserName", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 8, 13, 52, 32, 446, DateTimeKind.Local).AddTicks(6245), 1, true, null, null, "200300400", 2, "op.pl", "kaska", "Kasia", "Łaskawa" },
                    { 2, new DateTime(2023, 9, 8, 13, 52, 32, 446, DateTimeKind.Local).AddTicks(6259), 1, true, null, null, "500666444", 1, "wp.pl", "janko", "Janusz", "Obeznany" },
                    { 3, new DateTime(2023, 9, 8, 13, 52, 32, 446, DateTimeKind.Local).AddTicks(6263), 1, true, null, null, "505606707", 1, "zix.com", "zenobio", "Zenon", "Gruszka" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "IsActive", "ModifiedAt", "ModifiedBy", "Name", "ProviderId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 8, 13, 52, 32, 446, DateTimeKind.Local).AddTicks(5749), 1, "Beauty", true, null, null, "Idealny Makeup", 1 },
                    { 2, new DateTime(2023, 9, 8, 13, 52, 32, 446, DateTimeKind.Local).AddTicks(5763), 1, "", true, null, null, "Golenie jak złoto", 1 },
                    { 3, new DateTime(2023, 9, 8, 13, 52, 32, 446, DateTimeKind.Local).AddTicks(5767), 1, "", true, null, null, "Kolor za zeta", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_OfferId",
                table: "Bookings",
                column: "OfferId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_PerformerId",
                table: "Bookings",
                column: "PerformerId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_ProductId",
                table: "Bookings",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_RecipientId",
                table: "Bookings",
                column: "RecipientId");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_PerformerId",
                table: "Offers",
                column: "PerformerId");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_ProductId",
                table: "Offers",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Performers_ProviderId",
                table: "Performers",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPerformers_PerformerId",
                table: "ProductPerformers",
                column: "PerformerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPerformers_ProductId",
                table: "ProductPerformers",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProviderId",
                table: "Products",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_Providers_IndustryId",
                table: "Providers",
                column: "IndustryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "ProductPerformers");

            migrationBuilder.DropTable(
                name: "Offers");

            migrationBuilder.DropTable(
                name: "Recipients");

            migrationBuilder.DropTable(
                name: "Performers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Providers");

            migrationBuilder.DropTable(
                name: "Industries");
        }
    }
}
