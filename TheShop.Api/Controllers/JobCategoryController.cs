using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheShop.Entities;
using TheShop.Interfaces;
using TheShop.Models.Dtos;

namespace TheShop.Controllers
{
    [Route("api/job")]
    [ApiController]
    public class JobCategoryController : ControllerBase
    {

        private readonly IJobCategory _jobCategory;
        private readonly IMapper _mapper;

        public JobCategoryController(IJobCategory jobCategory, IMapper mapper)
        {
            _jobCategory = jobCategory;
            _mapper = mapper;
         }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<JobCategoryDto>>> Get()
        {
            var jobcategories = await _jobCategory.GetJobCategoriesAsync();
            return Ok(_mapper.Map<IEnumerable<JobCategoryDto>>(jobcategories));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<JobCategoryDto>> Get(int id)
        {
            var jobCategory = await _jobCategory.GetJobCategoryAsync(id);
            return Ok(_mapper.Map<JobCategoryDto>(jobCategory));
        }


    }
}
