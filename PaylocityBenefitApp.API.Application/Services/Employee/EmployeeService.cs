using PaylocityBenefitApp.API.Application.Services.Employee.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;


namespace PaylocityBenefitApp.API.Application.Services.Employee
{
    public class EmployeeService : IEmployeeService
    {

        private readonly DbContext _humanResourceDbContext;

        public EmployeeService(DbContext humanResourceDbContext)
        {
            _humanResourceDbContext = humanResourceDbContext;
        }

        public async Task<Domain.Entities.Employee> GetEmployeeByIdAsync(int employeeId)
        {
            // Get Employee Profile from DB
            try
            {
                //Call to DB
                var dbResult = await _humanResourceDbContext.FindAsync<Domain.Entities.Employee>(employeeId);


                return dbResult;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}