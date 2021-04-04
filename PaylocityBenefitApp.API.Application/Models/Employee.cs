using System.Collections.Generic;


namespace PaylocityBenefitApp.API.Application.Models
{
    public class Employee : Human
    {
        public int EmployeeId { get;set; }
        public List<Dependent> Dependents {get;set;}
    }
}