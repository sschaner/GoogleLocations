using Microsoft.EntityFrameworkCore.Migrations;

namespace GoogleLocations.Migrations
{
    public partial class AddLocationDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "PointsOfInterest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "PointsOfInterest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ZIP",
                table: "PointsOfInterest",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "PointsOfInterest");

            migrationBuilder.DropColumn(
                name: "State",
                table: "PointsOfInterest");

            migrationBuilder.DropColumn(
                name: "ZIP",
                table: "PointsOfInterest");
        }
    }
}
