using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace PaylocityBenefitApp.API.Application.Dependent.Commands.AddDependent
{
    public class AddDependentHandler : IRequestHandler<AddDependentCommand, AddDependentResponseModel>
    {
        public AddDependentHandler()
        {
           
        }

        public Task<AddDependentResponseModel> Handle(AddDependentCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}