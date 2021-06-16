using System.Diagnostics;
using System.Security.Claims;
using System.Threading.Tasks;

using CompanyManagementSystem.Services.Data;
using CompanyManagementSystem.Web.ViewModels;
using CompanyManagementSystem.Web.ViewModels.Users;
using Microsoft.AspNetCore.Mvc;

namespace CompanyManagementSystem.Web.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IUsersService usersService;

        public HomeController(IUsersService usersService)
        {
            this.usersService = usersService;
        }

        public async Task<IActionResult> Index()
        {
            return this.View();
        }

        public IActionResult Privacy()
            => this.View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
            => this.View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier,
            });
    }
}
