namespace HotelsAndFlights.Domain.Models
{
    public class RoomType
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int MaxGuests { get; set; }
        public decimal BasePrice { get; set; }

        public IList<Room> Rooms { get; set; } = [];
    }
}
