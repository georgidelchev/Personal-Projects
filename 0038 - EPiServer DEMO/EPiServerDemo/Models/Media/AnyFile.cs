using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace EPiServerDemo.Models.Media
{
    [ContentType(
        DisplayName = "Any File", 
        GUID = "98492d66-b7b0-434d-b6cb-80f0b2c0bc56", 
        Description = "Use this to upload any type of file.")]
    public class AnyFile : MediaData
    {
    }
}
