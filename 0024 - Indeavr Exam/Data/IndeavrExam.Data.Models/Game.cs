using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using IndeavrExam.Data.Common.Models;

namespace IndeavrExam.Data.Models
{
    public class Game : BaseDeletableModel<int>
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
        public DateTime ReleaseDate { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }
            = new HashSet<Cart>();
    }
}