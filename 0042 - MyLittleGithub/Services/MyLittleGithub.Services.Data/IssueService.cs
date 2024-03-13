using System.Threading.Tasks;

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyLittleGithub.Data.Common.Repositories;
using MyLittleGithub.Data.Models;
using MyLittleGithub.Services.Data.Interfaces;
using MyLittleGithub.Web.ViewModels.InputModels.Issue;

namespace MyLittleGithub.Services.Data;

public class IssueService : IIssueService
{
    private readonly IMapper mapper;
    private readonly IDeletableEntityRepository<Issue> issueRepository;

    public IssueService(
        IMapper mapper,
        IDeletableEntityRepository<Issue> issueRepository)
    {
        this.mapper = mapper;
        this.issueRepository = issueRepository;
    }

    public async Task Create(CreateIssueInputModel inputModel, string userId)
    {
        var issue = this.mapper.Map<Issue>(inputModel);
        issue.ApplicationUserId = userId;

        await this.issueRepository.AddAsync(issue);
        await this.issueRepository.SaveChangesAsync();
    }

    public async Task ResolveIssue(string issueId)
    {
        var issueModel = await this.issueRepository
            .All()
            .FirstOrDefaultAsync(i => i.Id == issueId);

        this.issueRepository.Delete(issueModel);
        await this.issueRepository.SaveChangesAsync();
    }
}
