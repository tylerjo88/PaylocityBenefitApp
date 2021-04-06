using AutoMapper;
using BenefitCalculatorApp.Models;
using BenefitCalculatorApp.Models.ViewModels;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenefitCalculatorApp.Services
{
    public class EmployeeService : IEmployeeService
    { private readonly IMapper _mapper;

        public EmployeeService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<EmployeeViewModel> GetEmployeeProfileAsync(int employeeId)
        {
            var client = new RestClient("https://localhost:44361");

            var request = new RestRequest($"employee/{employeeId}");

            var employee = await client.GetAsync<EmployeeModel>(request);

            var employeeViewModel = _mapper.Map<EmployeeViewModel>(employee);

            this.CalculateBenefitDeductions(employeeViewModel);

            return employeeViewModel;

        }

        public EmployeeViewModel CalculateBenefitDeductions(EmployeeViewModel employee)
        {
            decimal totalBenefitDeduction = 1000.00M;

            decimal totalSalary = 26 * 2000M;

            if (employee.FirstName.StartsWith("A"))
            {
                totalBenefitDeduction = 1000M - (1000M * .20M); //Total Benefit - 20% Deduction
            }

            if (employee.Dependents.Any())
            {
                var totalDependentCount = employee.Dependents.Count;

                foreach (var dependent in employee.Dependents)
                {
                    totalBenefitDeduction += dependent.FirstName.StartsWith("A") ? 500M - (500M * .20M) :  500;
                }


            }

            employee.BenefitDeduction = totalBenefitDeduction;
            employee.TotalSalary = totalSalary - totalBenefitDeduction;

            return employee;
        }
    }
}