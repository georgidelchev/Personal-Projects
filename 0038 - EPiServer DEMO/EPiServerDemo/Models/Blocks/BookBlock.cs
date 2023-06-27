using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using Geta.Epi.FontThumbnail;

namespace EPiServerDemo.Models.Blocks
{
    [ContentType(
        DisplayName = "BookBlock",
        GUID = "afdc17aa-9b7a-43a8-8145-3321a9e15c28",
        Description = "Block for creation of book.",
        Order = 200)]
    [ThumbnailIcon(FontAwesome.Book)]
    public class BookBlock : BlockData
    {
        [CultureSpecific]
        [Display(Name = "Book Heading",
            Order = 100,
            Description = "Book Heading",
            GroupName = SystemTabNames.Content)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(Name = "Book Description",
            Order = 200,
            Description = "Book Description",
            GroupName = SystemTabNames.Content)]
        public virtual XhtmlString Description { get; set; }

        [Display(Name = "Book Image",
            Order = 300,
            Description = "Book Image",
            GroupName = SystemTabNames.Content)]
        public virtual LinkItemCollection Images { get; set; }

        [Display(Name = "Book Url",
            Order = 500,
            Description = "Book Url",
            GroupName = SystemTabNames.Content)]
        public virtual LinkItemCollection Urls { get; set; }
    }
}