using HotelsAndFlights.Domain.Models.ReservationModels;

namespace HotelsAndFlights.Domain.Models.HotelModels
{
    public class Room
    {
        public Guid Id { get; set; }
        public string RoomNumber { get; set; } = string.Empty;

        public Guid HotelId { get; set; }
        public Hotel Hotel { get; set; } = null!;
        public Guid RoomTypeId { get; set; }
        public RoomType RoomType { get; set; } = null!;
        public IList<FlightBooking> FlightBookings { get; set; } = [];
    }
}
