using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework_lesson.Migrations
{
    /// <inheritdoc />
    public partial class AddGuarantees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Phones");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Guarantees");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Phones",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
