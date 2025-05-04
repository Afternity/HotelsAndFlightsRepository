using System;
using System.Collections.Generic;
using System.Diagnostics;
namespace HotelsAndFlights.Domain.FlightsModels
{
    public class FlightSeat
    {
        public Guid Id { get; set; }  
        public string SeatClass { get; set; } = string.Empty;
        public decimal Price { get; set; } = decimal.Zero;
        public int AvailableCount { get; set; }


        public Guid FlightId { get; set; }
        public Flight? Flight { get; set; }
    }
}
