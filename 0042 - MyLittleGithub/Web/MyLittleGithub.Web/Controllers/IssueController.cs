using System.Security.Claims;
using System.Threading.Tasks;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyLittleGithub.Services.Data.Interfaces;
using MyLittleGithub.Web.Infrastructure.Extensions;
using MyLittleGithub.Web.ViewModels.InputModels.Issue;

namespace MyLittleGithub.Web.Controllers
{
    public class IssueController : BaseController
    {
        private readonly IIssueService issueService;

        public IssueController(IIssueService issueService)
        {
            this.issueService = issueService;
        }

        [HttpGet]
        public IActionResult Create()
            => this.View();

        [HttpPost]
        public async Task<IActionResult> Create(CreateIssueInputModel inputModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(inputModel);
            }

            await this.issueService.Create(inputModel, this.User.GetId());

            return this.RedirectToAction("Details", "Repository", new { id = inputModel.RepositoryId });
        }

        [HttpPost]
        public async Task<IActionResult> Resolve(string issueId, string repositoryId)
        {
            await this.issueService.ResolveIssue(issueId);

            return this.RedirectToAction("Details", "Repository", new { id = repositoryId });
        }
    }
}
