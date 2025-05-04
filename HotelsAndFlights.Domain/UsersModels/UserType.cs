namespace HotelsAndFlights.Domain.UsersModels
{
    public class UserType
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        
        public IList<User> Users { get; set; } = [];
    }
}
