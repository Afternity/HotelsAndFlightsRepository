using HotelsAndFlights.Domain.UserModels;

namespace HotelsAndFlights.Domain.ReservationModels
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
