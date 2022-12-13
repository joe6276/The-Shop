using Microsoft.AspNetCore.Components;
using TheShop.Models.Dtos;

namespace TheShop.Web.Component
{
    public partial class QuickView
    {

        [Parameter]
        public EmployeeDto?  Employee { get; set; }

        private EmployeeDto? _employee;


        protected override void OnParametersSet()
        {
           _employee = Employee ;
        }

        private void OnClose()
        {
            _employee=null;
        }
    }
}
