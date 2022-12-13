namespace TheShop.Web.Model
{
    public class JobCategory
    {

        public int JobCategoryId { get; set; }

        public string JobCategoryName { get; set; }=string.Empty;

        public JobCategory(int jobcat , string name)
        {
            JobCategoryId = jobcat;
            JobCategoryName = name;
        }
    }
}
