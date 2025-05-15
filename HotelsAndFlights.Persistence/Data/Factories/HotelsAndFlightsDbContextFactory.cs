using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace HotelsAndFlights.Persistence.Data.Factories
{
    public class HotelsAndFlightsDbContextFactory : IDesignTimeDbContextFactory<HotelsAndFlightsDbContext>
    {
        public HotelsAndFlightsDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<HotelsAndFlightsDbContext>();

            HotelsAndFlightsDbContextConfig.ConfigureDbContext(
                optionsBuilder,
                "Host=localhost;Port=5432;DataBase=DbHotelsAndFlights;UserName=postgres;Password=superuser123;",
                typeof(HotelsAndFlightsDbContext).Assembly.FullName);

            return new HotelsAndFlightsDbContext(optionsBuilder.Options);
        }
    }
}
