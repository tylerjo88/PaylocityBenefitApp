using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BenefitCalculatorApp.Models
{
    public class EmployeeModel : HumanModel
    {
        public int EmployeeId { get; set; }
      
        public List<DependentModel> Dependents { get; set; }
    }
}