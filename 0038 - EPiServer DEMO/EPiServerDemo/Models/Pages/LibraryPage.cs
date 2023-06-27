using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServerDemo.Business.Constants;
using EPiServerDemo.Models.Blocks;
using Geta.Epi.FontThumbnail;

namespace EPiServerDemo.Models.Pages
{
    [ContentType(
        DisplayName = "Library page",
        GUID = "9dd92068-5e74-471f-a619-3bfc81a14ea9",
        Description = "Library page for the books collection",
        GroupName = SiteGroupNames.Specialized,
        Order = 300)]
    [ThumbnailIcon(FontAwesome.Book)]
    [AvailableContentTypes(Include = new[] { typeof(BookBlock) })]
    public class LibraryPage : StandardPage
    {
        [CultureSpecific]
        [Display(
            Name = "Library heading",
            GroupName = SystemTabNames.Content,
            Order = 100,
            Description = "Heading of the page.")]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Library main body",
            GroupName = SystemTabNames.Content,
            Order = 200,
            Description = "Main body of the page.")]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Library content area",
            GroupName = SystemTabNames.Content,
            Order = 300,
            Description = "Content area of the page.")]
        public virtual ContentArea ContentArea { get; set; }
    }
}
