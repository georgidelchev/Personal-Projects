using System.Collections.Generic;
using EPiServer.Core;
using EPiServerDemo.Models.Pages;

namespace EPiServerDemo.Models.ViewModels
{
    public interface IPageViewModel<out T>
    {
        T CurrentPage { get; }

        StartPage StartPage { get; }

        IEnumerable<SitePageData> MenuPages { get; }

        IContent Section { get; }
    }
}
