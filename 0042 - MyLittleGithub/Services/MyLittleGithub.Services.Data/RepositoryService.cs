using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyLittleGithub.Data.Common.Repositories;
using MyLittleGithub.Data.Models;
using MyLittleGithub.Services.Data.Interfaces;
using MyLittleGithub.Services.Mapping;
using MyLittleGithub.Web.ViewModels.InputModels.Repository;
using MyLittleGithub.Web.ViewModels.License;

namespace MyLittleGithub.Services.Data;

public class RepositoryService : IRepositoryService
{
    private readonly IMapper mapper;
    private readonly ILicenseService licenseService;
    private readonly IDeletableEntityRepository<Repository> repository;

    public RepositoryService(
        IMapper mapper,
        ILicenseService licenseService,
        IDeletableEntityRepository<Repository> repository)
    {
        this.mapper = mapper;
        this.licenseService = licenseService;
        this.repository = repository;
    }

    public async Task CreateAsync(CreateRepositoryInputModel inputModel, string userId, string wwwRootPath)
    {
        var projectPath = this.GetProjectFilesPath();

        var repositoryModel = this.mapper.Map<Repository>(inputModel);
        repositoryModel.ApplicationUserId = userId;
        repositoryModel.FilesPath = projectPath;

        await this.SaveLicenseFile(inputModel, $"{wwwRootPath}{projectPath}");

        await this.repository.AddAsync(repositoryModel);
        await this.repository.SaveChangesAsync();
    }

    public async Task<IEnumerable<T>> GetAllAsync<T>(int id, string searchPhrase)
    {
        var repositories = this.repository
            .All()
            .Where(r => !r.IsPrivate);

        if (!string.IsNullOrEmpty(searchPhrase))
        {
            repositories = repositories.Where(r =>
                r.Name.Contains(searchPhrase) ||
                r.Description.Contains(searchPhrase) ||
                r.ReadMe.Contains(searchPhrase));
        }

        return await repositories
            .OrderByDescending(r => r.CreatedOn)
            .To<T>()
            .ToListAsync();
    }

    public async Task<IEnumerable<T>> GetPrivatesAsync<T>(string userId)
        => await this.repository
            .All()
            .Where(r => r.ApplicationUserId == userId && r.IsPrivate)
            .To<T>()
            .ToListAsync();

    public async Task<T> GetAsync<T>(string id)
        => await this.repository
            .All()
            .Where(r => r.Id == id)
            .Include(r => r.License)
            .Include(r => r.Issues)
            .Include(r => r.RepositoryStars)
            .To<T>()
            .FirstOrDefaultAsync();

    public async Task<T> GetByIdAsync<T>(string repositoryId)
        => await this.repository
            .All()
            .Where(r => r.Id == repositoryId)
            .To<T>()
            .FirstOrDefaultAsync();

    public async Task<bool> UpdateAsync(EditRepositoryInputModel inputModel, string repositoryId)
    {
        var repositoryEntity = await this.repository
            .All()
            .FirstOrDefaultAsync(r => r.Id == repositoryId);

        this.mapper.Map(inputModel, repositoryEntity);

        this.repository.Update(repositoryEntity);

        return await this.repository.SaveChangesAsync() > 0;
    }

    public bool IsUserOwner(string userId, string repositoryId)
        => this.repository
            .All()
            .FirstOrDefault(r => r.Id == repositoryId)
            ?.ApplicationUserId == userId;

    private async Task SaveLicenseFile(CreateRepositoryInputModel inputModel, string projectPath)
    {
        var filePath = $"{projectPath}/LICENSE.txt";

        var license = this.licenseService.Get<LicenseViewModel>(inputModel.LicenseId);

        Directory.CreateDirectory(projectPath);

        await using var streamWriter = new StreamWriter(filePath);

        await streamWriter.WriteLineAsync(license.Name);
        await streamWriter.WriteLineAsync(license.Description);
    }

    private string GetProjectFilesPath()
        => $"/projects/{Guid.NewGuid()}/src/";
}
