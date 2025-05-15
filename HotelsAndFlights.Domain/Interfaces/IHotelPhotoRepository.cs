using HotelsAndFlights.Domain.Models.HotelModels;

namespace HotelsAndFlights.Domain.Interfaces
{
    public interface IHotelPhotoRepository
    {
        Task<HotelPhoto> GetByIdAsync(Guid id);
        Task AddAsync(HotelPhoto hotelPhoto);
        Task UpdateAsync(HotelPhoto hotelPhoto);
        Task DeleteAsync(HotelPhoto hotelPhoto);
        Task<IList<HotelPhoto>> GetAllHotelPhotoAsync();
    }
}
