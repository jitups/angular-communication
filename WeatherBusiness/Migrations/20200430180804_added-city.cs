using Microsoft.EntityFrameworkCore.Migrations;

namespace WeatherBusiness.Migrations
{
    public partial class addedcity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Forecasts");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Forecasts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Forecasts_CityId",
                table: "Forecasts",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Forecasts_Cities_CityId",
                table: "Forecasts",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Forecasts_Cities_CityId",
                table: "Forecasts");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_Forecasts_CityId",
                table: "Forecasts");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Forecasts");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Forecasts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
