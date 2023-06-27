using System.Diagnostics;
using System.Threading.Tasks;
using HRCloud.Services.Data.Interfaces;
using HRCloud.Web.ViewModels;
using HRCloud.Web.ViewModels.Departments;
using Microsoft.AspNetCore.Mvc;

namespace HRCloud.Web.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IDepartmentsService departmentsService;

        public HomeController(
            IDepartmentsService departmentsService)
        {
            this.departmentsService = departmentsService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = await this.departmentsService
                .GetAll<DepartmentViewModel>();

            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
