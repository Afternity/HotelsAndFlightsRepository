namespace HotelsAndFlights.Domain.HotelModels
{
    public class Hotel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Stars { get; set; } 

        public IList<Room> Rooms { get; set; } = [];
        public IList<HotelPhoto> HotelPhotos { get; set; } = [];
    }
}
