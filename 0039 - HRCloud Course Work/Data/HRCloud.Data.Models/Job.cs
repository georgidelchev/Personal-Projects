using System.ComponentModel.DataAnnotations;

using HRCloud.Data.Common.Models;

namespace HRCloud.Data.Models
{
    public class Job : BaseDeletableModel<int>
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal MinSalary { get; set; }

        [Required]
        public decimal MaxSalary { get; set; }
    }
}
