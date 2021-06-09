using System;
using System.ComponentModel;

using IndeavrExam.Data.Models;
using IndeavrExam.Services.Mapping;

namespace IndeavrExam.Web.ViewModels.Games
{
    public class GetGameDetailsViewModel : GetAllGamesViewModel
    {
        public decimal Price { get; set; }

        public string Description { get; set; }

        [DisplayName("Release Date")]
        public DateTime ReleaseDate { get; set; }

        public string ReleaseDateAsString
            => this.ReleaseDate.ToString("d");
    }
}