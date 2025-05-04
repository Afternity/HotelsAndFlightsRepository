using HotelsAndFlights.Domain.FlightsModels;
using HotelsAndFlights.Domain.Models;
using HotelsAndFlights.Domain.UsersModels;

namespace HotelsAndFlights.Domain.Reservations
{
    public class HotelBooking
    {
        public Guid Id { get; set; }
        public string SeatClass { get; set; } = string.Empty;
        public int Passengers { get; set; }
        
        public Guid BookingId { get; set; }
        public Booking? Booking { get; set; }
        public Guid FlightId { get; set; }
        public Flight? Flight { get; set; }
    }
}
