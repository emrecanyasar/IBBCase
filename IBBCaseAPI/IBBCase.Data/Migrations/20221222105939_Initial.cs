using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IBBCase.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarParks",
                columns: table => new
                {
                    CarParkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _id = table.Column<int>(type: "int", nullable: false),
                    PARK_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LOCATİON_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PARK_TYPE_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PARK_TYPE_DESC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CAPACITY_OF_PARK = table.Column<int>(type: "int", nullable: false),
                    WORKING_TIME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    COUNTY_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LONGITUDE = table.Column<double>(type: "float", nullable: false),
                    LATITUDE = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarParks", x => x.CarParkId);
                });

            migrationBuilder.InsertData(
                table: "CarParks",
                columns: new[] { "CarParkId", "CAPACITY_OF_PARK", "COUNTY_NAME", "LATITUDE", "LOCATİON_NAME", "LONGITUDE", "PARK_NAME", "PARK_TYPE_DESC", "PARK_TYPE_ID", "WORKING_TIME", "_id" },
                values: new object[] { 1, 30, "ŞİŞLİ", 41.048823356915499, "Şişli Vali Konağı Caddes", 28.987974944131899, "Vali Konağı Caddesi 1", "YOL ÜSTÜ", "YOL ÜSTÜ", "08:00-19:00", 1 });

            migrationBuilder.InsertData(
                table: "CarParks",
                columns: new[] { "CarParkId", "CAPACITY_OF_PARK", "COUNTY_NAME", "LATITUDE", "LOCATİON_NAME", "LONGITUDE", "PARK_NAME", "PARK_TYPE_DESC", "PARK_TYPE_ID", "WORKING_TIME", "_id" },
                values: new object[] { 2, 50, "ŞİŞLİ", 41.049523298771703, "Şişli Şakayık Soka", 28.995565605244401, "Şakayık Sokak 1", "YOL ÜSTÜ", "YOL ÜSTÜ", "08:00-19:00", 2 });

            migrationBuilder.InsertData(
                table: "CarParks",
                columns: new[] { "CarParkId", "CAPACITY_OF_PARK", "COUNTY_NAME", "LATITUDE", "LOCATİON_NAME", "LONGITUDE", "PARK_NAME", "PARK_TYPE_DESC", "PARK_TYPE_ID", "WORKING_TIME", "_id" },
                values: new object[] { 3, 50, "ŞİŞLİ", 41.048389540642198, "Şişli Hüsrev Gerede Caddes", 28.994975578169999, "Hüsrev Gerede Sokak 1", "YOL ÜSTÜ", "YOL ÜSTÜ", "08:00-19:00", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarParks");
        }
    }
}
