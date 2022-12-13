namespace TheShop.Web.Model
{
    public class Employee
    {
      

        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }

        public DateTime BirthDate { get; set; }
        public string Email { get; set; } = string.Empty;

        public Country Country { get; set; } = default!;

        public string Phone { get; set; } = string.Empty;

        public DateTime? JoinedDate { get; set; }

        public Gender Gender { get; set; }
        public JobCategory JobCategory { get; set; } = default!;

        public MaritalStatus MaritalStatus { get; set; }=default!;

        public string img { get; set; } = string.Empty;

        public  Employee( int id , string name , DateTime birthDate, string email,  Country country, string phone ,DateTime join , JobCategory job, MaritalStatus marital, Gender gender, string image)
        {
            EmployeeID = id;
            EmployeeName = name;
            BirthDate = birthDate;
            Email = email;
            Country = country;
            Phone = phone;
            JoinedDate = join;
            JobCategory = job;
            MaritalStatus = marital;
            Gender = gender;
            img= image; 
        }

  
    }

    }
