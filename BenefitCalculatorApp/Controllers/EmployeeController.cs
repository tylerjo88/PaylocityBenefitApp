using BenefitCalculatorApp.Models.ViewModels;
using BenefitCalculatorApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BenefitCalculatorApp.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
 

        /// <summary>
        /// Get Employee Profile by Employee ID
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> GetEmployeeProfile(int employeeId)
        {

            var employee = await _employeeService.GetEmployeeProfileAsync(employeeId);

            // Add action logic here
            return View("Pages/Views/Employee.cshtml", employee);
        }

        /// <summary>
        /// Add New Employee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> AddNewEmployee(EmployeeSubmitViewModel employee)
        {

            var newEmployee = await _employeeService.AddNewEmployeeAsync(employee);


            // Add action logic here
            return View("Pages/Views/Employee.cshtml", newEmployee);
        }


        /// <summary>
        /// Get Add Employee Page
        /// </summary>
        /// <returns></returns>
        public async Task<ActionResult> GetAddEmployeePage()
        {
            return View("Pages/Views/AddEmployee.cshtml");
        }

        /// <summary>
        /// Get Employee Lookup Page
        /// </summary>
        /// <returns></returns>
        public async Task<ActionResult> GetEmployeeLookupPage()
        {
            return View("Pages/Index.cshtml");
        }
    }
}