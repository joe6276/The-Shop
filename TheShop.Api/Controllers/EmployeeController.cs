using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheShop.Entities;
using TheShop.Interfaces;
using TheShop.Models.Dtos;
using TheShop.Request;

namespace TheShop.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee _employee;
        private readonly IMapper _mapper;
        public EmployeeController(IEmployee employee,IMapper mapper)
        {
            _employee = employee;
            _mapper = mapper;
        }

        [HttpGet]
        public async  Task<ActionResult<IEnumerable<EmployeeDto>>> GetEmployee()
        {
            var employee = await _employee.GetEmployeesAsync();
            return Ok(_mapper.Map<IEnumerable<EmployeeDto>>(employee));
        }

        [HttpGet("id")]
        public async Task<ActionResult<EmployeeDto>> GetEmployee(  int id )
        {
            var employee = _mapper.Map<EmployeeDto>(await _employee.GetEmployeeAsync(id));
            if (employee == null)
            {
                return NotFound("user Not found");
            }
            return Ok(employee);
        }

        [HttpPost("signup")]
        public async Task<ActionResult<Employee>> PostEmployee(EmployeeCreateDto employee)
        {

            var createdPerson= _mapper.Map<Entities.Employee>(employee);
             var newEmployee= _employee.addEmployee(createdPerson);
            return Created("User:",newEmployee);
        }
        [HttpPut("update/{id}")]
        public async Task<ActionResult> updateEmployee(EmployeeCreateDto employee , int id)
        {
            var user = await _employee.GetEmployeeAsync(id);

            if (user==null)
            {
                return BadRequest("User Not Found");
            }

            _mapper.Map(employee, user);
            await _employee.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<string>> DeleteEmployee (int id)
        {
            var employee = await _employee.GetEmployeeAsync(id);
            if (employee == null)
            {
                return NotFound("Employee Not found");
            }
            _employee.DeleteEmployee(employee);
            await _employee.SaveChangesAsync();

            return Ok("User deleted");
        }

    }
}
