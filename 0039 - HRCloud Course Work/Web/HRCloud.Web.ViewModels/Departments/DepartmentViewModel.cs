using System;

using AutoMapper;
using HRCloud.Data.Models;
using HRCloud.Services.Mapping;

namespace HRCloud.Web.ViewModels.Departments
{
    public class DepartmentViewModel : IMapFrom<Department>, IHaveCustomMappings
    {
        public string Name { get; private set; }

        public string Description { get; private set; }

        public DateTime CreatedOn { get; private set; }

        public string CreatedOnAsString
            => this.CreatedOn.ToString("g");

        public int EmployeesCount { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Department, DepartmentViewModel>()
                 .ForMember(m => m.EmployeesCount, opt => opt.MapFrom(o => o.Employees.Count));
        }
    }
}
