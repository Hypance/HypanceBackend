using Hypance.Data.DataProviders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
