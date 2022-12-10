using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hypance.Data.Migrations
{
    public partial class InitialCreate6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DefaultPeriod",
                table: "Formations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Formations",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DefaultPeriod",
                table: "Formations");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Formations");
        }
    }
}
