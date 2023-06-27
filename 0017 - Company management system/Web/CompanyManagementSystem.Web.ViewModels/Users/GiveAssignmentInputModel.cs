using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CompanyManagementSystem.Web.ViewModels.Users
{
    public class GiveAssignmentInputModel
    {
        [Required]
        [MinLength(3)]
        [MaxLength(1000)]
        public string Content { get; set; }

        [Required]
        public IEnumerable<KeyValuePair<string, string>> Employees { get; set; }
    }
}
