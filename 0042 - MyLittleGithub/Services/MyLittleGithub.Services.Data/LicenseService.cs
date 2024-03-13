using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using MyLittleGithub.Data.Common.Repositories;
using MyLittleGithub.Data.Models;
using MyLittleGithub.Services.Data.Interfaces;
using MyLittleGithub.Services.Mapping;
using MyLittleGithub.Web.ViewModels.License;

namespace MyLittleGithub.Services.Data;

public class LicenseService : ILicenseService
{
    private readonly IDeletableEntityRepository<License> licenseRepository;

    public LicenseService(
        IDeletableEntityRepository<License> licenseRepository)
    {
        this.licenseRepository = licenseRepository;
    }

    public T Get<T>(string licenseId)
        => this.licenseRepository
            .All()
            .Where(l => l.Id == licenseId)
            .To<T>()
            .FirstOrDefault();

    public async Task<IEnumerable<KeyValuePair<string, string>>> GetAllAsKeyValuePair()
        => await this.licenseRepository
            .All()
            .Select(l => new
            {
                l.Id,
                l.Name,
            })
            .Select(l => new KeyValuePair<string, string>(l.Id.ToString(), l.Name))
            .ToListAsync();
}
