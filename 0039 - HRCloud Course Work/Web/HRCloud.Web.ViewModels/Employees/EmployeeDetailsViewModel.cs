using System;

using AutoMapper;
using HRCloud.Data.Models;
using HRCloud.Services.Mapping;

namespace HRCloud.Web.ViewModels.Employees
{
    public class EmployeeDetailsViewModel : EmployeeViewModel, IHaveCustomMappings
    {
        public DateTime HireDate { get; set; }

        public string HireDateAsString
            => this.HireDate.ToString("g");

        public string PhoneNumber { get; set; }

        public string DepartmentName { get; set; }

        public string JobName { get; set; }

        public string MentorId { get; set; }

        public string Salary { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<ApplicationUser, EmployeeDetailsViewModel>()
                .ForMember(m => m.MentorId, mo => mo.MapFrom(s => s.ApplicationUserId));
        }
    }
}
