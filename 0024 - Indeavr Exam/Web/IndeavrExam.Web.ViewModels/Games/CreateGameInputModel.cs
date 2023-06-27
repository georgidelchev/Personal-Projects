using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using IndeavrExam.Data.Models;
using IndeavrExam.Services.Mapping;

namespace IndeavrExam.Web.ViewModels.Games
{
    public class CreateGameInputModel
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [DisplayName("Release Date")]
        public DateTime ReleaseDate { get; set; }
    }
}
