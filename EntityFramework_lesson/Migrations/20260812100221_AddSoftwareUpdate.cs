using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework_lesson.Migrations
{
    /// <inheritdoc />
    public partial class AddSoftwareUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Guarantees");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Phones");

            migrationBuilder.CreateTable(
                name: "SoftwareUpdates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Version = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ReleaseDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    PhoneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoftwareUpdates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SoftwareUpdates_Phones_PhoneId",
                        column: x => x.PhoneId,
                        principalTable: "Phones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_SoftwareUpdates_PhoneId",
                table: "SoftwareUpdates",
                column: "PhoneId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SoftwareUpdates");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Phones",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "Guarantees",
                columns: table => new
                {
                    PhoneId = table.Column<int>(type: "int", nullable: false),
                    Months = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guarantees", x => x.PhoneId);
                    table.ForeignKey(
                        name: "FK_Guarantees_Phones_PhoneId",
                        column: x => x.PhoneId,
                        principalTable: "Phones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
