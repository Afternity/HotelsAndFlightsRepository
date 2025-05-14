using HotelsAndFlights.Domain.Models.UserModels;

namespace HotelsAndFlights.Domain.Models.ReservationModels
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
