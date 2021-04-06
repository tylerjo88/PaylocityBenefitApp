using AutoMapper;
using PaylocityBenefitApp.API.Application.ApiModels.Employee;
using PaylocityBenefitApp.API.Application.Models;
using PaylocityBenefitApp.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PaylocityBenefitApp.API.Application.Infrastructure
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<AddNewEmployeeRequest, EmployeeEntity>();
            CreateMap<DependentEntity, Dependent>().ReverseMap();
            CreateMap<EmployeeEntity, Employee>();
        }
    }
}