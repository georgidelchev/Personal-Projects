using System.Linq;
using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;

namespace EPiServerDemo.Business.ExtensionMethods
{
    public static class SectionExtensionMethods
    {
        public static IContent GetSection(this ContentReference contentLink)
        {
            var loader = ServiceLocator.Current.GetInstance<IContentLoader>();
            var currentContent = loader.Get<IContent>(contentLink);

            if (currentContent.ParentLink != null && currentContent.ParentLink.CompareToIgnoreWorkID(ContentReference.StartPage))
            {
                return currentContent;
            }

            return loader
                .GetAncestors(contentLink)
                .OfType<PageData>()
                .SkipWhile(x => x.ParentLink == null || !x.ParentLink.CompareToIgnoreWorkID(ContentReference.StartPage))
                .FirstOrDefault();
        }
    }
}