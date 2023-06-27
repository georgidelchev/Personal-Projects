using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using HRCloud.Data.Common.Models;

namespace HRCloud.Data.Models
{
    public class Department : BaseDeletableModel<int>
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public virtual ICollection<ApplicationUser> Employees { get; set; }
            = new HashSet<ApplicationUser>();
    }
}
