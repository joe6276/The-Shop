using TheShop.Models.Dtos;

namespace TheShop.Web.Services
{
    public interface  IEmployee
    {
        Task<IEnumerable<EmployeeDto>> GetEmployeesAsync();

        Task<EmployeeDto> GetEmployeeByIdAsync(int id);

        Task<EmployeeDto> AddEmployee(EmployeeDto employee);

        Task UpdateEmployee(EmployeeDto employee);

        Task DeleteEmployee(int id);

    }
}
