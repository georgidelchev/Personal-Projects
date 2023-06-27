using System.ComponentModel.DataAnnotations;

using HRCloud.Data.Models;
using HRCloud.Services.Mapping;
using Microsoft.AspNetCore.Mvc;

namespace HRCloud.Web.ViewModels.Employees
{
    public class EditEmployeeInputModel : IMapFrom<ApplicationUser>
    {
        [Required(ErrorMessage = "First name field is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Sur name field is required.")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Last name field is required.")]
        public string LastName { get; set; }

        [Phone]
        [Required(ErrorMessage = "Phone number field is required.")]
        public string PhoneNumber { get; set; }

        [Required]
        [Range(0.01, 100000, ErrorMessage = "Salary should be bigger than 0 and less than 100000.")]
        [Remote(
            action: "IsSalaryValid",
            controller: "Employees",
            HttpMethod = "GET",
            ErrorMessage = "Salary is out of given range.",
            AdditionalFields = "JobId")]
        public decimal Salary { get; set; }

        public int JobId { get; set; }
    }
}
