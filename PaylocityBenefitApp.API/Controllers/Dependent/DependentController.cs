using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PaylocityBenefitApp.API.Domain.Entities;
using PaylocityBenefitApp.API.Application.Services.Employee.Interfaces;

namespace PaylocityBenefitApp.API.Controllers.Dependent
{
    [Route("api/[controller]")]
    [ApiController]
    public class DependentController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public DependentController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpPost]
        [Route("/dependent")]
        public async Task<ActionResult> AddDependent([FromBody] DependentEntity dependent)
        {
            

            return Ok();

        }


    }
}