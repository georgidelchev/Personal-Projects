using MyLittleGithub.Services.Mapping;

namespace MyLittleGithub.Web.ViewModels.Issue;

public class IssueViewModel : IMapFrom<Data.Models.Issue>
{
    public string Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }
}
