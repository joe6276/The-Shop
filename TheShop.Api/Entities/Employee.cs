using System.ComponentModel.DataAnnotations.Schema;
using TheShop.Models;

namespace TheShop.Entities
{
    public class Employee
    {
        public  int  Id { get; set; }

        public Gender gender { get; set; } = default!;

        public string Name { get; set; } = string.Empty;

        public string Address { get; set; }=string.Empty;

        public string City { get; set; } = string.Empty;

        public MaritalStatus MaritalStatus { get; set; }

        public string Email { get; set; } = string.Empty;
        public double Longitude { get; set; } = 0;

        public double Latitude { get; set; } = 0;

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [ForeignKey("CountryId")]
        public Country Country { get; set; } = default!;

        public int CountryId { get; set; }

        [ForeignKey("JobCategoryId")]
        public JobCategory JobCategory { get; set; }=default!;

        public int JobCategoryId { get; set; }

        public string Image { get; set; } = string.Empty;

    }
}
