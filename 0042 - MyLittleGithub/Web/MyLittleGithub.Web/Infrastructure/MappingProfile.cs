using AutoMapper;
using MyLittleGithub.Data.Models;
using MyLittleGithub.Web.ViewModels.InputModels.Issue;
using MyLittleGithub.Web.ViewModels.InputModels.Repository;

namespace MyLittleGithub.Web.Infrastructure;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // Repository mapping profiles
        this.CreateMap<CreateRepositoryInputModel, Repository>();

        // Issue mapping profiles
        this.CreateMap<CreateIssueInputModel, Issue>();
    }
}
