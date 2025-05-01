using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankAccountOpening.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedUsersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "states",
                keyColumn: "StateId",
                keyValue: 30);

            migrationBuilder.DropColumn(
                name: "BranchName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Users",
                newName: "CreatedTime");

            migrationBuilder.AlterColumn<int>(
                name: "PrefferedLanguage",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BranchCode",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CityCode",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "StateCode",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "languages",
                columns: new[] { "languageCode", "languageName" },
                values: new object[] { 16, "English" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "languageCode",
                keyValue: 16);

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BranchCode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CityCode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "StateCode",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "CreatedTime",
                table: "Users",
                newName: "State");

            migrationBuilder.AlterColumn<string>(
                name: "PrefferedLanguage",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "BranchName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "states",
                columns: new[] { "StateId", "StateName" },
                values: new object[] { 30, "Chandigarh" });
        }
    }
}
