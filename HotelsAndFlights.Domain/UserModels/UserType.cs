namespace HotelsAndFlights.Domain.UserModels
{
    public class UserType
    {
        public Guid Id { get; set; }
        public string Type { get; set; } = string.Empty;
        
        public IList<User> Users { get; set; } = [];
    }
}
