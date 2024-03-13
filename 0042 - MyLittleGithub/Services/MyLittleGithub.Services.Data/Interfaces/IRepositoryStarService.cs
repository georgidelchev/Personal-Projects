using System.Threading.Tasks;

namespace MyLittleGithub.Services.Data.Interfaces;

public interface IRepositoryStarService
{
    Task Create(string repositoryId, string userId);

    Task Delete(string repositoryId, string userId);

    bool IsExisting(string repositoryId, string userId);
}
