using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using MyLittleGithub.Common;

namespace MyLittleGithub.Web.ViewModels.InputModels.Repository;

public class CreateRepositoryInputModel
{
    [Required(ErrorMessage = "Name field is required")]
    [MinLength(DatabaseModelsConstants.RepositoryNameMinLength)]
    [MaxLength(DatabaseModelsConstants.RepositoryNameMaxLength)]
    public string Name { get; set; }

    [MaxLength(DatabaseModelsConstants.RepositoryDescriptionMaxLength, ErrorMessage = "Max length of Description should be 500 characters max.")]
    public string Description { get; set; }

    [DisplayName("Private Repository")]
    public bool IsPrivate { get; set; }

    [MaxLength(DatabaseModelsConstants.RepositoryReadMeMaxLength, ErrorMessage = "Max length of Read Me should be 5000 characters max.")]
    public string ReadMe { get; set; }

    [Required(ErrorMessage = "A License is required. Select 'No License' if you want to dismiss it!")]
    public string LicenseId { get; set; }

    public IEnumerable<KeyValuePair<string, string>> Licenses { get; set; }
}
