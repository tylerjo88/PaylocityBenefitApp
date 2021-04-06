using BenefitCalculatorApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
 
        [HttpGet]
        public string Get()
        {
            // Add action logic here
            return "test controller";
        }

        [HttpPost]
        [AllowAnonymous]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> GetEmployeeProfile(int employeeId)
        {

            var employee = await _employeeService.GetEmployeeProfileAsync(employeeId);

            // Add action logic here
            return View("Pages/Views/Employee.cshtml", employee);
        }
    }
}