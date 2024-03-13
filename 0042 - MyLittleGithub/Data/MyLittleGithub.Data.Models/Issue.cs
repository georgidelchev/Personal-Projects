using System;
using System.ComponentModel.DataAnnotations;

using MyLittleGithub.Common;
using MyLittleGithub.Data.Common.Models;

namespace MyLittleGithub.Data.Models;

public class Issue : BaseDeletableModel<string>
{
    public Issue()
       => this.Id = Guid.NewGuid().ToString();

    [Required]
    [MaxLength(DatabaseModelsConstants.IssueNameMaxLength)]
    public string Name { get; set; }

    [Required]
    [MaxLength(DatabaseModelsConstants.IssueDescriptionMaxLength)]
    public string Description { get; set; }

    [Required]
    public string ApplicationUserId { get; set; }

    public ApplicationUser ApplicationUser { get; set; }

    public string RepositoryId { get; set; }

    public Repository Repository { get; set; }
}
