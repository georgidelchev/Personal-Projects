using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using CompanyManagementSystem.Data.Common.Models;

namespace CompanyManagementSystem.Data.Models
{
    public class EmployeeAssignment : BaseDeletableModel<int>
    {
        [Required]
        [ForeignKey(nameof(ApplicationUser))]
        public string EmployeeId { get; set; }

        public virtual ApplicationUser Employee { get; set; }

        [Required]
        [ForeignKey(nameof(Assignment))]
        public int AssignmentId { get; set; }

        public virtual Assignment Assignment { get; set; }
    }
}
