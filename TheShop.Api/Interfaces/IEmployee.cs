using TheShop.Entities;

namespace TheShop.Interfaces
{
    public interface IEmployee
    {

        Task<IEnumerable<Employee>> GetEmployeesAsync();

        Task <Employee> GetEmployeeAsync(int id);
        
        void DeleteEmployee(Employee employee);

        Task<Employee> addEmployee (Employee employee);
        Task<bool> SaveChangesAsync();
    }
}
