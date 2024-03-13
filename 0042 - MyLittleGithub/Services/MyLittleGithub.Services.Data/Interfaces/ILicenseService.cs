using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyLittleGithub.Services.Data.Interfaces;

public interface ILicenseService
{
    T Get<T>(string licenseId);

    Task<IEnumerable<KeyValuePair<string, string>>> GetAllAsKeyValuePair();
}
