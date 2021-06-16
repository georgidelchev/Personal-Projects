using System.Collections.Generic;

namespace CompanyManagementSystem.Web.ViewModels.Users
{
    public class ListAllUsersViewModel
    {
        public IEnumerable<GetAllUsersViewModel> AllUsers { get; set; }
    }
}
