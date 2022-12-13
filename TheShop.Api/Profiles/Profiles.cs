using AutoMapper;
using TheShop.Models.Dtos;

namespace TheShop.Profiles
{
    public class Profiles : Profile
    {
        public Profiles()
        {
            CreateMap<EmployeeCreateDto ,Entities.Employee>().ReverseMap();
            CreateMap<EmployeeDto,Entities.Employee>().ReverseMap();
            CreateMap<Entities.Country, CountryDto>();
            CreateMap<Entities.JobCategory, JobCategoryDto>();
        }
    }
}
