using PaylocityBenefitApp.API.Application.Services.Employee.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using PaylocityBenefitApp.API.Persistence.DbContexts;
using PaylocityBenefitApp.API.Application.Models;
using AutoMapper;
using PaylocityBenefitApp.API.Application.ApiModels.Employee;
using PaylocityBenefitApp.API.Domain.Entities;

namespace PaylocityBenefitApp.API.Application.Services.Employee
{
    public class EmployeeService : IEmployeeService
    {

        private readonly HumanResourceDbContext _humanResourceDbContext;
        private readonly IMapper _mapper;

        public EmployeeService(HumanResourceDbContext humanResourceDbContext, IMapper mapper)
        {
            _humanResourceDbContext = humanResourceDbContext;
            _mapper = mapper;
        }

        public async Task<Models.Employee> GetEmployeeByIdAsync(int employeeId)
        {
            // Get Employee Profile from DB
            try
            {
                //Call to DB
                var dbResult = _humanResourceDbContext.Employee.Include(emp => emp.Dependents).ToList().Where(a => a.EmployeeId == employeeId).FirstOrDefault();


                var mappedModel = _mapper.Map<Models.Employee>(dbResult);
                return mappedModel;

                
 
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<AddNewEmployeeResponse> AddNewEmployeeAsync(AddNewEmployeeRequest request)
        {
            try
            {
                var empEntity = _mapper.Map<EmployeeEntity>(request);

                var dbResult = await _humanResourceDbContext.AddAsync(empEntity);
                await _humanResourceDbContext.SaveChangesAsync();

                return new AddNewEmployeeResponse
                {
                    EmployeeId = empEntity.EmployeeId,
                    FirstName = empEntity.FirstName,
                    LastName = empEntity.LastName,
                    MiddleName = empEntity.MiddleName,
                    DateOfBirth = empEntity.DateOfBirth
                };
            }
            catch (Exception ex)
            {

                throw;
            }
            

        }

    }
}