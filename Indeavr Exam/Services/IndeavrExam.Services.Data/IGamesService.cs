using System.Collections.Generic;
using System.Threading.Tasks;

using IndeavrExam.Web.ViewModels.Games;

namespace IndeavrExam.Services.Data
{
    public interface IGamesService
    {
        Task CreateAsync(CreateGameInputModel input);

        IEnumerable<T> GetAll<T>();

        T GetDetails<T>(int id);

        Task DeleteAsync(int id);

        T GetById<T>(int id);

        Task EditAsync(EditGameInputModel input, int id);
    }
}
