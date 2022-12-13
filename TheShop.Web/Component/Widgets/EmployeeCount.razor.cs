using TheShop.Web.MockData;
using Microsoft.AspNetCore.Components;
using TheShop.Web.Services;

namespace TheShop.Web.Component.Widgets
{
    public partial  class EmployeeCount: ComponentBase
    {
      [Inject]

      public IEmployee? employeeService { get; set; }
    

    public  int  EmployeeCounter { get; set; }                  
        protected override async Task OnInitializedAsync()
        {
            EmployeeCounter = (await employeeService.GetEmployeesAsync()).Count();
        }
    }
}
