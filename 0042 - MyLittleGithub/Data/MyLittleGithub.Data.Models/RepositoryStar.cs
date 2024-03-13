using System.ComponentModel.DataAnnotations;

using MyLittleGithub.Data.Common.Models;

namespace MyLittleGithub.Data.Models;

public class RepositoryStar : BaseModel<int>
{
    [Required]
    public string ApplicationUserId { get; set; }

    public ApplicationUser ApplicationUser { get; set; }

    [Required]
    public string RepositoryId { get; set; }

    public Repository Repository { get; set; }
}
