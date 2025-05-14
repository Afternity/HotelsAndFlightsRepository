using System.ComponentModel.DataAnnotations;

namespace HotelsAndFlights.Domain.Models.FlightModels
{
    public class FlightSeat
    {
        public Guid Id { get; set; }  
        public string SeatClass { get; set; } = string.Empty;
        public decimal Price { get; set; } = decimal.Zero;

        [Range(1, 350)]
        public int AvailableCount { get; set; }


        public Guid FlightId { get; set; }
        public Flight Flight { get; set; } = null!;
    }
}
