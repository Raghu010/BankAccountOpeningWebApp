using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BankAccountOpening.Migrations
{
    /// <inheritdoc />
    public partial class AddedBranchtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "branches",
                columns: table => new
                {
                    BranchCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchCityCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_branches", x => x.BranchCode);
                });

            migrationBuilder.InsertData(
                table: "branches",
                columns: new[] { "BranchCode", "BranchCityCode", "BranchName" },
                values: new object[,]
                {
                    { 1, 2, "Branch 1" },
                    { 2, 3, "Branch 2" },
                    { 3, 4, "Branch 3" },
                    { 4, 5, "Branch 4" },
                    { 5, 6, "Branch 5" },
                    { 6, 7, "Branch 6" },
                    { 7, 8, "Branch 7" },
                    { 8, 9, "Branch 8" },
                    { 9, 10, "Branch 9" },
                    { 10, 11, "Branch 10" },
                    { 11, 12, "Branch 11" },
                    { 12, 13, "Branch 12" },
                    { 13, 14, "Branch 13" },
                    { 14, 15, "Branch 14" },
                    { 15, 16, "Branch 15" },
                    { 16, 17, "Branch 16" },
                    { 17, 18, "Branch 17" },
                    { 18, 19, "Branch 18" },
                    { 19, 20, "Branch 19" },
                    { 20, 21, "Branch 20" },
                    { 21, 22, "Branch 21" },
                    { 22, 23, "Branch 22" },
                    { 23, 24, "Branch 23" },
                    { 24, 25, "Branch 24" },
                    { 25, 26, "Branch 25" },
                    { 26, 27, "Branch 26" },
                    { 27, 28, "Branch 27" },
                    { 28, 29, "Branch 28" },
                    { 29, 30, "Branch 29" },
                    { 30, 31, "Branch 30" },
                    { 31, 32, "Branch 31" },
                    { 32, 33, "Branch 32" },
                    { 33, 34, "Branch 33" },
                    { 34, 35, "Branch 34" },
                    { 35, 36, "Branch 35" },
                    { 36, 1, "Branch 36" },
                    { 37, 2, "Branch 37" },
                    { 38, 3, "Branch 38" },
                    { 39, 4, "Branch 39" },
                    { 40, 5, "Branch 40" },
                    { 41, 6, "Branch 41" },
                    { 42, 7, "Branch 42" },
                    { 43, 8, "Branch 43" },
                    { 44, 9, "Branch 44" },
                    { 45, 10, "Branch 45" },
                    { 46, 11, "Branch 46" },
                    { 47, 12, "Branch 47" },
                    { 48, 13, "Branch 48" },
                    { 49, 14, "Branch 49" },
                    { 50, 15, "Branch 50" },
                    { 51, 16, "Branch 51" },
                    { 52, 17, "Branch 52" },
                    { 53, 18, "Branch 53" },
                    { 54, 19, "Branch 54" },
                    { 55, 20, "Branch 55" },
                    { 56, 21, "Branch 56" },
                    { 57, 22, "Branch 57" },
                    { 58, 23, "Branch 58" },
                    { 59, 24, "Branch 59" },
                    { 60, 25, "Branch 60" },
                    { 61, 26, "Branch 61" },
                    { 62, 27, "Branch 62" },
                    { 63, 28, "Branch 63" },
                    { 64, 29, "Branch 64" },
                    { 65, 30, "Branch 65" },
                    { 66, 31, "Branch 66" },
                    { 67, 32, "Branch 67" },
                    { 68, 33, "Branch 68" },
                    { 69, 34, "Branch 69" },
                    { 70, 35, "Branch 70" },
                    { 71, 36, "Branch 71" },
                    { 72, 1, "Branch 72" },
                    { 73, 2, "Branch 73" },
                    { 74, 3, "Branch 74" },
                    { 75, 4, "Branch 75" },
                    { 76, 5, "Branch 76" },
                    { 77, 6, "Branch 77" },
                    { 78, 7, "Branch 78" },
                    { 79, 8, "Branch 79" },
                    { 80, 9, "Branch 80" },
                    { 81, 10, "Branch 81" },
                    { 82, 11, "Branch 82" },
                    { 83, 12, "Branch 83" },
                    { 84, 13, "Branch 84" },
                    { 85, 14, "Branch 85" },
                    { 86, 15, "Branch 86" },
                    { 87, 16, "Branch 87" },
                    { 88, 17, "Branch 88" },
                    { 89, 18, "Branch 89" },
                    { 90, 19, "Branch 90" },
                    { 91, 20, "Branch 91" },
                    { 92, 21, "Branch 92" },
                    { 93, 22, "Branch 93" },
                    { 94, 23, "Branch 94" },
                    { 95, 24, "Branch 95" },
                    { 96, 25, "Branch 96" },
                    { 97, 26, "Branch 97" },
                    { 98, 27, "Branch 98" },
                    { 99, 28, "Branch 99" },
                    { 100, 29, "Branch 100" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "branches");
        }
    }
}
