using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PaylocityBenefitApp.API.Domain.Entities;

;

namespace PaylocityBenefitApp.API.Persistence.DbContexts
{
    public class HumanResourceDbContext : DbContext
    {

        public DbSet<EmployeeEntity> Employee { get; set; }
        public DbSet<DependentEntity> Dependent { get; set; }

        public HumanResourceDbContext(DbContextOptions<HumanResourceDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<EmployeeEntity>().ToTable("Employee");
           
        }


    }
}
