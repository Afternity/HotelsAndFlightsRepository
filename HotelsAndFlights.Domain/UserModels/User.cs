using HotelsAndFlights.Domain.ReservationModels;

namespace HotelsAndFlights.Domain.UserModels
{
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; } 
        public byte[] PasswordSalt { get; set; }

        public IList<Booking> Bookings { get; set; } = [];
        public Guid UserTypeId { get; set; }
        public UserType UserType { get; set; } = null!; 
    }
}
