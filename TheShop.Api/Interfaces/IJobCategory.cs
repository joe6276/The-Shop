using TheShop.Entities;

namespace TheShop.Interfaces
{
    public interface IJobCategory
    {

        Task<IEnumerable<JobCategory>> GetJobCategoriesAsync();

        Task<JobCategory> GetJobCategoryAsync(int id);
    }
}
