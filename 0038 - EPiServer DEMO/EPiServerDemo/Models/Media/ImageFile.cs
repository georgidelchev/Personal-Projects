using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace EPiServerDemo.Models.Media
{
    [ContentType(
        DisplayName = "Image File",
        GUID = "f54a2513-01e7-462b-a083-2284627219a5",
        Description = "Use this to upload image files.")]
    [MediaDescriptor(ExtensionString = "jpg,png,jpeg,gif")]
    public class ImageFile : ImageData
    {
        [CultureSpecific]
        [Editable(true)]
        public virtual string Description { get; set; }
    }
}
