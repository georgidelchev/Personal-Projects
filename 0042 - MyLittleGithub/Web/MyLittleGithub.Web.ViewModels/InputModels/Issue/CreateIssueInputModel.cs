using System.ComponentModel.DataAnnotations;

using MyLittleGithub.Common;

namespace MyLittleGithub.Web.ViewModels.InputModels.Issue;

public class CreateIssueInputModel
{
    [Required]
    [MinLength(DatabaseModelsConstants.IssueNameMinLength)]
    [MaxLength(DatabaseModelsConstants.IssueNameMaxLength)]
    public string Name { get; set; }

    [Required]
    [MinLength(DatabaseModelsConstants.IssueDescriptionMinLength)]
    [MaxLength(DatabaseModelsConstants.IssueDescriptionMaxLength)]
    public string Description { get; set; }

    public string ApplicationUserId { get; set; }

    public string RepositoryId { get; set; }
}
