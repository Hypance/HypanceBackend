using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Hypance.Data.Migrations
{
    public partial class InitialCreate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BacktestId",
                table: "Symbols",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NotificationId",
                table: "Symbols",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BacktestId",
                table: "Strategies",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NotificationId",
                table: "Strategies",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Notifications",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "BacktestId",
                table: "Formations",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NotificationId",
                table: "Formations",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Bots",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Backtests",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notifications",
                table: "Notifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bots",
                table: "Bots",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Backtests",
                table: "Backtests",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Symbols_BacktestId",
                table: "Symbols",
                column: "BacktestId");

            migrationBuilder.CreateIndex(
                name: "IX_Symbols_NotificationId",
                table: "Symbols",
                column: "NotificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Strategies_BacktestId",
                table: "Strategies",
                column: "BacktestId");

            migrationBuilder.CreateIndex(
                name: "IX_Strategies_NotificationId",
                table: "Strategies",
                column: "NotificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Formations_BacktestId",
                table: "Formations",
                column: "BacktestId");

            migrationBuilder.CreateIndex(
                name: "IX_Formations_NotificationId",
                table: "Formations",
                column: "NotificationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Formations_Backtests_BacktestId",
                table: "Formations",
                column: "BacktestId",
                principalTable: "Backtests",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Formations_Notifications_NotificationId",
                table: "Formations",
                column: "NotificationId",
                principalTable: "Notifications",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Strategies_Backtests_BacktestId",
                table: "Strategies",
                column: "BacktestId",
                principalTable: "Backtests",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Strategies_Notifications_NotificationId",
                table: "Strategies",
                column: "NotificationId",
                principalTable: "Notifications",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Symbols_Backtests_BacktestId",
                table: "Symbols",
                column: "BacktestId",
                principalTable: "Backtests",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Symbols_Notifications_NotificationId",
                table: "Symbols",
                column: "NotificationId",
                principalTable: "Notifications",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Formations_Backtests_BacktestId",
                table: "Formations");

            migrationBuilder.DropForeignKey(
                name: "FK_Formations_Notifications_NotificationId",
                table: "Formations");

            migrationBuilder.DropForeignKey(
                name: "FK_Strategies_Backtests_BacktestId",
                table: "Strategies");

            migrationBuilder.DropForeignKey(
                name: "FK_Strategies_Notifications_NotificationId",
                table: "Strategies");

            migrationBuilder.DropForeignKey(
                name: "FK_Symbols_Backtests_BacktestId",
                table: "Symbols");

            migrationBuilder.DropForeignKey(
                name: "FK_Symbols_Notifications_NotificationId",
                table: "Symbols");

            migrationBuilder.DropIndex(
                name: "IX_Symbols_BacktestId",
                table: "Symbols");

            migrationBuilder.DropIndex(
                name: "IX_Symbols_NotificationId",
                table: "Symbols");

            migrationBuilder.DropIndex(
                name: "IX_Strategies_BacktestId",
                table: "Strategies");

            migrationBuilder.DropIndex(
                name: "IX_Strategies_NotificationId",
                table: "Strategies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Notifications",
                table: "Notifications");

            migrationBuilder.DropIndex(
                name: "IX_Formations_BacktestId",
                table: "Formations");

            migrationBuilder.DropIndex(
                name: "IX_Formations_NotificationId",
                table: "Formations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bots",
                table: "Bots");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Backtests",
                table: "Backtests");

            migrationBuilder.DropColumn(
                name: "BacktestId",
                table: "Symbols");

            migrationBuilder.DropColumn(
                name: "NotificationId",
                table: "Symbols");

            migrationBuilder.DropColumn(
                name: "BacktestId",
                table: "Strategies");

            migrationBuilder.DropColumn(
                name: "NotificationId",
                table: "Strategies");

            migrationBuilder.DropColumn(
                name: "BacktestId",
                table: "Formations");

            migrationBuilder.DropColumn(
                name: "NotificationId",
                table: "Formations");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Notifications",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Bots",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Backtests",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);
        }
    }
}
