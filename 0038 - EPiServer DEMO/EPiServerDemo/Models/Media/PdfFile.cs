using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace EPiServerDemo.Models.Media
{
    [ContentType(
        DisplayName = "Pdf File", 
        GUID = "15902387-92a0-46ad-8a35-b24142d113eb", 
        Description = "Use this to upload Portable Document Format (PDF) files.")]
    [MediaDescriptor(ExtensionString = "pdf")]
    public class PdfFile : MediaData
    {
        [Display(Name = "Render preview image")]
        public virtual bool RenderPreviewImage { get; set; }
    }
}
