using System.Collections.Generic;


namespace BenefitCalculatorApp.Models.ViewModels
{
    public class EmployeeViewModel : HumanViewModel
    {
        public int EmployeeId { get; set; }
        public decimal BenefitDeduction { get; set; }
        public decimal TotalSalary { get; set; }
        public decimal PaycheckDeduction { get; set; }
        public decimal BenefitDeductionAmount { get; set; }
        public List<DependentViewModel> Dependents { get; set; }
    }
}