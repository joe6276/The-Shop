namespace TheShop.Models.Dtos
{
    public class EmployeeCreateDto
    {

        public Gender gender { get; set; } = default!;

        public string Name { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public MaritalStatus MaritalStatus { get; set; }

        public string Email { get; set; } = string.Empty;
        public double Longitude { get; set; } = 0;

        public double Latitude { get; set; } = 0;

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public int CountryId { get; set; }

        public int JobCategoryId { get; set; }

        public string Image { get; set; } = string.Empty;

    }
}
