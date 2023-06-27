using System.Threading.Tasks;

using HRCloud.Services.Data.Interfaces;
using HRCloud.Web.ViewModels.Employees;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace HRCloud.Web.Controllers
{
    public class EmployeesController : BaseController
    {
        private readonly IJobsService jobsService;
        private readonly IEmployeesService employeesService;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IDepartmentsService departmentsService;

        public EmployeesController(
            IJobsService jobsService,
            IEmployeesService employeesService,
            IWebHostEnvironment webHostEnvironment,
            IDepartmentsService departmentsService)
        {
            this.jobsService = jobsService;
            this.employeesService = employeesService;
            this.webHostEnvironment = webHostEnvironment;
            this.departmentsService = departmentsService;
        }

        [HttpGet]
        public async Task<IActionResult> All(string departmentName)
        {
            if (!this.departmentsService.IsDepartmentExist(departmentName))
            {
                this.TempData["Error"] = "Department is invalid!";
                return this.Redirect("/");
            }

            var viewModel = new ListEmployeesViewModel
            {
                Employees = await this.employeesService.GetAllAsync<EmployeeViewModel>(departmentName),
                DepartmentName = departmentName,
            };

            return this.View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Create(string departmentSource)
        {
            if (!this.departmentsService.IsDepartmentExist(departmentSource))
            {
                this.TempData["Error"] = "Department is invalid!";
                return this.Redirect("/");
            }

            var viewModel = new CreateEmployeeInputModel
            {
                Mentors = await this.employeesService.GetAllAsKvpAsync(departmentSource),
                Jobs = await this.jobsService.GetAllAsKvp(),
                DepartmentName = departmentSource,
            };

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateEmployeeInputModel input)
        {
            if (!this.ModelState.IsValid || input.Image == null)
            {
                var viewModel = new CreateEmployeeInputModel
                {
                    Mentors = await this.employeesService.GetAllAsKvpAsync(input.DepartmentName),
                    Jobs = await this.jobsService.GetAllAsKvp(),
                    DepartmentName = input.DepartmentName,
                };

                return this.View(viewModel);
            }

            await this.employeesService.CreateAsync(input, this.webHostEnvironment.WebRootPath);

            var redirectUrl = $"/{this.ControllerContext.ActionDescriptor.ControllerName}/{nameof(this.All)}?departmentName={input.DepartmentName}";

            return this.Redirect(redirectUrl);
        }

        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            if (this.IsEmployeeExist(id, out var redirect))
            {
                return redirect;
            }

            var viewModel = await this.employeesService
                .GetDetailsAsync<EmployeeDetailsViewModel>(id);

            return this.View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {
            if (this.IsEmployeeExist(id, out var redirect))
            {
                return redirect;
            }

            await this.employeesService.DeleteAsync(id);

            return this.Redirect("/");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            if (this.IsEmployeeExist(id, out var redirect))
            {
                return redirect;
            }

            var viewModel = await this.employeesService
                .GetByIdAsync<EditEmployeeInputModel>(id);

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditEmployeeInputModel input, string id)
        {
            if (this.IsEmployeeExist(id, out var redirect))
            {
                return redirect;
            }

            await this.employeesService.EditAsync(input, id);
            return this.Redirect("/");
        }

        [HttpGet]
        public IActionResult DoesEmailExists(string email)
        {
            var result = this.employeesService
                .IsEmailExist(email);
            return this.Json(!result);
        }

        [HttpGet]
        public IActionResult IsSalaryValid(int jobId, decimal salary)
        {
            var result = this.jobsService
                .IsJobSalaryValid(jobId, salary);
            return this.Json(result);
        }

        private bool IsEmployeeExist(string id, out IActionResult redirect)
        {
            redirect = this.Redirect("/");

            if (!this.employeesService.IsEmployeeExistById(id))
            {
                this.TempData["Error"] = "Employee is invalid!";
                {
                    return true;
                }
            }

            return false;
        }
    }
}
