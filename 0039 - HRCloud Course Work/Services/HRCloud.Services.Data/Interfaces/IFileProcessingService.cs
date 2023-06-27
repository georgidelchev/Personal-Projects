using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;

namespace HRCloud.Services.Data.Interfaces
{
    public interface IFileProcessingService
    {
        Task<string> SaveImageLocallyAsync(IFormFile image, string directory, int width = 200, int height = 120);

        Task<string> SaveWelcomeCardAsync(IFormFile welcomeCard, string directory, string fileName);
    }
}
