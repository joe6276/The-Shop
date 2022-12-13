namespace TheShop.Web.Model
{
    public class Country
    {

        public int CountryId { get; set; }
        public string Name { get; set; } = string.Empty;

        public Country(int id , string CountryName)
        {
            CountryId = id;
            Name = CountryName;
        }
        
    }
}
