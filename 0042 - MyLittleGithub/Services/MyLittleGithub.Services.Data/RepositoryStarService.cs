using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using MyLittleGithub.Data.Common.Repositories;
using MyLittleGithub.Data.Models;
using MyLittleGithub.Services.Data.Interfaces;

namespace MyLittleGithub.Services.Data;

public class RepositoryStarService : IRepositoryStarService
{
    private readonly IRepository<RepositoryStar> repositoryStartRepository;

    public RepositoryStarService(
        IRepository<RepositoryStar> repositoryStartRepository)
    {
        this.repositoryStartRepository = repositoryStartRepository;
    }

    public async Task Create(string repositoryId, string userId)
    {
        var repositoryStarEntity = new RepositoryStar
        {
            ApplicationUserId = userId,
            RepositoryId = repositoryId,
        };

        await this.repositoryStartRepository.AddAsync(repositoryStarEntity);
        await this.repositoryStartRepository.SaveChangesAsync();
    }

    public async Task Delete(string repositoryId, string userId)
    {
        var repositoryStarModel = await this.repositoryStartRepository
            .All()
            .FirstOrDefaultAsync(rs => rs.RepositoryId == repositoryId &&
                                       rs.ApplicationUserId == userId);

        this.repositoryStartRepository.Delete(repositoryStarModel);
        await this.repositoryStartRepository.SaveChangesAsync();
    }

    public bool IsExisting(string repositoryId, string userId)
        => this.repositoryStartRepository
            .All()
            .Any(rs => rs.RepositoryId == repositoryId &&
                       rs.ApplicationUserId == userId);
}
