using HRCloud.Data.Models;
using HRCloud.Services.Mapping;

namespace HRCloud.Web.ViewModels.Employees
{
    public class EmployeeViewModel : IMapFrom<ApplicationUser>
    {
        public string Id { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string SurName { get; set; }

        public string LastName { get; set; }

        public string FullName
            => $"{this.FirstName} {this.SurName} {this.LastName}";

        public string ImageUrl { get; set; }
    }
}
