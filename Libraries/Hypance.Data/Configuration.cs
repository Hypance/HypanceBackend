using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypance.Data
{
    static class Configuration
    {
        
            static public string ConnectionString
            {
                get
                {
                    ConfigurationManager configurationManager = new();
                    var combine = Directory.GetCurrentDirectory().Replace("/Libraries/Hypance.Data", "/Presenentation/Hypance.WebApi");
                    configurationManager.SetBasePath(Path.Combine(combine));
                    configurationManager.AddJsonFile("appsettings.json");

                    return configurationManager.GetConnectionString("PostgreSQL");
                }
            }
        
    }
}
