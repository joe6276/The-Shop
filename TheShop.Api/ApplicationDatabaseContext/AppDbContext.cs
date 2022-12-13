using Microsoft.EntityFrameworkCore;
using TheShop.Entities;
using TheShop.Models;

namespace TheShop.ApplicationDatabaseContext
{
    public class AppDbContext:DbContext
    {


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public  DbSet<Employee> Employees { get; set; }
        public DbSet<Country> Countries { get; set; }
        public  DbSet<JobCategory> JobCategories { get; set; }


        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            base.OnModelCreating (modelBuilder);

            modelBuilder.Entity<Country>().HasData(new Country { Id = 1, Name = "Belgium" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 2, Name = "Germany" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 3, Name = "Netherlands" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 4, Name = "USA" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 5, Name = "Japan" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 6, Name = "China" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 7, Name = "UK" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 8, Name = "France" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 9, Name = "Brazil" });


            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { Id = 1, Name = "Pie research" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { Id = 2, Name = "Sales" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { Id = 3, Name = "Management" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { Id = 4, Name = "Store staff" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { Id = 5, Name = "Finance" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { Id = 6, Name = "QA" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { Id = 7, Name = "IT" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { Id = 8, Name = "Cleaning" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { Id = 9, Name = "Bakery" });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 1,
                CountryId = 1,
                MaritalStatus = MaritalStatus.Single,
                City = "Atlanta",
                Email="john@gmail.com",
                Name = "John",
                Address="123, Atl",
                Image= "https://b.fssta.com/uploads/application/wwe/headshots/roman-reigns.png",
                gender =Gender.Male,
                Latitude = 50.8503,
                Longitude = 4.3517,
                JobCategoryId=3
            });;

        }

    }
}
