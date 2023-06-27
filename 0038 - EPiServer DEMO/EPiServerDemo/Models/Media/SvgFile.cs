using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Framework.Blobs;
using EPiServer.Framework.DataAnnotations;

namespace EPiServerDemo.Models.Media
{
    [ContentType(
        DisplayName = "Svg File",
        GUID = "dc6ba2ea-d7e6-4e72-8f57-4ea090337535",
        Description = "Use this to upload Scalable Vector Graphic (SVG) images.")]
    [MediaDescriptor(ExtensionString = "svg")]
    public class SvgFile : ImageData
    {
        public Blob Thumbnail
            => base.BinaryData;
    }
}
