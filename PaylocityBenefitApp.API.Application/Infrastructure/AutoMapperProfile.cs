using AutoMapper;
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

            CreateMap<DependentEntity, Dependent>();
            CreateMap<EmployeeEntity, Employee>();
        }
    }
}