using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PaylocityBenefitApp.API.Application.Models
{
    public class Dependent : Human
    {
        public Employee Employee { get; set; }
    }
}