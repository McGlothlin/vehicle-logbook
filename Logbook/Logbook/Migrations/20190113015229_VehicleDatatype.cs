using Microsoft.EntityFrameworkCore.Migrations;

namespace Logbook.Migrations
{
    public partial class VehicleDatatype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Mileage",
                table: "Vehicles",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Mileage",
                table: "Vehicles",
                nullable: true,
                oldClrType: typeof(long));
        }
    }
}
