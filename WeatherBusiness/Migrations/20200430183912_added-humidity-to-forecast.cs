﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace WeatherBusiness.Migrations
{
    public partial class addedhumiditytoforecast : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Humidity",
                table: "Forecasts",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Humidity",
                table: "Forecasts");
        }
    }
}
