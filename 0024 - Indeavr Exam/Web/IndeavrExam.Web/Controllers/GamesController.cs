using System.Security.Claims;
using System.Threading.Tasks;

using IndeavrExam.Common;
using IndeavrExam.Services.Data;
using IndeavrExam.Web.ViewModels.Games;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IndeavrExam.Web.Controllers
{
    public class GamesController : BaseController
    {
        private readonly IGamesService gamesService;

        public GamesController(IGamesService gamesService)
        {
            this.gamesService = gamesService;
        }

        [HttpGet]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> Create(CreateGameInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.gamesService.CreateAsync(input);

            return this.RedirectToAction(nameof(this.All));
        }

        [HttpGet]
        public IActionResult All()
        {
            var viewModel = new ListAllGamesViewModel()
            {
                Games = this.gamesService.GetAll<GetAllGamesViewModel>(),
            };

            return this.View(viewModel);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var viewModel = this.gamesService.GetDetails<GetGameDetailsViewModel>(id);

            return this.View(viewModel);
        }

        [HttpPost]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> Delete(int id)
        {
            await this.gamesService.DeleteAsync(id);

            return this.RedirectToAction(nameof(this.All));
        }

        [HttpGet]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public IActionResult Edit(int id)
        {
            var viewModel = this.gamesService.GetById<EditGameInputModel>(id);

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditGameInputModel input, int id)
        {
            await this.gamesService.EditAsync(input, id);

            return this.RedirectToAction(nameof(this.All));
        }

        [HttpPost]
        public IActionResult AddToCart(int id)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            return this.RedirectToAction(nameof(this.All));
        }
    }
}
