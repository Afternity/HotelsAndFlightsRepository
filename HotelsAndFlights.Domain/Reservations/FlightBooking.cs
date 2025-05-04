using HotelsAndFlights.Domain.FlightsModels;
using HotelsAndFlights.Domain.Models;
using HotelsAndFlights.Domain.UsersModels;

namespace HotelsAndFlights.Domain.Reservations
{
    public class FlightBooking
    {
        public Guid Id { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        public Guid BookingId { get; set; }
        public Booking? Booking { get; set; }
        public Guid RoomId { get; set; }
        public Room? Room { get; set; }
    }
}
