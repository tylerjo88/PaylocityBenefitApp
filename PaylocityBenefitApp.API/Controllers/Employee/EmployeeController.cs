using MediatR;
using Microsoft.AspNetCore.Mvc;

using PaylocityBenefitApp.API.Application.Services.Employee.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Cors;

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

    }
}