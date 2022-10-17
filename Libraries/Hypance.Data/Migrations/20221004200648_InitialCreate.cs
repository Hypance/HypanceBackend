using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Hypance.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Backtests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Market = table.Column<int[]>(type: "integer[]", nullable: false),
                    OrderTypes = table.Column<int[]>(type: "integer[]", nullable: false),
                    Positiontypes = table.Column<int[]>(type: "integer[]", nullable: false),
                    TrendStrategy = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Backtests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Markets = table.Column<int[]>(type: "integer[]", nullable: false),
                    OrderTypes = table.Column<int[]>(type: "integer[]", nullable: false),
                    PositionTypes = table.Column<int[]>(type: "integer[]", nullable: false),
                    TrendStrategies = table.Column<int>(type: "integer", nullable: false),
                    PriceVolume = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bots", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Markets = table.Column<int[]>(type: "integer[]", nullable: false),
                    OrderTypes = table.Column<int[]>(type: "integer[]", nullable: false),
                    PositionTypes = table.Column<int[]>(type: "integer[]", nullable: false),
                    TrendStrategy = table.Column<int>(type: "integer", nullable: false),
                    MessageChannels = table.Column<int[]>(type: "integer[]", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Formations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SignalResults = table.Column<int[]>(type: "integer[]", nullable: false),
                    Period = table.Column<int>(type: "integer", nullable: false),
                    Interval = table.Column<int>(type: "integer", nullable: false),
                    BacktestId = table.Column<int>(type: "integer", nullable: true),
                    BotId = table.Column<int>(type: "integer", nullable: true),
                    NotificationId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Formations_Backtests_BacktestId",
                        column: x => x.BacktestId,
                        principalTable: "Backtests",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Formations_Bots_BotId",
                        column: x => x.BotId,
                        principalTable: "Bots",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Formations_Notifications_NotificationId",
                        column: x => x.NotificationId,
                        principalTable: "Notifications",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Strategies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    BacktestId = table.Column<int>(type: "integer", nullable: true),
                    BotId = table.Column<int>(type: "integer", nullable: true),
                    NotificationId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Strategies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Strategies_Backtests_BacktestId",
                        column: x => x.BacktestId,
                        principalTable: "Backtests",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Strategies_Bots_BotId",
                        column: x => x.BotId,
                        principalTable: "Bots",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Strategies_Notifications_NotificationId",
                        column: x => x.NotificationId,
                        principalTable: "Notifications",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Symbols",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    MinQuantity = table.Column<decimal>(type: "numeric", nullable: false),
                    MaxQuantity = table.Column<decimal>(type: "numeric", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    BacktestId = table.Column<int>(type: "integer", nullable: true),
                    BotId = table.Column<int>(type: "integer", nullable: true),
                    NotificationId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Symbols", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Symbols_Backtests_BacktestId",
                        column: x => x.BacktestId,
                        principalTable: "Backtests",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Symbols_Bots_BotId",
                        column: x => x.BotId,
                        principalTable: "Bots",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Symbols_Notifications_NotificationId",
                        column: x => x.NotificationId,
                        principalTable: "Notifications",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Signals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SignalResults = table.Column<int[]>(type: "integer[]", nullable: false),
                    Period = table.Column<int>(type: "integer", nullable: false),
                    Interval = table.Column<int>(type: "integer", nullable: false),
                    StrategyId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Signals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Signals_Strategies_StrategyId",
                        column: x => x.StrategyId,
                        principalTable: "Strategies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Indicators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    DefaultPeriod = table.Column<int>(type: "integer", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    FormationId = table.Column<int>(type: "integer", nullable: true),
                    SignalId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Indicators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Indicators_Formations_FormationId",
                        column: x => x.FormationId,
                        principalTable: "Formations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Indicators_Signals_SignalId",
                        column: x => x.SignalId,
                        principalTable: "Signals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Formations_BacktestId",
                table: "Formations",
                column: "BacktestId");

            migrationBuilder.CreateIndex(
                name: "IX_Formations_BotId",
                table: "Formations",
                column: "BotId");

            migrationBuilder.CreateIndex(
                name: "IX_Formations_NotificationId",
                table: "Formations",
                column: "NotificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Indicators_FormationId",
                table: "Indicators",
                column: "FormationId");

            migrationBuilder.CreateIndex(
                name: "IX_Indicators_SignalId",
                table: "Indicators",
                column: "SignalId");

            migrationBuilder.CreateIndex(
                name: "IX_Signals_StrategyId",
                table: "Signals",
                column: "StrategyId");

            migrationBuilder.CreateIndex(
                name: "IX_Strategies_BacktestId",
                table: "Strategies",
                column: "BacktestId");

            migrationBuilder.CreateIndex(
                name: "IX_Strategies_BotId",
                table: "Strategies",
                column: "BotId");

            migrationBuilder.CreateIndex(
                name: "IX_Strategies_NotificationId",
                table: "Strategies",
                column: "NotificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Symbols_BacktestId",
                table: "Symbols",
                column: "BacktestId");

            migrationBuilder.CreateIndex(
                name: "IX_Symbols_BotId",
                table: "Symbols",
                column: "BotId");

            migrationBuilder.CreateIndex(
                name: "IX_Symbols_NotificationId",
                table: "Symbols",
                column: "NotificationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Indicators");

            migrationBuilder.DropTable(
                name: "Symbols");

            migrationBuilder.DropTable(
                name: "Formations");

            migrationBuilder.DropTable(
                name: "Signals");

            migrationBuilder.DropTable(
                name: "Strategies");

            migrationBuilder.DropTable(
                name: "Backtests");

            migrationBuilder.DropTable(
                name: "Bots");

            migrationBuilder.DropTable(
                name: "Notifications");
        }
    }
}
