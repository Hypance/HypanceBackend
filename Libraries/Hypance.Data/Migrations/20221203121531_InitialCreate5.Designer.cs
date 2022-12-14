// <auto-generated />
using System;
using Hypance.Data.DataProviders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Hypance.Data.Migrations
{
    [DbContext(typeof(HypanceDbContext))]
    [Migration("20221203121531_InitialCreate5")]
    partial class InitialCreate5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Hypance.Core.Domain.Backtests.Backtest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Market")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OrderType")
                        .HasColumnType("integer");

                    b.Property<int>("PositionType")
                        .HasColumnType("integer");

                    b.Property<int>("TrendStrategy")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Backtests");
                });

            modelBuilder.Entity("Hypance.Core.Domain.Bots.Bot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int[]>("AssetIds")
                        .IsRequired()
                        .HasColumnType("integer[]");

                    b.Property<int>("BotOptions")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int[]>("FormationIds")
                        .HasColumnType("integer[]");

                    b.Property<int>("Market")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OrderType")
                        .HasColumnType("integer");

                    b.Property<int>("PositionType")
                        .HasColumnType("integer");

                    b.Property<decimal>("PriceVolume")
                        .HasColumnType("numeric");

                    b.Property<int[]>("StrategyIds")
                        .HasColumnType("integer[]");

                    b.Property<int>("TrendStrategy")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Bots");
                });

            modelBuilder.Entity("Hypance.Core.Domain.Formations.Formation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("BacktestId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("BacktestId");

                    b.ToTable("Formations");
                });

            modelBuilder.Entity("Hypance.Core.Domain.Formations.FormationSignal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FormationSignalName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Interval")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<int>("Period")
                        .HasColumnType("integer");

                    b.Property<bool>("Result")
                        .HasColumnType("boolean");

                    b.Property<string>("SymbolName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("FormationSignals");
                });

            modelBuilder.Entity("Hypance.Core.Domain.Strategies.Indicator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("DefaultPeriod")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Indicators");
                });

            modelBuilder.Entity("Hypance.Core.Domain.Strategies.IndicatorSignal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("IndicatorName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Interval")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<int>("Period")
                        .HasColumnType("integer");

                    b.Property<int[]>("Signals")
                        .IsRequired()
                        .HasColumnType("integer[]");

                    b.Property<string>("SymbolName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("IndicatorSignals");
                });

            modelBuilder.Entity("Hypance.Core.Domain.Strategies.Signal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("IndicatorId")
                        .HasColumnType("integer");

                    b.Property<int>("Interval")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Period")
                        .HasColumnType("integer");

                    b.Property<int>("SignalResult")
                        .HasColumnType("integer");

                    b.Property<int?>("StrategyId")
                        .HasColumnType("integer");

                    b.Property<int>("TrendStrategy")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("StrategyId");

                    b.ToTable("Signals");
                });

            modelBuilder.Entity("Hypance.Core.Domain.Strategies.Strategy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("BacktestId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("BacktestId");

                    b.ToTable("Strategies");
                });

            modelBuilder.Entity("Hypance.Core.Domain.Symbols.Candlestick", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("ClosePrice")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("CloseTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("HighPrice")
                        .HasColumnType("numeric");

                    b.Property<int>("Interval")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<decimal>("LowPrice")
                        .HasColumnType("numeric");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("OpenPrice")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("OpenTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Volume")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Candlesticks");
                });

            modelBuilder.Entity("Hypance.Core.Domain.Symbols.Symbol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("BacktestId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<decimal>("MaxQuantity")
                        .HasColumnType("numeric");

                    b.Property<decimal>("MinQuantity")
                        .HasColumnType("numeric");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("BacktestId");

                    b.ToTable("Symbols");
                });

            modelBuilder.Entity("Hypance.Core.Domain.Formations.Formation", b =>
                {
                    b.HasOne("Hypance.Core.Domain.Backtests.Backtest", null)
                        .WithMany("Formation")
                        .HasForeignKey("BacktestId");
                });

            modelBuilder.Entity("Hypance.Core.Domain.Strategies.Signal", b =>
                {
                    b.HasOne("Hypance.Core.Domain.Strategies.Strategy", null)
                        .WithMany("Signals")
                        .HasForeignKey("StrategyId");
                });

            modelBuilder.Entity("Hypance.Core.Domain.Strategies.Strategy", b =>
                {
                    b.HasOne("Hypance.Core.Domain.Backtests.Backtest", null)
                        .WithMany("Strategy")
                        .HasForeignKey("BacktestId");
                });

            modelBuilder.Entity("Hypance.Core.Domain.Symbols.Symbol", b =>
                {
                    b.HasOne("Hypance.Core.Domain.Backtests.Backtest", null)
                        .WithMany("Symbols")
                        .HasForeignKey("BacktestId");
                });

            modelBuilder.Entity("Hypance.Core.Domain.Backtests.Backtest", b =>
                {
                    b.Navigation("Formation");

                    b.Navigation("Strategy");

                    b.Navigation("Symbols");
                });

            modelBuilder.Entity("Hypance.Core.Domain.Strategies.Strategy", b =>
                {
                    b.Navigation("Signals");
                });
#pragma warning restore 612, 618
        }
    }
}
