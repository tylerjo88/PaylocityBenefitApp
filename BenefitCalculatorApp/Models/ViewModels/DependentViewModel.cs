using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BenefitCalculatorApp.Models.ViewModels
{
    public class DependentViewModel: HumanViewModel
    {
        public int DependentId { get; set; }

        public EmployeeModel Employee { get; set; }
    }
}