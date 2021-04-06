using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace BenefitCalculatorApp.Models
{
    public class DependentModel : HumanModel
    {
        public int DependentId { get; set; }

        public EmployeeModel Employee { get; set; }
    }
}