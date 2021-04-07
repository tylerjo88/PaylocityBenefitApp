namespace BenefitCalculatorApp.Models.ViewModels
{
    public class DependentViewModel : HumanViewModel
    {
        public int DependentId { get; set; }
        public decimal BenefitDeduction{get;set;}

        public EmployeeModel Employee { get; set; }
    }
}