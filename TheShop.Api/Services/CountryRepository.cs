using Microsoft.EntityFrameworkCore;
using TheShop.ApplicationDatabaseContext;
using TheShop.Entities;
using TheShop.Interfaces;

namespace TheShop.Services
{
    public class CountryRepository : ICountry
    {
        private readonly AppDbContext _context;
        public CountryRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Country>> GetCountriesAsync()
        {
         return await _context.Countries.OrderBy(x=> x.Name).ToListAsync();
        }

        public async Task<Country> GetCountryById(int id)
        {
           return await _context.Countries.Where(x=>x.Id == id).FirstOrDefaultAsync();
        }
    }
}
