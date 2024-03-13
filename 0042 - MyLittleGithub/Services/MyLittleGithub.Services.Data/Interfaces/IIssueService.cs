using System.Threading.Tasks;

using MyLittleGithub.Web.ViewModels.InputModels.Issue;

namespace MyLittleGithub.Services.Data.Interfaces;

public interface IIssueService
{
    Task Create(CreateIssueInputModel inputModel, string userId);

    Task ResolveIssue(string issueId);
}
