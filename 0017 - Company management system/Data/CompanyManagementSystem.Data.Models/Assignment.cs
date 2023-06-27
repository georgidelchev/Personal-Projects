using System.Collections.Generic;

using CompanyManagementSystem.Data.Common.Models;

namespace CompanyManagementSystem.Data.Models
{
    public class Assignment : BaseDeletableModel<int>
    {
        public string Content { get; set; }

        public ICollection<EmployeeAssignment> EmployeeAssignments { get; set; }
            = new HashSet<EmployeeAssignment>();
    }
}
