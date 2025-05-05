using HotelsAndFlights.Domain.FlightsModels;
using HotelsAndFlights.Domain.Models;
using HotelsAndFlights.Domain.UsersModels;
using System.ComponentModel.DataAnnotations;

namespace HotelsAndFlights.Domain.Reservations
{
    public class HotelBooking
    {
        public string SeatClass { get; set; } = string.Empty;
        public int Passengers { get; set; }

        [Key]
        public Guid BookingId { get; set; }
        public Booking Booking { get; set; } = null!;
        [Key]
        public Guid FlightId { get; set; }
        public Flight Flight { get; set; } = null!;
    }
}
