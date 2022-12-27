using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IBBCase.Data.Migrations
{
    public partial class Fixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LOCATİON_NAME",
                table: "CarParks",
                newName: "LOCATION_NAME");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LOCATION_NAME",
                table: "CarParks",
                newName: "LOCATİON_NAME");
        }
    }
}
