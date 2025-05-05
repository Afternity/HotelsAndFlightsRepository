using HotelsAndFlights.Domain.Reservations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelsAndFlights.Domain.Models
{
    public class Room
    {
        public Guid Id { get; set; }
        public int RoomNumber { get; set; }

        public Guid HotelId { get; set; }
        public Hotel Hotel { get; set; } = null!;
        public Guid RoomTypeId { get; set; }
        public RoomType RoomType { get; set; } = null!;
        public IList<FlightBooking> FlightBookings { get; set; } = [];
    }
}
