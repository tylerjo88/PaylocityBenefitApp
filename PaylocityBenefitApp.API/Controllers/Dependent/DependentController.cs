using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PaylocityBenefitApp.API.Application.Dependent.Commands.AddDependent;
using PaylocityBenefitApp.API.Domain.Entities;

namespace PaylocityBenefitApp.API.Controllers.Dependent
{
    [Route("api/[controller]")]
    public class DependentController : ControllerBase
    {
        private readonly IMediator _mediator;
        public DependentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("/dependent")]
        public async Task<ActionResult> AddDependent([FromBody] DependentEntity dependent)
        {
            var request = new AddDependentCommand() { 
                Dependent = dependent          
            };

            var response = await _mediator.Send(request);

            return Ok(response);

        }


    }
}