using System.ComponentModel.DataAnnotations;

namespace TheShop.Models.Dtos
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        [Required]
        public Gender gender { get; set; } = default!;
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Address { get; set; } = string.Empty;
        [Required]
        public string City { get; set; } = string.Empty;
        [Required]
        public MaritalStatus MaritalStatus { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        [Range(0.01, 100.00, ErrorMessage =" Longitude must be in the range of -90 and 90")]
        public double Longitude { get; set; } = 0;
        [Required]
        [Range(0.01, 100.00, ErrorMessage = " Latitude must be in the range of -90 and 90")]
        public double Latitude { get; set; } = 0;
        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [Required]
        public int CountryId { get; set; }
        [Required]
        public int JobCategoryId { get; set; }
        [Required]
        public string Image { get; set; } = string.Empty;
    }
}
