
using TheShop.Models;

namespace TheShop.Request
{
    public class EmployeeCreation
    {

        public Gender gender { get; set; } = default!;

        public string Name { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public MaritalStatus MaritalStatus { get; set; }

        public string Email { get; set; } = string.Empty;
        public double Longitude { get; set; } = 0;

        public double Latitude { get; set; } = 0;
    }
}
