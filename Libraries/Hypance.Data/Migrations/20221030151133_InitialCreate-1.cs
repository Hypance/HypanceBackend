using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hypance.Data.Migrations
{
    public partial class InitialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int[]>(
                name: "AssetIds",
                table: "Bots",
                type: "integer[]",
                nullable: false,
                defaultValue: new int[0]);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Bots",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int[]>(
                name: "FormationIds",
                table: "Bots",
                type: "integer[]",
                nullable: false,
                defaultValue: new int[0]);

            migrationBuilder.AddColumn<int[]>(
                name: "StrategyIds",
                table: "Bots",
                type: "integer[]",
                nullable: false,
                defaultValue: new int[0]);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssetIds",
                table: "Bots");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Bots");

            migrationBuilder.DropColumn(
                name: "FormationIds",
                table: "Bots");

            migrationBuilder.DropColumn(
                name: "StrategyIds",
                table: "Bots");
        }
    }
}
