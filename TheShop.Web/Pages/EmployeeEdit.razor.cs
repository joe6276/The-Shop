using Microsoft.AspNetCore.Components;
using TheShop.Models.Dtos;
using TheShop.Web.Services;

namespace TheShop.Web.Pages
{
    public  partial class EmployeeEdit
    {

        public EmployeeDto Employee { get; set; } = new EmployeeDto();

        [Parameter]
        public string ? EmployeeId { get; set; }

        [Inject]
        public IEmployee employeeService { get; set; }


        [Inject]
        public ICountry? _country { get; set; }

        [Inject]
        public IJob jobCategories { get; set; }

        public List<CountryDto> Countries { get; set; } = new List<CountryDto>();

        public List<JobCategoryDto> Categories  { get; set; } = new List<JobCategoryDto>();

        public string StatusClass { get; set; } = String.Empty;
        public string Message { get; set; } = String.Empty;
        public bool Saved { get; set; }

        [Inject]
        private NavigationManager navigationManager { get; set; }

        protected override async Task OnInitializedAsync()
        {

            int.TryParse(EmployeeId, out var employeeid);

            if (employeeid == 0)
            {
                Employee = new EmployeeDto { JobCategoryId = 1, CountryId = 1, CreatedDate = DateTime.Now };
               
            }
            else
            {
                Employee = await employeeService.GetEmployeeByIdAsync(int.Parse(EmployeeId));
            }

            Countries = (await _country.GetCountries()).ToList();
            Categories = (await jobCategories.GetJobCategories()).ToList();
        }

        protected async Task HandleInvalidSubmit()
        {
            
                Message = "Validation Failed";
                StatusClass = "alert-danger";
            
        }

        protected async Task HandleValidSubmit()
        {
            int.TryParse(EmployeeId, out var employeeid);
            if (employeeid == 0)
            {
                //save
                var addedEmployee = await employeeService.AddEmployee(Employee);
                if(addedEmployee!= null)
                {
                    Message = "User Added Successfully";
                    Saved = true;
                    StatusClass = "alert-success";
                }
                else
                {
                    Message = "Failed";
                    Saved = false;
                    StatusClass = "alert-danger";
                }
            }
            else
            {
                //update
                await employeeService.UpdateEmployee(Employee);
                {
                    Message = "User Updated Successfully";
                    Saved = true;
                    StatusClass = "alert-success";
                }
            }

        }

        protected async Task HandleDelete()
        {
            await employeeService.DeleteEmployee(Employee.Id);
            Message = "User Deleted Successfully";
            Saved = true;
            StatusClass = "alert-success";
        }

        protected void NavigateToOverview()
        {
            navigationManager.NavigateTo("/employee");
        }


    }
}
