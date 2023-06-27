using System;
using System.IO;
using System.Threading.Tasks;

using HRCloud.Services.Data.Interfaces;
using Microsoft.AspNetCore.Http;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.Processing;

namespace HRCloud.Services.Data
{
    public class FileProcessingService : IFileProcessingService
    {
        public async Task<string> SaveImageLocallyAsync(IFormFile image, string directory, int width = 200, int height = 120)
        {
            Directory.CreateDirectory(directory);

            await using var ms = new MemoryStream();

            await image.CopyToAsync(ms);
            var imageBytes = ms.ToArray();

            using var smallThumbnail = Image.Load(imageBytes);
            smallThumbnail.Mutate(x => x.Resize(new ResizeOptions
            {
                Mode = ResizeMode.Crop,
                Size = new Size(width, height),
                Position = AnchorPositionMode.Center,
            }));

            var filePath = await SaveImage(smallThumbnail, Guid.NewGuid().ToString());

            async Task<string> SaveImage(Image imageFile, string fileName)
            {
                var tempPath = directory + Path.GetRandomFileName() + ".png";
                await using (var stream = File.OpenWrite(tempPath))
                {
                    await imageFile.SaveAsPngAsync(stream, new PngEncoder
                    {
                        FilterMethod = PngFilterMethod.Adaptive,
                        CompressionLevel = PngCompressionLevel.BestCompression,
                        ColorType = PngColorType.Palette,
                    });
                }

                var path = directory + fileName + ".png";
                File.Delete(path);
                File.Move(tempPath, path);

                return fileName + ".png";
            }

            return filePath;
        }

        public async Task<string> SaveWelcomeCardAsync(IFormFile welcomeCard, string directory, string fileName)
        {
            Directory.CreateDirectory(directory);

            await using var ms = new MemoryStream();

            await welcomeCard.CopyToAsync(ms);

            var path = directory + fileName + ".pdf";
            await using var fileStream = new FileStream(path, FileMode.Create);
            await welcomeCard.CopyToAsync(fileStream);

            return fileName + ".pdf";
        }
    }
}
