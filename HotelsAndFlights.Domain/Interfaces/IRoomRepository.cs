using HotelsAndFlights.Domain.Models.HotelModels;

namespace HotelsAndFlights.Domain.Interfaces
{
    public interface IRoomRepository
    {
        Task<Room> GetByIdAsync(Guid id);
        Task AddAsync(Room room);
        Task UpDateAsync(Room room);
        Task DeleteAsync(Room room);
        Task<IList<Room>> GetAllAsync();
        Task<IList<Room>> GetByRoomNumberAsync(string roomNumber);
    }
}
