using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using IndeavrExam.Data.Common.Repositories;
using IndeavrExam.Data.Models;
using IndeavrExam.Services.Mapping;
using IndeavrExam.Web.ViewModels.Games;
using Microsoft.AspNetCore.Identity;

namespace IndeavrExam.Services.Data
{
    public class GamesService : IGamesService
    {
        private readonly IDeletableEntityRepository<Game> gamesRepository;
        private readonly UserManager<ApplicationUser> userManager;

        public GamesService(IDeletableEntityRepository<Game> gamesRepository, UserManager<ApplicationUser> userManager)
        {
            this.gamesRepository = gamesRepository;
            this.userManager = userManager;
        }

        public async Task CreateAsync(CreateGameInputModel input)
        {
            var game = new Game()
            {
                ImageUrl = input.ImageUrl,
                Price = input.Price,
                Description = input.Description,
                ReleaseDate = input.ReleaseDate,
                Title = input.Title,
            };

            await this.gamesRepository.AddAsync(game);
            await this.gamesRepository.SaveChangesAsync();
        }

        public IEnumerable<T> GetAll<T>()
            => this.gamesRepository
                .All()
                .To<T>()
                .ToList();

        public T GetDetails<T>(int id)
            => this.gamesRepository
                .All()
                .Where(g => g.Id == id)
                .To<T>()
                .FirstOrDefault();

        public async Task DeleteAsync(int id)
        {
            var game = this.gamesRepository
                .All()
                .FirstOrDefault(g => g.Id == id);

            this.gamesRepository.Delete(game);
            await this.gamesRepository.SaveChangesAsync();
        }

        public T GetById<T>(int id)
            => this.gamesRepository
                .All()
                .Where(g => g.Id == id)
                .To<T>()
                .FirstOrDefault();

        public async Task EditAsync(EditGameInputModel input, int id)
        {
            var game = this.gamesRepository
                .All()
                .FirstOrDefault(g => g.Id == id);

            game.ImageUrl = input.ImageUrl;
            game.Price = input.Price;
            game.Description = input.Description;
            game.ReleaseDate = input.ReleaseDate;
            game.Title = input.Title;

            this.gamesRepository.Update(game);
            await this.gamesRepository.SaveChangesAsync();
        }
    }
}
