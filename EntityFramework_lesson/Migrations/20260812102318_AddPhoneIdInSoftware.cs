using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework_lesson.Migrations
{
    /// <inheritdoc />
    public partial class AddPhoneIdInSoftware : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_software_update_phone_PhoneId",
                table: "software_update");

            migrationBuilder.RenameColumn(
                name: "PhoneId",
                table: "software_update",
                newName: "phone_id");

            migrationBuilder.RenameIndex(
                name: "IX_software_update_PhoneId",
                table: "software_update",
                newName: "IX_software_update_phone_id");

            migrationBuilder.AddForeignKey(
                name: "FK_software_update_phone_phone_id",
                table: "software_update",
                column: "phone_id",
                principalTable: "phone",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_software_update_phone_phone_id",
                table: "software_update");

            migrationBuilder.RenameColumn(
                name: "phone_id",
                table: "software_update",
                newName: "PhoneId");

            migrationBuilder.RenameIndex(
                name: "IX_software_update_phone_id",
                table: "software_update",
                newName: "IX_software_update_PhoneId");

            migrationBuilder.AddForeignKey(
                name: "FK_software_update_phone_PhoneId",
                table: "software_update",
                column: "PhoneId",
                principalTable: "phone",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
