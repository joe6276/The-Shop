using System.Text.Json;
using TheShop.Models.Dtos;

namespace TheShop.Web.Services
{
    public class JobCategoryDataService : IJob
    {   

        private readonly HttpClient _httpClient;

        public JobCategoryDataService(HttpClient http)
        {
            _httpClient = http;
        }
        public async Task<IEnumerable<JobCategoryDto>> GetJobCategories()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<JobCategoryDto>>(
                 await _httpClient.GetStreamAsync($"api/job"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<JobCategoryDto> GetJobCategoryById(int id)
        {
            return await JsonSerializer.DeserializeAsync<JobCategoryDto>(
                await _httpClient.GetStreamAsync($"api/job/{id}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
