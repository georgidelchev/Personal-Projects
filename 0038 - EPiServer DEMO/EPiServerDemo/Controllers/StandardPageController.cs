using System.Web.Mvc;
using EPiServer;
using EPiServerDemo.Models.Pages;

namespace EPiServerDemo.Controllers
{
    public class StandardPageController : PageControllerBase<StandardPage>
    {
        public StandardPageController(IContentLoader loader)
            : base(loader)
        {
        }

        public ActionResult Index(StandardPage currentPage)
        {
            return this.View(this.CreatePageViewModel(currentPage));
        }
    }
}