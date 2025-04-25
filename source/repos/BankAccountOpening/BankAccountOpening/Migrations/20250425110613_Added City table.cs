using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BankAccountOpening.Migrations
{
    /// <inheritdoc />
    public partial class AddedCitytable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CityStateCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cities", x => x.CityId);
                });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "CityId", "CityName", "CityStateCode" },
                values: new object[,]
                {
                    { 1, "Mumbai", 14 },
                    { 2, "Pune", 14 },
                    { 3, "Bangalore", 11 },
                    { 4, "Delhi", 7 },
                    { 5, "Chennai", 13 },
                    { 6, "Kolkata", 19 },
                    { 7, "Hyderabad", 36 },
                    { 8, "Ahmedabad", 24 },
                    { 9, "Jaipur", 8 },
                    { 10, "Surat", 24 },
                    { 11, "Lucknow", 9 },
                    { 12, "Kanpur", 9 },
                    { 13, "Nagpur", 21 },
                    { 14, "Indore", 23 },
                    { 15, "Thane", 14 },
                    { 16, "Chandigarh", 4 },
                    { 17, "Patna", 10 },
                    { 18, "Vadodara", 24 },
                    { 19, "Coimbatore", 13 },
                    { 20, "Visakhapatnam", 36 },
                    { 21, "Bhopal", 23 },
                    { 22, "Nashik", 14 },
                    { 23, "Faridabad", 7 },
                    { 24, "Rajkot", 24 },
                    { 25, "Meerut", 9 },
                    { 26, "Noida", 7 },
                    { 27, "Shivamogga", 11 },
                    { 28, "Mysuru", 11 },
                    { 29, "Agra", 9 },
                    { 30, "Raipur", 36 },
                    { 31, "Vijayawada", 36 },
                    { 32, "Kochi", 13 },
                    { 33, "Gurgaon", 7 },
                    { 34, "Kozhikode", 13 },
                    { 35, "Ranchi", 20 },
                    { 36, "Howrah", 19 },
                    { 37, "Dhanbad", 20 },
                    { 38, "Jabalpur", 23 },
                    { 39, "Gwalior", 23 },
                    { 40, "Durgapur", 19 },
                    { 41, "Bhubaneswar", 21 },
                    { 42, "Tiruchirappalli", 13 },
                    { 43, "Vellore", 13 },
                    { 44, "Puducherry", 15 },
                    { 45, "Shimla", 2 },
                    { 46, "Dehradun", 2 },
                    { 47, "Mangalore", 11 },
                    { 48, "Gandhinagar", 24 },
                    { 49, "Srinagar", 1 },
                    { 50, "Amritsar", 3 },
                    { 51, "Allahabad", 9 },
                    { 52, "Bikaner", 8 },
                    { 53, "Jodhpur", 8 },
                    { 54, "Nagapattinam", 13 },
                    { 55, "Siliguri", 19 },
                    { 56, "Solapur", 14 },
                    { 57, "Cuttack", 21 },
                    { 58, "Udaipur", 8 },
                    { 59, "Raigarh", 36 },
                    { 60, "Haridwar", 2 },
                    { 61, "Kurnool", 36 },
                    { 62, "Jammu", 1 },
                    { 63, "Aurangabad", 14 },
                    { 64, "Bilaspur", 23 },
                    { 65, "Nellore", 36 },
                    { 66, "Erode", 13 },
                    { 67, "Tirunelveli", 13 },
                    { 68, "Warangal", 36 },
                    { 69, "Khammam", 36 },
                    { 70, "Muzaffarpur", 10 },
                    { 71, "Moradabad", 9 },
                    { 72, "Bihar Sharif", 10 },
                    { 73, "Shirdi", 14 },
                    { 74, "Guwahati", 3 },
                    { 75, "Rourkela", 21 },
                    { 76, "Bhilai", 20 },
                    { 77, "Madurai", 13 },
                    { 78, "Chandrapur", 14 },
                    { 79, "Ludhiana", 3 },
                    { 80, "Bilaspur", 23 },
                    { 81, "Kochi", 13 },
                    { 82, "Karur", 13 },
                    { 83, "Ambala", 4 },
                    { 84, "Haldwani", 2 },
                    { 85, "Aligarh", 9 },
                    { 86, "Tumkur", 11 },
                    { 87, "Sangli", 14 },
                    { 88, "Kolar", 11 },
                    { 89, "Jamshedpur", 20 },
                    { 90, "Rohtak", 7 },
                    { 91, "Shivpuri", 23 },
                    { 92, "Durgapur", 19 },
                    { 93, "Hoshiarpur", 3 },
                    { 94, "Gurgaon", 7 },
                    { 95, "Satna", 23 },
                    { 96, "Pondicherry", 15 },
                    { 97, "Baroda", 24 },
                    { 98, "Tumkur", 11 },
                    { 99, "Raichur", 11 },
                    { 100, "Vapi", 24 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cities");
        }
    }
}
