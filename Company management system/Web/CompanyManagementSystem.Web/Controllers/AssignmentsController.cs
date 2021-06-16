using System.Security.Claims;
using System.Threading.Tasks;

using CompanyManagementSystem.Services.Data;
using CompanyManagementSystem.Web.ViewModels.Assignments;
using CompanyManagementSystem.Web.ViewModels.Users;
using Microsoft.AspNetCore.Mvc;

namespace CompanyManagementSystem.Web.Controllers
{
    public class AssignmentsController : Controller
    {
        private readonly IUsersService usersService;
        private readonly IAssignmentsService assignmentsService;

        public AssignmentsController(
            IUsersService usersService,
            IAssignmentsService assignmentsService)
        {
            this.usersService = usersService;
            this.assignmentsService = assignmentsService;
        }

        [HttpGet]
        public async Task<IActionResult> Give()
            => this.View(new GiveAssignmentInputModel()
            {
                Employees = await this.usersService
                    .GetAllAsKeyValuePairsAsync(this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value),
            });

        [HttpPost]
        public async Task<IActionResult> Give(GiveAssignmentInputModel input, string employeeId)
        {
            await this.assignmentsService
                .GiveAsync(input, employeeId);

            return this.Redirect("/");
        }

        public async Task<IActionResult> All()
        {
            var assignments = await this.assignmentsService
                .All<AllAssignmentsViewModel>(this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            return this.View(assignments);
        }
    }
}
