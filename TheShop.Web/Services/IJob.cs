using TheShop.Models.Dtos;

namespace TheShop.Web.Services
{
    public interface  IJob
    {

        Task<IEnumerable<JobCategoryDto>> GetJobCategories();
        Task<JobCategoryDto> GetJobCategoryById(int id);
    }
}
