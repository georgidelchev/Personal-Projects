using System.Linq;
using EPiServer.Web.Mvc;
using System.Web.Mvc;
using System.Web.Security;
using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServerDemo.Business.ExtensionMethods;
using EPiServerDemo.Models.Pages;
using EPiServerDemo.Models.ViewModels;

namespace EPiServerDemo.Controllers
{
    public abstract class PageControllerBase<T> : PageController<T>
        where T : SitePageData
    {
        private readonly IContentLoader loader;

        public PageControllerBase(
            IContentLoader loader)
        {
            this.loader = loader;
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }

        protected IPageViewModel<TPage> CreatePageViewModel<TPage>(TPage currentPage) 
            where TPage : SitePageData
        {
            var viewmodel = PageViewModel.Create(currentPage);

            viewmodel.StartPage = loader.Get<StartPage>(ContentReference.StartPage);
            viewmodel.MenuPages = FilterForVisitor
                .Filter(loader.GetChildren<SitePageData>(ContentReference.StartPage))
                .Cast<SitePageData>().Where(page => page.VisibleInMenu);

            viewmodel.Section = currentPage.ContentLink.GetSection();

            return viewmodel;
        }
    }
}
