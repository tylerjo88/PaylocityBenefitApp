using MediatR;
using PaylocityBenefitApp.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;


namespace PaylocityBenefitApp.API.Application.Dependent.Commands.AddDependent
{
    public class AddDependentCommand : IRequest<AddDependentResponseModel>
    {
        public DependentEntity Dependent { get; set; }
    }
}