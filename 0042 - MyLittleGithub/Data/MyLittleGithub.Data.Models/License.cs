using System;
using System.ComponentModel.DataAnnotations;

using MyLittleGithub.Common;
using MyLittleGithub.Data.Common.Models;

namespace MyLittleGithub.Data.Models;

public class License : BaseDeletableModel<string>
{
    public License()
      => this.Id = Guid.NewGuid().ToString();

    [Required]
    [MaxLength(DatabaseModelsConstants.LicenseNameMaxLength)]
    public string Name { get; set; }

    public string Description { get; set; }
}
