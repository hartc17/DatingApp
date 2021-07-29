using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class Property : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ListingUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    ListPrice = table.Column<int>(type: "INTEGER", nullable: false),
                    DownPayment = table.Column<float>(type: "REAL", nullable: false),
                    InterestRate = table.Column<float>(type: "REAL", nullable: false),
                    RenovationFurnitureCost = table.Column<int>(type: "INTEGER", nullable: false),
                    NightlyRate = table.Column<int>(type: "INTEGER", nullable: false),
                    Occupancy = table.Column<float>(type: "REAL", nullable: false),
                    UtilitiesEtc = table.Column<int>(type: "INTEGER", nullable: false),
                    NetIncome = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Properties");
        }
    }
}
