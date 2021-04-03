using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaylocityBenefitApp.API.Domain.Entities;


namespace PaylocityBenefitApp.API.Application.Services.Employee.Interfaces
{
    public interface IEmployeeService 
    {
        Task<Domain.Entities.Employee> GetEmployeeByIdAsync(int employeeId);
    }
}