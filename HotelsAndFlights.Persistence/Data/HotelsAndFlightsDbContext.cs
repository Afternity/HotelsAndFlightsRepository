using Microsoft.EntityFrameworkCore;
using HotelsAndFlights.Persistence.Data.EntityTypeConfigurations.FlightModelsEntityTypeConfigurations;
using HotelsAndFlights.Persistence.Data.EntityTypeConfigurations.HotelModelsEntityTypeConfiguratons;
using HotelsAndFlights.Persistence.Data.EntityTypeConfigurations.ReservationModelsEntityTypeConfigurations;
using HotelsAndFlights.Persistence.Data.EntityTypeConfigurations.UserModelsEntityTypeConfigurations;
using HotelsAndFlights.Domain.Models.FlightModels;
using HotelsAndFlights.Domain.Models.HotelModels;
using HotelsAndFlights.Domain.Models.ReservationModels;
using HotelsAndFlights.Domain.Models.UserModels;

namespace HotelsAndFlights.Persistence.Data
{
    public class HotelsAndFlightsDbContext : DbContext
    {
        private readonly DbContextOptions<HotelsAndFlightsDbContext> _options;

        public HotelsAndFlightsDbContext(DbContextOptions<HotelsAndFlightsDbContext> options) 
            : base(options) =>
            _options = options;
        
        public DbSet<Flight> Flights { get; set; }
        public DbSet<FlightSeat> FlightSeats { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelPhoto> HotelPhotos { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<FlightBooking> FlightBookings { get; set; }
        public DbSet<HotelBooking> HotelBookings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FlightConfiguration());
            modelBuilder.ApplyConfiguration(new FlightSeatConfiguration());

            modelBuilder.ApplyConfiguration(new HotelConfiguration());
            modelBuilder.ApplyConfiguration(new HotelPhotoConfiguratuon());
            modelBuilder.ApplyConfiguration(new RoomConfiguration());
            modelBuilder.ApplyConfiguration(new RoomTypeConfiguration());

            modelBuilder.ApplyConfiguration(new BookingConfiguration());
            modelBuilder.ApplyConfiguration(new FlightBookingConfiguration());
            modelBuilder.ApplyConfiguration(new HotelBookingConfiguration());

            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserTypeConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
