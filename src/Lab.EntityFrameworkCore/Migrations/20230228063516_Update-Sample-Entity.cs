using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSampleEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataOfMeasurement",
                table: "Samples");

            migrationBuilder.RenameColumn(
                name: "LaborantName",
                table: "Samples",
                newName: "Measurement");

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Samples",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "Samples",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Number",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "Samples");

            migrationBuilder.RenameColumn(
                name: "Measurement",
                table: "Samples",
                newName: "LaborantName");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataOfMeasurement",
                table: "Samples",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
