using HotelsAndFlights.Domain.Interfaces;
using HotelsAndFlights.Domain.Models.HotelModels;

namespace HotelsAndFlights.Persistence.Data.Repositories
{
    public class HotelPhotoRepository : IHotelPhotoRepository
    {
        private readonly HotelsAndFlightsDbContext _context;

        public HotelPhotoRepository(HotelsAndFlightsDbContext context) =>
            _context = context;

        public async Task AddAsync(HotelPhoto hotelPhoto)
        {
            await _context.HotelPhotos.AddAsync(hotelPhoto);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(HotelPhoto hotelPhoto)
        {
            _context.HotelPhotos.Remove(hotelPhoto);
            await _context.SaveChangesAsync();
        }

        public Task<IList<HotelPhoto>> GetAllHotelPhotoAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<HotelPhoto> GetByIdAsync(Guid id)
        {
            return await _context.HotelPhotos.FindAsync(id);
        }

        public async Task UpdateAsync(HotelPhoto hotelPhoto)
        {
            _context.HotelPhotos.Update(hotelPhoto);
            await _context.SaveChangesAsync();
        }
    }
}
