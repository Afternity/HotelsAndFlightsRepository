using HotelsAndFlights.Domain.ReservationModels;

namespace HotelsAndFlights.Domain.FlightModels
{
    public class Flight
    {
      public Guid Id { get; set; }
        public string Airline { get; set; } = string.Empty;
        public string DepartureCity { get; set; } = string.Empty;
        public string ArrivalCity { get; set; } = string.Empty;
        public DateTime DepartureTime { get; set; } 
        public TimeSpan Duration { get; set; }

        public IList<FlightSeat> FlightSeats { get; set; } = [];
        public IList<HotelBooking> HotelBookings { get; set; } = [];
    }
}
