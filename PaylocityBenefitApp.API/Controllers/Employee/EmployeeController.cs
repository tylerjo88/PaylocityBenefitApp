using MediatR;
using Microsoft.AspNetCore.Mvc;
using PaylocityBenefitApp.API.Application.Employee.Queries.GetEmployee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaylocityBenefitApp.API.Controllers.Employee
{
    public class EmployeeController : ControllerBase
    {


        private readonly IMediator _mediator;
        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/employee/{employeeId}")]
        public async Task<ActionResult> GetEmployeeById([FromQuery]int employeeId)
        {

            try
            {
     
                var response = await _mediator.Send(new GetEmployeeQuery()
                {
                    EmployeeId = employeeId
                });

                response.FirstName = "Tyler";

                return Ok(response);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
           
            
        }

    }
}