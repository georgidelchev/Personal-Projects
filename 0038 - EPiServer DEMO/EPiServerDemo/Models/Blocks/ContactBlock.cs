using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using Geta.Epi.FontThumbnail;

namespace EPiServerDemo.Models.Blocks
{
    [ContentType(
        DisplayName = "ContactBlock",
        GUID = "5eb0056a-63d2-41c1-8c2b-13a778429bc5",
        Description = "Contact information block")]
    [ThumbnailIcon(FontAwesome.Envelope)]
    public class ContactBlock : BlockData
    {
        [CultureSpecific]
        [Display(
            Name = "Heading",
            Description = "Heading of the contact block.",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual string Heading { get; set; }

        [Display(
            Name = "Image",
            Description = "Image of the contact block.",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        public virtual Url Image { get; set; }

        [Display(
            Name = "Text Content",
            Description = "Content of the contact block.",
            GroupName = SystemTabNames.Content,
            Order = 4)]
        public virtual string Content { get; set; }

        [Display(
            Name = "Phone Number",
            Description = "Phone number of the contact block.",
            GroupName = SystemTabNames.Content,
            Order = 5)]
        public virtual string PhoneNumber { get; set; }

        [Display(
            Name = "Email Address",
            Description = "Email address of the contact block.",
            GroupName = SystemTabNames.Content,
            Order = 6)]
        public virtual string EmailAddress { get; set; }

        [Display(
            Name = "Bottom Image",
            Description = "Bottom image of the contact block.",
            GroupName = SystemTabNames.Content,
            Order = 7)]
        public virtual Url BottomImage { get; set; }
    }
}