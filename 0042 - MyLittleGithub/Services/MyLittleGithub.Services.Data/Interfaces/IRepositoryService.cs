using System.Collections.Generic;
using System.Threading.Tasks;

using MyLittleGithub.Web.ViewModels.InputModels.Repository;

namespace MyLittleGithub.Services.Data.Interfaces;

public interface IRepositoryService
{
    Task CreateAsync(CreateRepositoryInputModel inputModel, string userId, string wwwRoot);

    Task<IEnumerable<T>> GetAllAsync<T>(int id, string searchPhrase);

    Task<IEnumerable<T>> GetPrivatesAsync<T>(string userId);

    Task<T> GetAsync<T>(string id);

    Task<T> GetByIdAsync<T>(string repositoryId);

    Task<bool> UpdateAsync(EditRepositoryInputModel inputModel, string repositoryId);

    bool IsUserOwner(string userId, string repositoryId);
}
