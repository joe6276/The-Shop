using TheShop.Web.Model;
using Microsoft.AspNetCore.Components;
using TheShop.Models.Dtos;

namespace TheShop.Web.Component
{
    public  partial class EmployeeCard
    {   
        [Parameter]
        public EmployeeDto Empolyees { get; set; } = default!;

        [Parameter]
        public EventCallback<EmployeeDto> ShowEmployeeQuickView { get; set; }
          
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        private  void ShowFullDetails(EmployeeDto Empolyees)
        {
            NavigationManager.NavigateTo($"/employee/{Empolyees.Id}");
        }

        protected override void OnInitialized()
        {
            if (string.IsNullOrEmpty(Empolyees.Name))
            {
                throw new Exception("Name is Required");
            }
        }
    }
}
