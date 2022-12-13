using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheShop.Entities;
using TheShop.Interfaces;
using TheShop.Models.Dtos;

namespace TheShop.Controllers
{
    [Route("api/country")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountry _country;
        private readonly IMapper _mapper;
        public CountryController(ICountry country, IMapper mapper)
        {
            _country =country;
            _mapper =mapper;
        }

        [HttpGet]
        public async Task <ActionResult<IEnumerable<Country>>> GetCountries()
        {
            var countries = await _country.GetCountriesAsync();
            return Ok(_mapper.Map<IEnumerable<CountryDto>>(countries));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Country>> GetCountry( int id )
        {
            var country = await _country.GetCountryById(id);
            return Ok( _mapper.Map<CountryDto>(country));
        }


    }
}
