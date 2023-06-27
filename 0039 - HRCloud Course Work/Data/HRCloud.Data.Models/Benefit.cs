using System.ComponentModel.DataAnnotations;

using HRCloud.Data.Common.Models;

namespace HRCloud.Data.Models
{
    public class Benefit : BaseDeletableModel<int>
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
