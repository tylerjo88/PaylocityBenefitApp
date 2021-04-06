using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BenefitCalculatorApp.Models.ApiModels.Employee
{
    public class AddNewEmployeeResponse
    {
       public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<DependentModel> Dependents { get; set; }
    
    }
}