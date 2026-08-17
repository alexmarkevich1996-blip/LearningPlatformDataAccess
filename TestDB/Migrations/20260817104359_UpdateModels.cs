using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace stepik.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_user_social_providers_users_user_id",
                table: "user_social_providers");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "user_social_providers",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "certificates",
                newName: "Title");

            migrationBuilder.AlterColumn<string>(
                name: "title",
                table: "courses",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "created_date",
                table: "courses",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_user_social_providers_users_UserId",
                table: "user_social_providers",
                column: "UserId",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_user_social_providers_users_UserId",
                table: "user_social_providers");

            migrationBuilder.DropColumn(
                name: "created_date",
                table: "courses");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "user_social_providers",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "certificates",
                newName: "title");

            migrationBuilder.AlterColumn<string>(
                name: "title",
                table: "courses",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_user_social_providers_users_user_id",
                table: "user_social_providers",
                column: "user_id",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
