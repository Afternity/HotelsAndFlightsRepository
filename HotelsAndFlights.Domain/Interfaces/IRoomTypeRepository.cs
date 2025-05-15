using HotelsAndFlights.Domain.Models.HotelModels;

namespace HotelsAndFlights.Domain.Interfaces
{
    public interface IRoomTypeRepository
    {
        Task<RoomType> GetByIdAsync(Guid id);
        Task AddAsync(RoomType roomType);
        Task UpdateAsync(RoomType roomType);
        Task DeleteAsync(RoomType roomType);
        Task<IList<RoomType>> GetAllRoomType();
    }
}
 