using TheShop.Models.Dtos;

namespace TheShop.Web.Services
{
    public interface  ICountry
    {

        Task<IEnumerable<CountryDto>> GetCountries();

        Task<CountryDto> GetCountryById( int id );

    }
}
