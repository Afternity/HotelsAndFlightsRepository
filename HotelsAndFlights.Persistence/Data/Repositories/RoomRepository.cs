using HotelsAndFlights.Domain.Interfaces;
using HotelsAndFlights.Domain.Models.HotelModels;
using Microsoft.EntityFrameworkCore;

namespace HotelsAndFlights.Persistence.Data.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly HotelsAndFlightsDbContext _context;

        public RoomRepository(HotelsAndFlightsDbContext context) => _context = context;

        public async Task<Room> GetByIdAsync(Guid id)
        {
            return await _context.Rooms.FindAsync(id);
        }

        public async Task AddAsync(Room room)
        {
            await _context.Rooms.AddAsync(room);
            await _context.SaveChangesAsync();
        }
        public async Task UpDateAsync(Room room)
        {
            _context.Rooms.Update(room);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Room room)
        {
            _context.Rooms.Remove(room);
            await _context.SaveChangesAsync();
        }

        public async Task<IList<Room>> GetAllAsync()
        {
            return await _context.Rooms.OrderBy(room => room.Id).ToListAsync();
        }

        public async Task<IList<Room>> GetByRoomNumberAsync(string roomNumber)
        {
            return await _context.Rooms.Where(room => room.RoomNumber == roomNumber).ToListAsync();
        }

    }
}
