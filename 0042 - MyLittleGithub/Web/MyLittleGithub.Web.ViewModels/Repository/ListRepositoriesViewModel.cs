using System.Collections.Generic;

namespace MyLittleGithub.Web.ViewModels.Repository;

public class ListRepositoriesViewModel : PagingViewModel
{
    public IEnumerable<RepositoryViewModel> PrivateRepositories { get; set; }

    public IEnumerable<RepositoryViewModel> Repositories { get; set; }
}
