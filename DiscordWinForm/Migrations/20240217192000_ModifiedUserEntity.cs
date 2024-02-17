using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedUserEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "tblUsers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "tblUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "tblUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "tblUsers");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "tblUsers");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tblUsers",
                newName: "ID");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "tblUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<string>(
                name: "IP",
                table: "tblUsers",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nickname",
                table: "tblUsers",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "tblUsers",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "tblUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_tblUsers_Username",
                table: "tblUsers",
                column: "Username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_tblUsers_Username",
                table: "tblUsers");

            migrationBuilder.DropColumn(
                name: "IP",
                table: "tblUsers");

            migrationBuilder.DropColumn(
                name: "Nickname",
                table: "tblUsers");

            migrationBuilder.DropColumn(
                name: "Picture",
                table: "tblUsers");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "tblUsers");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "tblUsers",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "tblUsers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "tblUsers",
                type: "datetime2",
                maxLength: 20,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "tblUsers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "tblUsers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "tblUsers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "tblUsers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
