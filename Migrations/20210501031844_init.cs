using Microsoft.EntityFrameworkCore.Migrations;

namespace CARS_Api.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarsTable",
                columns: table => new
                {
                    car_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    car_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    car_model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    car_price = table.Column<int>(type: "int", nullable: false),
                    car_description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarsTable", x => x.car_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarsTable");
        }
    }
}
