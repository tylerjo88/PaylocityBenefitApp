using BenefitCalculatorApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenefitCalculatorApp.Services
{
    public interface IEmployeeService
    {
        Task<EmployeeViewModel> GetEmployeeProfileAsync(int employeeId);
        Task<EmployeeViewModel> AddNewEmployeeAsync(EmployeeSubmitViewModel employeeSubmit);
    }
}