using CompanyManagementSystem.Data.Models;
using CompanyManagementSystem.Services.Mapping;

namespace CompanyManagementSystem.Web.ViewModels.Assignments
{
    public class AllAssignmentsViewModel : IMapFrom<Assignment>
    {
        public string Content { get; set; }
    }
}