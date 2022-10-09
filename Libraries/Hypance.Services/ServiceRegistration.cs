using System;
using Hypance.Core.Domain.Symbols;
using Hypance.Data;
using Hypance.Services.Symbols;
using Microsoft.Extensions.DependencyInjection;


namespace Hypance.Services
{
	public static class ServiceRegistration
	{
        public static void AddInfrastructureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IRepository<Symbol>, EntityRepository<Symbol>>();
            serviceCollection.AddScoped<ISymbolService,SymbolService>();
        }
    }
}

