using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using CompanyManagementSystem.Data.Common.Models;

namespace CompanyManagementSystem.Data.Models
{
    public class ManagerEmployee : BaseDeletableModel<int>
    {
        [Required]
        [ForeignKey(nameof(ApplicationUser))]
        public string ManagerId { get; set; }

        public virtual ApplicationUser Manager { get; set; }

        [Required]
        [ForeignKey(nameof(ApplicationUser))]
        public string EmployeeId { get; set; }

        public virtual ApplicationUser Employee { get; set; }
    }
}
