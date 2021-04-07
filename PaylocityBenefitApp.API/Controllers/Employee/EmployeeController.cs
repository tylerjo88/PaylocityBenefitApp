using Microsoft.AspNetCore.Mvc;

using PaylocityBenefitApp.API.Application.Services.Employee.Interfaces;
using System;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using PaylocityBenefitApp.API.Application.ApiModels.Employee;

namespace PaylocityBenefitApp.API.Controllers.Employee
{

    [EnableCors(origins: "https://localhost:44388", headers: "*", methods: "*")]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {


        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        /// <summary>
        /// Get Employee by ID
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/employee/{employeeId}")]
        public async Task<ActionResult> GetEmployeeById(int employeeId)
        {

            try
            {

                var response = await _employeeService.GetEmployeeByIdAsync(employeeId);

                return Ok(response);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
           
            
        }


        /// <summary>
        /// Add New Employee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/employee")]
        public async Task<ActionResult> AddNewEmployee([FromBody] AddNewEmployeeRequest employee)
        {

            try
            {

                var response = await _employeeService.AddNewEmployeeAsync(employee);

                return Ok(response);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }

    }
}