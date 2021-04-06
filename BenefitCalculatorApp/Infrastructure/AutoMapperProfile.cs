using AutoMapper;
using BenefitCalculatorApp.Models;
using BenefitCalculatorApp.Models.ApiModels.Employee;
using BenefitCalculatorApp.Models.ViewModels;


namespace BenefitCalculatorApp.Infrastructure
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<AddNewEmployeeResponse, EmployeeViewModel>();
            CreateMap<HumanModel, HumanViewModel>();
            CreateMap<DependentModel, DependentViewModel>();
            CreateMap<EmployeeModel, EmployeeViewModel>();
        }
    }
}