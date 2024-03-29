﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaylocityBenefitApp.API.Application.ApiModels.Employee;
using PaylocityBenefitApp.API.Domain.Entities;


namespace PaylocityBenefitApp.API.Application.Services.Employee.Interfaces
{
    public interface IEmployeeService 
    {
        Task<AddNewEmployeeResponse> AddNewEmployeeAsync(AddNewEmployeeRequest request);
        Task<Application.Models.Employee> GetEmployeeByIdAsync(int employeeId);
    }
}