using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BenefitCalculatorApp.Models.ViewModels
{
    public class EmployeeSubmitViewModel : HumanViewModel
    {
       public List<DependentModel> Dependents { get; set; }
    }
}