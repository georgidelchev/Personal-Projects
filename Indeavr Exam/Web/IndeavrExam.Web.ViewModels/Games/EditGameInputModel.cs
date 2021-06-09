using IndeavrExam.Data.Models;
using IndeavrExam.Services.Mapping;

namespace IndeavrExam.Web.ViewModels.Games
{
    public class EditGameInputModel : CreateGameInputModel, IMapFrom<Game>
    {
    }
}
