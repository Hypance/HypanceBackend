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

                    System.Diagnostics.Debug.WriteLine(Directory.GetCurrentDirectory().ToString());
                    configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Hypance.WebApi"));
                    configurationManager.AddJsonFile("appsettings.json");

                    return configurationManager.GetConnectionString("PostgreSQL");
                }
            }
        
    }
}
