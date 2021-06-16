using System.Security.Claims;
using System.Threading.Tasks;

using CompanyManagementSystem.Services.Data;
using CompanyManagementSystem.Web.ViewModels.Users;
using Microsoft.AspNetCore.Mvc;

namespace CompanyManagementSystem.Web.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUsersService usersService;

        public UsersController(IUsersService usersService)
        {
            this.usersService = usersService;
        }

        [HttpGet]
        public IActionResult Create()
            => this.View();

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserInputModel input)
        {
            var managerId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            await this.usersService.CreateAsync(managerId, input);
            return this.Redirect("/");
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var id = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            ;
            return this.View(new ListAllUsersViewModel()
            {
                AllUsers = await this.usersService
                    .GetAllAsync<GetAllUsersViewModel>(id),
            });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {
            await this.usersService.DeleteAsync(id);
            return this.Redirect("/");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var viewModel = this.usersService.GetByModel<EditUserInputModel>(id);

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditUserInputModel input, string id)
        {
            await this.usersService.EditAsync(input, id);

            return this.RedirectToAction(nameof(this.GetAll));
        }
    }
}
