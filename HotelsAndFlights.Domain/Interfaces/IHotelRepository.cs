using HotelsAndFlights.Domain.Models.HotelModels;

namespace HotelsAndFlights.Domain.Interfaces
{
    public interface IHotelRepository
    {
        Task<Hotel> GetByAsync(Guid hotelId);
        Task AddAsync(Hotel hotel);
        Task UpdateAsync(Hotel hotel);
        Task DeleteAsync(Hotel hotel);
        Task<IList<Hotel>> GetAllAsync();
        Task<IList<Hotel>> GetByRatingAsync(double rating);
    }
}
