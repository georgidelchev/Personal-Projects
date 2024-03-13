using System.Collections.Generic;

using MyLittleGithub.Data.Models;
using MyLittleGithub.Web.ViewModels.Issue;

namespace MyLittleGithub.Web.ViewModels.Repository;

public class RepositoryDetailsViewModel : RepositoryViewModel
{
    public string ReadMe { get; set; }

    public string LicenseName { get; set; }

    public string ApplicationUserId { get; set; }

    public bool IsCurrentUserOwner { get; set; }

    public string FilesPath { get; set; }

    public ICollection<IssueViewModel> Issues { get; set; }

    public ICollection<RepositoryStar> RepositoryStars { get; set; }

    public ICollection<FileViewModel> Folders { get; set; }

    public ICollection<FileViewModel> Files { get; set; }
}
