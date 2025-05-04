using HotelsAndFlights.Domain.Reservations;

namespace HotelsAndFlights.Domain.UsersModels
{
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public IList<Booking> Bookings { get; set; } = [];
        public Guid UserTypeId { get; set; }
        public UserType UserType { get; set; } = null!; 
    }
}
