using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BankAccountOpening.Migrations
{
    /// <inheritdoc />
    public partial class Addedstatestablewithseeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "states",
                columns: table => new
                {
                    StateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_states", x => x.StateId);
                });

            migrationBuilder.InsertData(
                table: "states",
                columns: new[] { "StateId", "StateName" },
                values: new object[,]
                {
                    { 1, "Andhra Pradesh" },
                    { 2, "Arunachal Pradesh" },
                    { 3, "Assam" },
                    { 4, "Bihar" },
                    { 5, "Chhattisgarh" },
                    { 6, "Goa" },
                    { 7, "Gujarat" },
                    { 8, "Haryana" },
                    { 9, "Himachal Pradesh" },
                    { 10, "Jharkhand" },
                    { 11, "Karnataka" },
                    { 12, "Kerala" },
                    { 13, "Madhya Pradesh" },
                    { 14, "Maharashtra" },
                    { 15, "Manipur" },
                    { 16, "Meghalaya" },
                    { 17, "Mizoram" },
                    { 18, "Nagaland" },
                    { 19, "Odisha" },
                    { 20, "Punjab" },
                    { 21, "Rajasthan" },
                    { 22, "Sikkim" },
                    { 23, "Tamil Nadu" },
                    { 24, "Telangana" },
                    { 25, "Tripura" },
                    { 26, "Uttar Pradesh" },
                    { 27, "Uttarakhand" },
                    { 28, "West Bengal" },
                    { 29, "Andaman and Nicobar Islands" },
                    { 30, "Chandigarh" },
                    { 31, "Dadra and Nagar Haveli and Daman and Diu" },
                    { 32, "Delhi" },
                    { 33, "Jammu and Kashmir" },
                    { 34, "Ladakh" },
                    { 35, "Lakshadweep" },
                    { 36, "Puducherry" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "states");
        }
    }
}
