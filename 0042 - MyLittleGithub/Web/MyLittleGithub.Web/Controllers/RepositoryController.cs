using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using MyLittleGithub.Services.Data.Interfaces;
using MyLittleGithub.Web.Infrastructure.Extensions;
using MyLittleGithub.Web.ViewModels;
using MyLittleGithub.Web.ViewModels.InputModels.Repository;
using MyLittleGithub.Web.ViewModels.Repository;

namespace MyLittleGithub.Web.Controllers;

public class RepositoryController : BaseController
{
    private const int ItemsPerPage = 6;

    private readonly ILicenseService licenseService;
    private readonly IRepositoryService repositoryService;
    private readonly IWebHostEnvironment webHostEnvironment;
    private readonly IRepositoryStarService repositoryStarService;

    public RepositoryController(
        ILicenseService licenseService,
        IRepositoryService repositoryService,
        IWebHostEnvironment webHostEnvironment,
        IRepositoryStarService repositoryStarService)
    {
        this.licenseService = licenseService;
        this.repositoryService = repositoryService;
        this.webHostEnvironment = webHostEnvironment;
        this.repositoryStarService = repositoryStarService;
    }

    [HttpGet]
    public async Task<IActionResult> Create()
        => this.View(new CreateRepositoryInputModel { Licenses = await this.licenseService.GetAllAsKeyValuePair() });

    [HttpPost]
    public async Task<IActionResult> Create(CreateRepositoryInputModel inputModel)
    {
        if (!this.ModelState.IsValid)
        {
            inputModel.Licenses = await this.licenseService.GetAllAsKeyValuePair();
            return this.View(inputModel);
        }

        await this.repositoryService.CreateAsync(inputModel, this.User.GetId(), this.webHostEnvironment.WebRootPath);

        return this.Redirect("/");
    }

    [HttpGet]
    public async Task<IActionResult> All(string searchPhrase, int id = 1)
    {
        var repositories = await this.repositoryService.GetAllAsync<RepositoryViewModel>(id, searchPhrase);
        var privateRepositories = await this.repositoryService.GetPrivatesAsync<RepositoryViewModel>(this.User.GetId());

        var viewModel = new ListRepositoriesViewModel
        {
            Repositories = repositories.Skip((id - 1) * ItemsPerPage).Take(ItemsPerPage),
            PrivateRepositories = privateRepositories,
            Count = repositories.Count(),
            ItemsPerPage = 6,
            PageNumber = id,
            SearchPhrase = searchPhrase,
        };

        return this.View(viewModel);
    }

    [HttpGet]
    public async Task<IActionResult> Details(string id, string path)
    {
        var repositoryDetailsViewModel = await this.repositoryService.GetAsync<RepositoryDetailsViewModel>(id);
        repositoryDetailsViewModel.IsCurrentUserOwner = this.repositoryService.IsUserOwner(this.User.GetId(), id);

        if (string.IsNullOrEmpty(path))
        {
            path = $"{repositoryDetailsViewModel.FilesPath}";
        }

        var repositoryFolders = Directory.GetDirectories($"{this.webHostEnvironment.WebRootPath}{path}");
        repositoryDetailsViewModel.Folders = repositoryFolders
            .Select(folder => new FileViewModel
            {
                Name = Path.GetFileName(folder),
                Path = $"/{Path.GetRelativePath(this.webHostEnvironment.WebRootPath, folder)}",
                Size = new DirectoryInfo(folder).EnumerateFiles("*", SearchOption.AllDirectories).Sum(file => file.Length) * 0.001,
                LastModified = new FileInfo(folder).LastWriteTime,
                CreatedOn = new FileInfo(folder).CreationTime,
            })
            .ToList();

        var repositoryFiles = Directory.GetFiles($"{this.webHostEnvironment.WebRootPath}{path}");
        repositoryDetailsViewModel.Files = repositoryFiles
            .Select(file => new FileViewModel
            {
                Name = Path.GetFileName(file),
                Path = $"/{Path.GetRelativePath(this.webHostEnvironment.WebRootPath, file)}",
                Size = new FileInfo(file).Length * 0.001,
                LastModified = new FileInfo(file).LastWriteTime,
                CreatedOn = new FileInfo(file).CreationTime,
            })
            .ToList();

        return this.View(repositoryDetailsViewModel);
    }

    [HttpPost]
    public async Task<IActionResult> Star(string repositoryId)
    {
        var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

        if (!this.repositoryStarService.IsExisting(repositoryId, userId))
        {
            await this.repositoryStarService.Create(repositoryId, userId);
        }
        else
        {
            await this.repositoryStarService.Delete(repositoryId, userId);
        }

        return this.RedirectToAction("Details", "Repository", new { id = repositoryId });
    }

    [HttpGet]
    public async Task<IActionResult> Edit(string repositoryId)
    {
        if (!this.repositoryService.IsUserOwner(this.User.GetId(), repositoryId))
        {
            return this.RedirectToAction(nameof(this.Details), new { id = repositoryId });
        }

        var viewModel = await this.repositoryService.GetByIdAsync<EditRepositoryInputModel>(repositoryId);
        viewModel.Licenses = await this.licenseService.GetAllAsKeyValuePair();

        return this.View(viewModel);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(EditRepositoryInputModel inputModel, string repositoryId)
    {
        if (!this.ModelState.IsValid)
        {
            inputModel.Licenses = await this.licenseService.GetAllAsKeyValuePair();
            return this.View(inputModel);
        }

        await this.repositoryService.UpdateAsync(inputModel, repositoryId);

        return this.RedirectToAction(nameof(this.Details), new { id = repositoryId });
    }
}
