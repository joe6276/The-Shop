using Microsoft.EntityFrameworkCore;
using TheShop.ApplicationDatabaseContext;
using TheShop.Entities;
using TheShop.Interfaces;

namespace TheShop.Services
{
    public class EmployeesRepository : IEmployee
    {

        private readonly AppDbContext _context;

        public EmployeesRepository(AppDbContext context)
        {
            _context = context;
        }

        

        async Task<Employee> IEmployee.addEmployee(Employee employee)
        {
           var addedEntity= _context.Employees.Add(employee);
           await  _context.SaveChangesAsync();
            return addedEntity.Entity;
        }

        public void DeleteEmployee(Employee employee)
        {
            _context.Employees.Remove(employee);
        }

        public async Task<Employee> GetEmployeeAsync(int id)
        {
            return await _context.Employees.Where(x=>x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Employee>> GetEmployeesAsync()
        {
            return await _context.Employees.OrderBy(e => e.Name).ToListAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() >= 0);
        }
    }
}
