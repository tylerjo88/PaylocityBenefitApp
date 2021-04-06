using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BenefitCalculatorApp.Models.ViewModels
{
    public class EmployeeViewModel : HumanViewModel
    {
        public int EmployeeId { get; set; }
        public decimal BenefitDeduction { get; set; }
        public decimal TotalSalary { get; set; }
        public List<DependentViewModel> Dependents { get; set; }
    }
}