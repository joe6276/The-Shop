using Microsoft.EntityFrameworkCore;
using TheShop.ApplicationDatabaseContext;
using TheShop.Entities;
using TheShop.Interfaces;

namespace TheShop.Services
{
    public class JobCategoryRepository : IJobCategory
    {   
        private readonly AppDbContext _context;
        public JobCategoryRepository(AppDbContext context)
        {
           _context = context;
        }
        public async Task<IEnumerable<JobCategory>> GetJobCategoriesAsync()
        {
            return await _context.JobCategories.OrderBy(x => x.Name).ToListAsync();
        }

        public async Task<JobCategory> GetJobCategoryAsync(int id)
        {
            return await _context.JobCategories.Where(x=>x.Id==id).FirstOrDefaultAsync();
        }
    }
}
