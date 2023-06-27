using System.Web.Mvc;
using EPiServer.Web.Mvc;
using EPiServerDemo.Models.Pages;
using EPiServerDemo.Models.ViewModels;

namespace EPiServerDemo.Controllers
{
    public class StandardPagePartialController : PartialContentController<StandardPage>
    {
        public override ActionResult Index(StandardPage currentPage)
        {
            return this.PartialView(PageViewModel.Create(currentPage));
        }
    }
}