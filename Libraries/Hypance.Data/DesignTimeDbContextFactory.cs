using Hypance.Data.DataProviders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypance.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<HypanceDbContext>
    {
        public HypanceDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<HypanceDbContext> dbContextOptionsBuilder = new();
            
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);

            return new(dbContextOptionsBuilder.Options);
        }
    }
}
