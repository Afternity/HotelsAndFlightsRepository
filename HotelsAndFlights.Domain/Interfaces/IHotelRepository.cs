using HotelsAndFlights.Domain.Models.HotelModels;

namespace HotelsAndFlights.Domain.Interfaces
{
    public interface IHotelRepository
    {
        Task<Hotel> GetByAsync(Guid hotelId);
        Task<Hotel> AddAsync(Hotel hotel);
        Task<Hotel> UpdateAsync(Hotel hotel);
        Task<Hotel> DeleteAsync(Guid hotelId);
        Task<IList<Hotel>> GetAllAsync();
        Task<IList<Hotel>> GetByRatingIdAsync(double rating);
    }
}
