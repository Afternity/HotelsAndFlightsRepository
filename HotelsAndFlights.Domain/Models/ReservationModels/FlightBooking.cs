using HotelsAndFlights.Domain.Models.HotelModels;
using System.ComponentModel.DataAnnotations;

namespace HotelsAndFlights.Domain.Models.ReservationModels
{
    public class FlightBooking
    {
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        [Key]
        public Guid BookingId { get; set; }
        public Booking Booking { get; set; } = null!;
        [Key]
        public Guid RoomId { get; set; }
        public Room Room { get; set; } = null!;
    }
}
