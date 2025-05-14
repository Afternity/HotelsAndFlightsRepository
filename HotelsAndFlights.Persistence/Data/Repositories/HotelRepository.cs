using HotelsAndFlights.Domain.Interfaces;
using HotelsAndFlights.Domain.Models.HotelModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelsAndFlights.Persistence.Data.Repositories
{
    public class HotelRepository : IHotelRepository
    {
        private readonly HotelsAndFlightsDbContext _context;

        public HotelRepository(HotelsAndFlightsDbContext context) => _context = context;

        public async Task<Hotel> GetByAsync(Guid hotelId)
        {
            return await _context.Hotels.FindAsync(hotelId);
        }

        public async Task AddAsync(Hotel hotel)
        {
             await _context.Hotels.AddAsync(hotel);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Hotel hotel)
        {
            _context.Hotels.Update(hotel);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Hotel hotel)
        {
            _context.Hotels.Remove(hotel);
            await _context.SaveChangesAsync();
        }

        public async Task<IList<Hotel>> GetAllAsync()
        {
            return await _context.Hotels.OrderBy(hotel => hotel.Name).ToListAsync();
        }


        public Task<IList<Hotel>> GetByRatingAsync(double rating)
        {
            throw new NotImplementedException();
        }

    }
}
