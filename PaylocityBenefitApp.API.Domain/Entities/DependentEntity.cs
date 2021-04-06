using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;


namespace PaylocityBenefitApp.API.Domain.Entities
{
    [Table("Dependent", Schema = "Paylocity")]
    public class DependentEntity 
    {
        [Key]
        public int DependentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public EmployeeEntity Employee { get; set; }
    }
}