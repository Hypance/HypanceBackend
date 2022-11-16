using Hypance.Core.Domain.Backtests;
using Hypance.Core.Domain.Bots;
using Hypance.Core.Domain.Formations;
using Hypance.Core.Domain.Notifications;
using Hypance.Core.Domain.Strategies;
using Hypance.Core.Domain.Symbols;
using Microsoft.EntityFrameworkCore;

namespace Hypance.Data.DataProviders
{
    public class HypanceDbContext : DbContext 
    {

        public HypanceDbContext(DbContextOptions options) : base(options)
        { }

        public HypanceDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Backtest> Backtests { get; set; }
        public DbSet<Bot> Bots { get; set; }
        public DbSet<Formation> Formations { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Indicator> Indicators { get; set; }
        public DbSet<IndicatorSignal> IndicatorSignals { get; set; }
        public DbSet<Signal> Signals { get; set; }
        public DbSet<Strategy> Strategies { get; set; }
        public DbSet<Symbol> Symbols { get; set; }
        public DbSet<Candlestick> Candlesticks { get; set; }
    }
}
