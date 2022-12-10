using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Hypance.Data.Migrations
{
    public partial class InitialCreate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Formations_Notifications_NotificationId",
                table: "Formations");

            migrationBuilder.DropForeignKey(
                name: "FK_Strategies_Notifications_NotificationId",
                table: "Strategies");

            migrationBuilder.DropForeignKey(
                name: "FK_Symbols_Notifications_NotificationId",
                table: "Symbols");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropIndex(
                name: "IX_Symbols_NotificationId",
                table: "Symbols");

            migrationBuilder.DropIndex(
                name: "IX_Strategies_NotificationId",
                table: "Strategies");

            migrationBuilder.DropIndex(
                name: "IX_Formations_NotificationId",
                table: "Formations");

            migrationBuilder.DropColumn(
                name: "NotificationId",
                table: "Symbols");

            migrationBuilder.DropColumn(
                name: "NotificationId",
                table: "Strategies");

            migrationBuilder.DropColumn(
                name: "NotificationId",
                table: "Formations");

            migrationBuilder.AddColumn<int>(
                name: "BotOptions",
                table: "Bots",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "FormationSignals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FormationSignalName = table.Column<string>(type: "text", nullable: false),
                    SymbolName = table.Column<string>(type: "text", nullable: false),
                    Period = table.Column<int>(type: "integer", nullable: false),
                    Interval = table.Column<int>(type: "integer", nullable: false),
                    Result = table.Column<bool>(type: "boolean", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormationSignals", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormationSignals");

            migrationBuilder.DropColumn(
                name: "BotOptions",
                table: "Bots");

            migrationBuilder.AddColumn<int>(
                name: "NotificationId",
                table: "Symbols",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NotificationId",
                table: "Strategies",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NotificationId",
                table: "Formations",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Market = table.Column<int>(type: "integer", nullable: false),
                    MessageChannel = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    OrderType = table.Column<int>(type: "integer", nullable: false),
                    PositionType = table.Column<int>(type: "integer", nullable: false),
                    TrendStrategy = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Symbols_NotificationId",
                table: "Symbols",
                column: "NotificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Strategies_NotificationId",
                table: "Strategies",
                column: "NotificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Formations_NotificationId",
                table: "Formations",
                column: "NotificationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Formations_Notifications_NotificationId",
                table: "Formations",
                column: "NotificationId",
                principalTable: "Notifications",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Strategies_Notifications_NotificationId",
                table: "Strategies",
                column: "NotificationId",
                principalTable: "Notifications",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Symbols_Notifications_NotificationId",
                table: "Symbols",
                column: "NotificationId",
                principalTable: "Notifications",
                principalColumn: "Id");
        }
    }
}
