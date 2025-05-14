using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelsAndFlights.Persistence.Data
{
    public class HotelsAndFlightsDbContextConfig
    {
        public static void ConfigureDbContext(
             DbContextOptionsBuilder optionsBuilder,
             string connectionString,
             string migrationsAssemblyName)
        {
            optionsBuilder.UseNpgsql(
                connectionString,
                b => b.MigrationsAssembly(migrationsAssemblyName));
        }
    }
}
