using System.Web.Mvc;
using EPiServer;
using EPiServerDemo.Models.Pages;

namespace EPiServerDemo.Controllers
{
    public class LibraryPageController : PageControllerBase<LibraryPage>
    {
        public LibraryPageController(
            IContentLoader loader)
            : base(loader)
        {
        }

        public ActionResult Index(LibraryPage currentPage)
        {
            return this.View(this.CreatePageViewModel(currentPage));
        }
    }
}