using Microsoft.EntityFrameworkCore;
using HotelsAndFlights.Domain;
using HotelsAndFlights.Domain.FlightsModels;
using HotelsAndFlights.Domain.Models;
using HotelsAndFlights.Domain.Reservations;
using HotelsAndFlights.Domain.UsersModels;

namespace HotelsAndFlights.Persistence
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

            base.OnModelCreating(modelBuilder);
        }
    }
}
