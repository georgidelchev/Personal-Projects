using System.Web.Mvc;
using EPiServer.Web.Mvc;
using EPiServerDemo.Models.Pages;
using EPiServerDemo.Models.ViewModels;

namespace EPiServerDemo.Controllers
{
    public class StartPagePartialController : PartialContentController<StartPage>
    {
        public override ActionResult Index(StartPage currentPage)
        {
            return this.PartialView(PageViewModel.Create(currentPage));
        }
    }
}
