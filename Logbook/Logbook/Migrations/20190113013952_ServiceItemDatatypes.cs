using Microsoft.EntityFrameworkCore.Migrations;

namespace Logbook.Migrations
{
    public partial class ServiceItemDatatypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Interval",
                table: "ServiceItems",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Interval",
                table: "ServiceItems",
                nullable: true,
                oldClrType: typeof(long),
                oldNullable: true);
        }
    }
}
