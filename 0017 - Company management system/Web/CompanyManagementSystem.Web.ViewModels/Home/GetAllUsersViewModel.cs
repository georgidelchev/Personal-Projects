using CompanyManagementSystem.Data.Models;
using CompanyManagementSystem.Services.Mapping;

namespace CompanyManagementSystem.Web.ViewModels.Users
{
    public class GetAllUsersViewModel : IMapFrom<ApplicationUser>
    {
        public string Id { get; set; }

        public string Email { get; set; }

        public decimal Salary { get; set; }

        public string Role { get; set; }
    }
}
