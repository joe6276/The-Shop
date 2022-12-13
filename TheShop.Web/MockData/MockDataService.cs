using TheShop.Web.Model;

namespace TheShop.Web.MockData
{
    public class MockDataService
    {

        private static List<Employee>? _employees = default!;
        private static List<JobCategory>? _jobCategory = default!;
        private static List<Country> _countries = default!;
        

     public static List<Employee> Employees
        {
            get
            {
                _countries ??= InitializeMockCountries();
                _jobCategory ??= InitializeMockCategories();
                _employees ??= InitializeMockEmployees();
                return _employees;
            }
        }

        public static List <JobCategory> InitializeMockCategories()
        {
            return new List<JobCategory>()
            {
                new JobCategory(1, "Software Developer"),
                new JobCategory(2, "Program Manager"),
                new JobCategory(3, "Program Analyst"),
                new JobCategory(4, "CTO"),
                new JobCategory(5, "COO")
             };
        }

        public static List<Country> InitializeMockCountries()
        {
            return new List<Country>
            {
                new Country (1, "Kenya"),
                new Country (2,"Uganda"),
                new Country (3, "Rwanda"),
                new Country (4,"Burundi")
            };
        }

        public static List<Employee> InitializeMockEmployees()
        {

            var e1 = new Employee(1, "John Papa", new DateTime(1999, 12, 12),"john@gmail.com",_countries[0], "+254712584549", new DateTime(2021, 10, 10), _jobCategory[2], MaritalStatus.Married, Gender.Male,
                "https://www.dmarge.com/wp-content/uploads/2021/01/dwayne-the-rock-.jpg");
            var e2 = new Employee(2, "Doe", new DateTime(1999, 12, 12), "john@gmail.com", _countries[2], "+254712584549", new DateTime(2021, 10, 10), _jobCategory[2], MaritalStatus.Married, Gender.Female,
                "https://cdn2.psychologytoday.com/assets/styles/manual_crop_1_91_1_1528x800/public/field_blog_entry_images/2018-09/shutterstock_648907024.jpg?itok=7lrLYx-B");
            var e3 = new Employee(3, "Bob", new DateTime(1999, 12, 12), "bob@gmail.com", _countries[1], "+254712584549", new DateTime(2021, 10, 10), _jobCategory[2], MaritalStatus.Married, Gender.Male,
                "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a0/Pierre-Person.jpg/1200px-Pierre-Person.jpg");
            var e4 = new Employee(4, string.Empty, new DateTime(1999, 12, 12), "alice@gmail.com", _countries[3], "+254712584549", new DateTime(2021, 10, 10), _jobCategory[2], MaritalStatus.Married, Gender.Female,
                "https://www.incimages.com/uploaded_files/image/1920x1080/getty_624206636_200013332000928034_376810.jpg");

            return new List<Employee>() { e1, e2,e3, e4 };
        }
    }
}
