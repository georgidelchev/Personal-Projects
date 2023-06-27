using System.ComponentModel.DataAnnotations;
using EPiServer.DataAnnotations;
using EPiServer.Security;

namespace EPiServerDemo.Business.Constants
{
    public class SiteTabNames
    {
        [Display(Order = 10)]
        [RequiredAccess(AccessLevel.Edit)]
        public const string SEO = "SEO";

        [Display(Order = 20)]
        [RequiredAccess(AccessLevel.Administer)]
        public const string SiteSettings = "Site Settings";
    }
}
