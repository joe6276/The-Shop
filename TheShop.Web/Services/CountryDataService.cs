using System.Text.Json;
using TheShop.Models.Dtos;

namespace TheShop.Web.Services
{
    public class CountryDataService : ICountry
    {   

        private readonly HttpClient _httpClient;

        public CountryDataService(HttpClient http)
        {
            _httpClient = http;
        }
        public async Task<IEnumerable<CountryDto>> GetCountries()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<CountryDto>>(
                await _httpClient.GetStreamAsync($"api/country"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<CountryDto> GetCountryById(int id)
        {
            return await JsonSerializer.DeserializeAsync<CountryDto>(
                await _httpClient.GetStreamAsync($"api/country/{id}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
