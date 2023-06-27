using System.Collections.Generic;
using System.Linq;
using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServer.Framework.Web;
using EPiServer.ServiceLocation;

namespace EPiServerDemo.Business.ExtensionMethods
{
    public static class ContentExtensions
    {
        public static IContent Get<TContent>(this ContentReference contentLink) 
            where TContent : IContent
        {
            var loader = ServiceLocator.Current.GetInstance<IContentLoader>();
            return loader.Get<TContent>(contentLink);
        }

        public static IEnumerable<T> FilterForDisplay<T>(this IEnumerable<T> contents, bool requirePageTemplate = false, bool requireVisibleInMenu = false)
            where T : IContent
        {
            var accessFilter = new FilterAccess();
            var publishedFilter = new FilterPublished();

            contents = contents.Where(x => !publishedFilter.ShouldFilter(x) && !accessFilter.ShouldFilter(x));

            if (requirePageTemplate)
            {
                var templateFilter = ServiceLocator.Current.GetInstance<FilterTemplate>();

                templateFilter.TemplateTypeCategories = TemplateTypeCategories.Page;
                contents = contents.Where(x => !templateFilter.ShouldFilter(x));
            }
            if (requireVisibleInMenu)
            {
                contents = contents.Where(x => VisibleInMenu(x));
            }

            return contents;
        }

        private static bool VisibleInMenu(IContent content)
        {
            var page = content as PageData;

            if (page == null)
            {
                return true;
            }

            return page.VisibleInMenu;
        }
    }
}
