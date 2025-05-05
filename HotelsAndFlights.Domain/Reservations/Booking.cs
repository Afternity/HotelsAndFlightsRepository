using HotelsAndFlights.Domain.FlightsModels;
using HotelsAndFlights.Domain.Models;
using HotelsAndFlights.Domain.UsersModels;
using System.Reflection.Metadata;

namespace HotelsAndFlights.Domain.Reservations
{
    public class Booking
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
        public IList<FlightBooking> FlightBookings { get; set; } = [];
        public IList<HotelBooking> HotelBookings { get; set; } = [];
    }
}
