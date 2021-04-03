using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace PaylocityBenefitApp.API.Application.Employee.Queries.GetEmployee
{
    public class GetEmployeeQuery : IRequest<GetEmployeeResponseModel>
    {
       public int EmployeeId { get; set; }
    }
}