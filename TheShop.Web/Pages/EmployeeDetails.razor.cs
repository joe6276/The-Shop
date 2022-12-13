using Microsoft.AspNetCore.Components;
using TheShop.Models.Dtos;
using TheShop.Web.Services;

namespace TheShop.Web.Pages
{
    public partial class EmployeeDetails
    {

        [Parameter]
        public string EmployeeId { get; set; }=string.Empty;

        [Inject]
        public IEmployee? employeeService { get; set; }

        public EmployeeDto Employee { get; set; } = default!;


      protected override async Task OnInitializedAsync()
        {
            Employee = await employeeService.GetEmployeeByIdAsync(int.Parse(EmployeeId));
          

        }
    }
}
