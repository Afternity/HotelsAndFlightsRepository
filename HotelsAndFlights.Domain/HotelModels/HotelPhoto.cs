namespace HotelsAndFlights.Domain.Models
{
    public class HotelPhoto
    {
        public Guid Id { get; set; }
        public Uri? Url { get; set; } 
        public string AltText { get; set; } = string.Empty;

        public Guid HotelId { get; set; }
        public Hotel? Hotel { get; set; }
    }
}
