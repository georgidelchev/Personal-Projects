using System.Web.Mvc;
using EPiServer;
using EPiServerDemo.Models.Pages;

namespace EPiServerDemo.Controllers
{
    public class StartPageController : PageControllerBase<StartPage>
    {
        public StartPageController(
            IContentLoader loader)
            : base(loader)
        {
        }

        public ActionResult Index(StartPage currentPage)
        {
            return this.View(this.CreatePageViewModel(currentPage));
        }
    }
}
