using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;
using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc.Html;
using EPiServer.Web.Routing;

namespace EPiServerDemo.Business.ExtensionMethods
{
    public static class HtmlHelperExtensions
    {
        public static IHtmlString MenuList(
            this HtmlHelper helper,
            ContentReference rootLink,
            Func<MenuItem, HelperResult> itemTemplate = null,
            bool includeRoot = false,
            bool requireVisibleInMenu = true,
            bool requirePageTemplate = true)
        {
            itemTemplate = itemTemplate ?? GetDefaultItemTemplate(helper);

            var currentContentLink = helper.ViewContext.RequestContext.GetContentLink();
            var contentLoader = ServiceLocator.Current.GetInstance<IContentLoader>();

            Func<IEnumerable<PageData>, IEnumerable<PageData>> filter =
                pages => pages.FilterForDisplay(requirePageTemplate, requireVisibleInMenu);

            var pagePath = contentLoader.GetAncestors(currentContentLink)
                .Reverse()
                .Select(x => x.ContentLink)
                .SkipWhile(x => !x.CompareToIgnoreWorkID(rootLink))
                .ToList();

            var menuItems = contentLoader.GetChildren<PageData>(rootLink)
                .FilterForDisplay(requirePageTemplate, requireVisibleInMenu)
                .Select(x => CreateMenuItem(x, currentContentLink, pagePath, contentLoader, filter))
                .ToList();

            if (includeRoot)
            {
                menuItems.Insert(0, CreateMenuItem(contentLoader.Get<PageData>(rootLink), currentContentLink, pagePath, contentLoader, filter));
            }

            var buffer = new StringBuilder();
            var writer = new StringWriter(buffer);

            foreach (var menuItem in menuItems)
            {
                itemTemplate(menuItem).WriteTo(writer);
            }

            return new MvcHtmlString(buffer.ToString());
        }

        private static MenuItem CreateMenuItem(
            PageData page,
            ContentReference currentContentLink,
            List<ContentReference> pagePath,
            IContentLoader contentLoader,
            Func<IEnumerable<PageData>,
                IEnumerable<PageData>> filter)
        {
            var menuItem = new MenuItem(page)
            {
                Selected = page.ContentLink.CompareToIgnoreWorkID(currentContentLink) ||
                               pagePath.Contains(page.ContentLink),
                HasChildren = new Lazy<bool>(() => filter(contentLoader.GetChildren<PageData>(page.ContentLink)).Any())
            };

            return menuItem;
        }

        private static Func<MenuItem, HelperResult> GetDefaultItemTemplate(HtmlHelper helper)
            => x => new HelperResult(writer => writer.Write(helper.PageLink(x.Page)));

        public static ConditionalLink BeginConditionalLink(
            this HtmlHelper helper, 
            bool shouldWriteLink, 
            IHtmlString url, 
            string title = null, 
            string cssClass = null)
        {
            if (shouldWriteLink)
            {
                var linkTag = new System.Web.Mvc.TagBuilder("a");

                linkTag.Attributes.Add("href", url.ToHtmlString());

                if (!string.IsNullOrWhiteSpace(title))
                {
                    linkTag.Attributes.Add("title", helper.Encode(title));
                }

                if (!string.IsNullOrWhiteSpace(cssClass))
                {
                    linkTag.Attributes.Add("class", cssClass);
                }

                helper.ViewContext.Writer.Write(linkTag.ToString(TagRenderMode.StartTag));
            }

            return new ConditionalLink(helper.ViewContext, shouldWriteLink);
        }

        public static ConditionalLink BeginConditionalLink(
            this HtmlHelper helper, 
            bool shouldWriteLink, 
            Func<IHtmlString> urlGetter, 
            string title = null, 
            string cssClass = null)
        {
            IHtmlString url = MvcHtmlString.Empty;

            if (shouldWriteLink)
            {
                url = urlGetter();
            }

            return helper.BeginConditionalLink(shouldWriteLink, url, title, cssClass);
        }
    }

    public class MenuItem
    {
        public MenuItem(PageData page)
        {
            Page = page;
        }

        public PageData Page { get; set; }

        public bool Selected { get; set; }

        public Lazy<bool> HasChildren { get; set; }
    }

    public class ConditionalLink : IDisposable
    {
        private readonly ViewContext viewContext;
        private readonly bool linked;
        private bool disposed;

        public ConditionalLink(
            ViewContext viewContext, 
            bool isLinked)
        {
            this.viewContext = viewContext;
            this.linked = isLinked;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);

        }

        protected virtual void Dispose(bool disposing)
        {
            if (this.disposed)
            {
                return;
            }

            this.disposed = true;

            if (this.linked)
            {
                this.viewContext.Writer.Write("</a>");
            }
        }
    }
}