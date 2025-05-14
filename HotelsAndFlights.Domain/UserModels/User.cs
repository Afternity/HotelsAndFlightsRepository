using HotelsAndFlights.Domain.ReservationModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelsAndFlights.Domain.UserModels
{
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        [Column(TypeName = "bytea")]
        public byte[] PasswordHash { get; set; } = new byte[32];

        [Column(TypeName = "bytea")]
        public byte[] PasswordSalt { get; set; } = new byte[32];

        public IList<Booking> Bookings { get; set; } = [];
        public Guid UserTypeId { get; set; }
        public UserType UserType { get; set; } = null!; 
    }
}
