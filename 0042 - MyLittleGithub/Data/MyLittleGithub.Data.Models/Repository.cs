using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using MyLittleGithub.Common;
using MyLittleGithub.Data.Common.Models;

namespace MyLittleGithub.Data.Models;

public class Repository : BaseDeletableModel<string>
{
    public Repository()
        => this.Id = Guid.NewGuid().ToString();

    [Required]
    [MaxLength(DatabaseModelsConstants.RepositoryNameMaxLength)]
    public string Name { get; set; }

    [MaxLength(DatabaseModelsConstants.RepositoryDescriptionMaxLength)]
    public string Description { get; set; }

    [Required]
    public bool IsPrivate { get; set; }

    [Required]
    [MaxLength(DatabaseModelsConstants.RepositoryReadMeMaxLength)]
    public string ReadMe { get; set; }

    [Required]
    public string LicenseId { get; set; }

    public License License { get; set; }

    [Required]
    public string ApplicationUserId { get; set; }

    public ApplicationUser ApplicationUser { get; set; }

    public string FilesPath { get; set; }

    public virtual ICollection<RepositoryStar> RepositoryStars { get; set; }
        = new HashSet<RepositoryStar>();

    public virtual ICollection<Issue> Issues { get; set; }
        = new HashSet<Issue>();
}
