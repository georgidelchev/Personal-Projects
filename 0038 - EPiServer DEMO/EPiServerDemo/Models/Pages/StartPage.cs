using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServerDemo.Business.Constants;
using EPiServerDemo.Models.Media;
using Geta.Epi.FontThumbnail;

namespace EPiServerDemo.Models.Pages
{
    [ContentType(
        DisplayName = "Start",
        GUID = "a2bfda6d-6bcb-4507-9f69-dc4b9f918e9f",
        Description = "The home page for a website with an area for blocks and partial pages.",
        GroupName = SiteGroupNames.Specialized,
        Order = 10)]
    [AvailableContentTypes(Include = new[] { typeof(StandardPage) })]
    [ThumbnailIcon(FontAwesome.Home)]
    public class StartPage : SitePageData
    {
        [CultureSpecific]
        [Display(
            Name = "Heading",
            Description = "If the Heading is not set, the page falls back to showing the Name.",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body uses the XHTML-editor so you can insert, for example text, images, and tables.",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main Content Area",
            Description = "The main content area contains an ordered collection to content references, for example blocks, media assets, and pages.",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        public virtual ContentArea MainContentArea { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Footer text",
            Description = "The footer text will be shown at the bottom of every page.",
            GroupName = SiteTabNames.SiteSettings,
            Order = 10)]
        public virtual string FooterText { get; set; }
    }
}
