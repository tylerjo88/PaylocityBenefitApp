using PaylocityBenefitApp.API.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PaylocityBenefitApp.API.Application.ApiModels.Employee
{
    public class AddNewEmployeeRequest 
    {
       public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Dependent> Dependents { get; set; }
    }
}