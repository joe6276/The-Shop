using TheShop.Entities;
using TheShop.Models.Dtos;

namespace TheShop.Api.Extesions
{
    public static class DtoConversions
    {
        public static EmployeeDto ConvertToDto(this Employee employee)
        {

            return new EmployeeDto
            {
                Id = employee.Id,

            };

        }

    }
}
