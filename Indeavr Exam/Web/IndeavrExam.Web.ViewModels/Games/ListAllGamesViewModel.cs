using System.Collections;
using System.Collections.Generic;

namespace IndeavrExam.Web.ViewModels.Games
{
    public class ListAllGamesViewModel
    {
        public IEnumerable<GetAllGamesViewModel> Games { get; set; }
    }
}