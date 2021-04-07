using AutoMapper;
using BenefitCalculatorApp.Models;
using BenefitCalculatorApp.Models.ApiModels.Employee;
using BenefitCalculatorApp.Models.ViewModels;
using Newtonsoft.Json;
using RestSharp;
using System.Linq;
using System.Threading.Tasks;

namespace BenefitCalculatorApp.Services
{
    public class EmployeeService : IEmployeeService
    { private readonly IMapper _mapper;

        public EmployeeService(IMapper mapper)
        {
            _mapper = mapper;
        }

        /// <summary>
        /// Get Employee Profile
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public async Task<EmployeeViewModel> GetEmployeeProfileAsync(int employeeId)
        {
            var client = new RestClient("https://localhost:44361");
            var request = new RestRequest($"employee/{employeeId}");
            var employee = await client.GetAsync<EmployeeModel>(request);

            var employeeViewModel = _mapper.Map<EmployeeViewModel>(employee);

            if (employeeViewModel != null)
            {
                this.CalculateBenefitDeductions(employeeViewModel);
            }

            return employeeViewModel;
        }

        /// <summary>
        /// Add New Employee and Dependents
        /// </summary>
        /// <param name="employeeSubmit"></param>
        /// <returns></returns>
        public async Task<EmployeeViewModel> AddNewEmployeeAsync(EmployeeSubmitViewModel employeeSubmit)
        {

            var addRequest = new AddNewEmployeeRequest
            {
               
                    FirstName = employeeSubmit.FirstName,
                    LastName = employeeSubmit.LastName,
                    MiddleName = employeeSubmit.MiddleName,
                    DateOfBirth = employeeSubmit.DateOfBirth,
                    Dependents = employeeSubmit.Dependents
                
            };

            var client = new RestClient("https://localhost:44361");
            var request = new RestRequest($"employee", Method.POST)
                .AddJsonBody(addRequest);
            var employee = client.Execute(request);

            var responseContent = JsonConvert.DeserializeObject<AddNewEmployeeResponse>(employee.Content);

            var employeeProfile = await this.GetEmployeeProfileAsync(responseContent.EmployeeId);

            return employeeProfile;
        }

        /// <summary>
        /// Calculate Benefit Deductions for Employee and Dependents
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public EmployeeViewModel CalculateBenefitDeductions(EmployeeViewModel employee)
        {
            decimal totalBenefitDeduction = 1000.00M;

            decimal totalSalary = 26 * 2000M;

            if (employee.FirstName.StartsWith("A") || employee.FirstName.StartsWith("a"))
            {
                totalBenefitDeduction = 1000M - (1000M * .20M); //Total Benefit - 20% Deduction
            }
            employee.BenefitDeductionAmount = totalBenefitDeduction;

            if (employee.Dependents.Any())
            {
                foreach (var dependent in employee.Dependents)
                {
                    totalBenefitDeduction += (dependent.FirstName.StartsWith("A") || employee.FirstName.StartsWith("a")) ? 500M - (500M * .20M) :  500;
                    dependent.BenefitDeduction = dependent.FirstName.StartsWith("A") || employee.FirstName.StartsWith("a") ? 500M - (500M * .20M) : 500;
                }
            }
             
               
            employee.PaycheckDeduction = totalBenefitDeduction / 26;
            employee.BenefitDeduction = totalBenefitDeduction;
            employee.TotalSalary = totalSalary - totalBenefitDeduction;

            return employee;
        }
    }
}