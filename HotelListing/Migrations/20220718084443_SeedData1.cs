using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListing.Migrations
{
    public partial class SeedData1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Adress", "CountryId", "Name" },
                values: new object[] { "الامارات", 3, "Emirates hotel" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Adress", "CountryId", "Name" },
                values: new object[] { "السعودية", 2, "saudi arabia hotel" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Adress", "CountryId", "Name" },
                values: new object[] { "السعودية", 1, "saudi arabia hotel" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Adress", "CountryId", "Name" },
                values: new object[] { "الامارات", 1, "Emirates hotel" });
        }
    }
}
