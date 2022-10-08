using Hypance.Data.DataProviders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Hypance.Data
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            var connectionDb = Configuration.ConnectionString;
            services.AddDbContext<HypanceDbContext>(options => options.UseNpgsql(connectionDb));
        }
     }
}
