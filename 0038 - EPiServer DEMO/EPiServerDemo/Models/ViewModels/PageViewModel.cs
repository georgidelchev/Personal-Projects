using System.Collections.Generic;
using EPiServer.Core;
using EPiServerDemo.Models.Pages;

namespace EPiServerDemo.Models.ViewModels
{
    public class PageViewModel<T> : IPageViewModel<T>
        where T : SitePageData
    {
        public PageViewModel(T currentPage)
        {
            this.CurrentPage = currentPage;
        }

        public T CurrentPage { get; set; }

        public StartPage StartPage { get; set; }

        public IEnumerable<SitePageData> MenuPages { get; set; }

        public IContent Section { get; set; }
    }

    public static class PageViewModel
    {
        public static PageViewModel<T> Create<T>(T currentPage)
            where T : SitePageData
            => new PageViewModel<T>(currentPage);
    }
}
