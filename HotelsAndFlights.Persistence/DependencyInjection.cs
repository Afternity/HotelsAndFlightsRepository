using HotelsAndFlights.Domain.Interfaces;
using HotelsAndFlights.Persistence.Data;
using HotelsAndFlights.Persistence.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HotelsAndFlights.Persistence
{
    public static class DependencyInjection
    {
       public static IServiceCollection AddPersistance(
           this IServiceCollection services,
           IConfiguration configuration)
        {
            services.AddDbContext<HotelsAndFlightsDbContext>(options =>
            {
                HotelsAndFlightsDbContextConfig.ConfigureDbContext(
                    options,
                    configuration.GetConnectionString("DefaultConnection"),
                    typeof(HotelsAndFlightsDbContext).Assembly.FullName);
            });

            services.AddScoped<IHotelRepository, HotelRepository>();
            services.AddScoped<IRoomRepository, RoomRepository>();

            return services;
        }
    }
}
