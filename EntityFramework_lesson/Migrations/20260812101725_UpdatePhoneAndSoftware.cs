using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework_lesson.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePhoneAndSoftware : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SoftwareUpdates_Phones_PhoneId",
                table: "SoftwareUpdates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SoftwareUpdates",
                table: "SoftwareUpdates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Phones",
                table: "Phones");

            migrationBuilder.RenameTable(
                name: "SoftwareUpdates",
                newName: "software_update");

            migrationBuilder.RenameTable(
                name: "Phones",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Version",
                table: "software_update",
                newName: "version");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "software_update",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ReleaseDate",
                table: "software_update",
                newName: "release_date");

            migrationBuilder.RenameIndex(
                name: "IX_SoftwareUpdates_PhoneId",
                table: "software_update",
                newName: "IX_software_update_PhoneId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "phone",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "phone",
                newName: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_software_update",
                table: "software_update",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_phone",
                table: "phone",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_software_update_phone_PhoneId",
                table: "software_update",
                column: "PhoneId",
                principalTable: "phone",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_software_update_phone_PhoneId",
                table: "software_update");

            migrationBuilder.DropPrimaryKey(
                name: "PK_software_update",
                table: "software_update");

            migrationBuilder.DropPrimaryKey(
                name: "PK_phone",
                table: "phone");

            migrationBuilder.RenameTable(
                name: "software_update",
                newName: "SoftwareUpdates");

            migrationBuilder.RenameTable(
                name: "phone",
                newName: "Phones");

            migrationBuilder.RenameColumn(
                name: "version",
                table: "SoftwareUpdates",
                newName: "Version");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "SoftwareUpdates",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "release_date",
                table: "SoftwareUpdates",
                newName: "ReleaseDate");

            migrationBuilder.RenameIndex(
                name: "IX_software_update_PhoneId",
                table: "SoftwareUpdates",
                newName: "IX_SoftwareUpdates_PhoneId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Phones",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Phones",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SoftwareUpdates",
                table: "SoftwareUpdates",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Phones",
                table: "Phones",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SoftwareUpdates_Phones_PhoneId",
                table: "SoftwareUpdates",
                column: "PhoneId",
                principalTable: "Phones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
