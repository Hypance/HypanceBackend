using System;
using Hypance.Core.Domain.Bots;
using Hypance.Services.Bots;
using Hypance.Core.Domain.Backtests;
using Hypance.Core.Domain.Strategies;
using Hypance.Core.Domain.Symbols;
using Hypance.Data;
using Hypance.Services.Backtests;
using Hypance.Services.Symbols;
using Microsoft.Extensions.DependencyInjection;
using Hypance.Core.Domain;
using Hypance.Services.Formations;
using Hypance.Core.Domain.Formations;

namespace Hypance.Services
{
	public static class ServiceRegistration
	{
        public static void AddInfrastructureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IRepository<Strategy>, EntityRepository<Strategy>>();
            serviceCollection.AddScoped<IRepository<Symbol>, EntityRepository<Symbol>>();
            serviceCollection.AddScoped<ISymbolService,SymbolService>();
            serviceCollection.AddScoped<IRepository<IndicatorSignal>, EntityRepository<IndicatorSignal>>();
            serviceCollection.AddScoped<IRepository<Signal>, EntityRepository<Signal>>();
            serviceCollection.AddScoped<IRepository<Bot>, EntityRepository<Bot>>();
            serviceCollection.AddScoped<IBotService, BotService>();
            serviceCollection.AddScoped<IRepository<Backtest>, EntityRepository<Backtest>>();
            serviceCollection.AddScoped<IBacktestService, BacktestService>();
            serviceCollection.AddScoped<IRepository<Formation>, EntityRepository<Formation>>();
            serviceCollection.AddScoped<IFormationService, FormationService>();
        }
    }
}

