using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServerDemo.Business.Constants;
using Geta.Epi.FontThumbnail;

namespace EPiServerDemo.Models.Pages
{
    [ContentType(
        DisplayName = "Standard Page",
        GUID = "fcb829c8-8975-40a7-b91e-5726c1261643",
        Description = "Use this page type unless you need a more specialized one.",
        GroupName = SiteGroupNames.Common,
        Order = 150)]
    [ThumbnailIcon(FontAwesome.Pagelines)]
    [AvailableContentTypes(Include = new[] { typeof(StartPage) })]
    public class StandardPage : SitePageData
    {
        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 150)]
        public virtual XhtmlString MainBody { get; set; }
    }
}