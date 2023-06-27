using System.Collections.Generic;

namespace HRCloud.Web.ViewModels.Employees
{
    public class ListEmployeesViewModel
    {
        public IEnumerable<EmployeeViewModel> Employees { get; set; }

        public string DepartmentName { get; set; }
    }
}
