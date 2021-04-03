using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PaylocityBenefitApp.API.Domain.Entities
{
    public class DependentEntity 
    {
        public int DependentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Employee Employee { get; set; }
    }
}