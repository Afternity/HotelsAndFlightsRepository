using HotelsAndFlights.Domain.FlightModels;
using System.ComponentModel.DataAnnotations;

namespace HotelsAndFlights.Domain.ReservationModels
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
