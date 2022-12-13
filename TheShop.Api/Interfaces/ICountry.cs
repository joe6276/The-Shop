using TheShop.Entities;

namespace TheShop.Interfaces
{
    public interface ICountry
    {

        Task<IEnumerable<Country>> GetCountriesAsync();

        Task<Country> GetCountryById(int id);

    }
}
