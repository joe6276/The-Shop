using System.Text;
using System.Text.Json;
using TheShop.Models.Dtos;

namespace TheShop.Web.Services
{
    public class EmployeeDataService : IEmployee
    {   

        private readonly HttpClient _httpClient;
        public EmployeeDataService(HttpClient http)
        {
            _httpClient = http;
        }

        public async Task<EmployeeDto> AddEmployee(EmployeeDto employee)
        {
            var employeeJson = new StringContent(JsonSerializer.Serialize(employee), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/employee/signup",employeeJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<EmployeeDto>(await response.Content.ReadAsStreamAsync());
            }

            return null;
        }

        public async Task DeleteEmployee(int id)
        {
            await _httpClient.DeleteAsync($"api/employee/{id}");
        }

        public async Task<EmployeeDto> GetEmployeeByIdAsync(int id)
        {
            return await JsonSerializer.DeserializeAsync<EmployeeDto>(
                  await _httpClient.GetStreamAsync($"api/employee/id?id={id}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<IEnumerable<EmployeeDto>> GetEmployeesAsync()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<EmployeeDto>>(
                await _httpClient.GetStreamAsync($"api/employee"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task UpdateEmployee(EmployeeDto employee)
        {

            var employeeJson = new StringContent(JsonSerializer.Serialize(employee), Encoding.UTF8, "application/json");
            await _httpClient.PutAsync($"api/employee/update/{employee.Id}", employeeJson);
        }
    }
}
