using Microsoft.AspNetCore.Components;
using TheShop.Models.Dtos;
using TheShop.Web.MockData;
using TheShop.Web.Model;
using TheShop.Web.Services;

namespace TheShop.Web.Pages
{
    public partial  class EmployeeOverview
    {
        [Inject]
        public IEmployee?  employeeService { get; set; } 
        public List<EmployeeDto>? Employees { get; set; } = default!;

        private EmployeeDto? _selectedEmployee ;


        public string Title = "Employee Overview";


        protected override async Task OnInitializedAsync()

        {

            Employees= (await employeeService.GetEmployeesAsync()).ToList();     
            
            Console.WriteLine(Employees);
        }

        private void  ShowPopUp(EmployeeDto selectedEmployee)
        {
            _selectedEmployee= selectedEmployee;
        }
    }
}
