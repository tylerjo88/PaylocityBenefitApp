using MediatR;
using PaylocityBenefitApp.API.Application.Services.Employee.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace PaylocityBenefitApp.API.Application.Employee.Queries.GetEmployee
{
    public class GetEmployeeHandler : IRequestHandler<GetEmployeeQuery, GetEmployeeResponseModel>
    {

        private readonly IEmployeeService _employeeService;
        public GetEmployeeHandler(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public async Task<GetEmployeeResponseModel> Handle(GetEmployeeQuery request, CancellationToken cancellationToken)
        {
            // Get Employee Profile From Databas4e
            var response = await _employeeService.GetEmployeeByIdAsync(request.EmployeeId);


            var responseModel = new GetEmployeeResponseModel
            {
                FirstName = response.FirstName
            };

            return responseModel;
        }
    }
}