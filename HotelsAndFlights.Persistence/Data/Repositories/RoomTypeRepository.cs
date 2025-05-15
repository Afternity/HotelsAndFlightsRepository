using HotelsAndFlights.Domain.Interfaces;
using HotelsAndFlights.Domain.Models.HotelModels;
using Microsoft.EntityFrameworkCore;

namespace HotelsAndFlights.Persistence.Data.Repositories
{
    public class RoomTypeRepository : IRoomTypeRepository
    {
        private readonly HotelsAndFlightsDbContext _context;

        public RoomTypeRepository(HotelsAndFlightsDbContext context) => 
            _context = context;

        public async Task AddAsync(RoomType roomType)
        {
            await _context.RoomTypes.AddAsync(roomType);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(RoomType roomType)
        {
            _context.RoomTypes.Remove(roomType);
            await _context.SaveChangesAsync();
        }

        public async Task<IList<RoomType>> GetAllRoomType()
        {
            return await _context.RoomTypes.OrderBy(roomType =>  roomType.Name).ToListAsync();
        }

        public async Task<RoomType> GetByIdAsync(Guid id)
        {
            return await _context.RoomTypes.FindAsync(id);
        }

        public async Task UpdateAsync(RoomType roomType)
        {
            _context.RoomTypes.Update(roomType);
            await _context.SaveChangesAsync();
        }
    }
}
