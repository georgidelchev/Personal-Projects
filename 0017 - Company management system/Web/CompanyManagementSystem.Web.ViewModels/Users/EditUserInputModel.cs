using System.ComponentModel.DataAnnotations;

using CompanyManagementSystem.Data.Models;
using CompanyManagementSystem.Services.Mapping;

namespace CompanyManagementSystem.Web.ViewModels.Users
{
    public class EditUserInputModel : IMapFrom<ApplicationUser>
    {
        [Required]
        [Range(typeof(decimal), "650", "100000")]
        public decimal Salary { get; set; }
    }
}