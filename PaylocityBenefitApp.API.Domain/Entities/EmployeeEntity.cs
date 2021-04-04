using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaylocityBenefitApp.API.Domain.Entities
{
    [Table("Employee", Schema = "Paylocity")]
    public class EmployeeEntity 
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public virtual IList<DependentEntity> Dependents { get; set; }
    }
}