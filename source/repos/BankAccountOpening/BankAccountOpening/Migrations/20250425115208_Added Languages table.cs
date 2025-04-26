using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BankAccountOpening.Migrations
{
    /// <inheritdoc />
    public partial class AddedLanguagestable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BranchName",
                table: "branches",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "languages",
                columns: table => new
                {
                    languageCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    languageName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_languages", x => x.languageCode);
                });

            migrationBuilder.InsertData(
                table: "languages",
                columns: new[] { "languageCode", "languageName" },
                values: new object[,]
                {
                    { 1, "Hindi" },
                    { 2, "Bengali" },
                    { 3, "Telugu" },
                    { 4, "Marathi" },
                    { 5, "Tamil" },
                    { 6, "Urdu" },
                    { 7, "Gujarati" },
                    { 8, "Malayalam" },
                    { 9, "Punjabi" },
                    { 10, "Odia" },
                    { 11, "Kannada" },
                    { 12, "Assamese" },
                    { 13, "Maithili" },
                    { 14, "Santali" },
                    { 15, "Konkani" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "languages");

            migrationBuilder.AlterColumn<string>(
                name: "BranchName",
                table: "branches",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);
        }
    }
}
