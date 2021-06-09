using System;
using System.ComponentModel;

using IndeavrExam.Data.Models;
using IndeavrExam.Services.Mapping;

namespace IndeavrExam.Web.ViewModels.Games
{
    public class GetAllGamesViewModel : IMapFrom<Game>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string ImageUrl { get; set; }
    }
}
