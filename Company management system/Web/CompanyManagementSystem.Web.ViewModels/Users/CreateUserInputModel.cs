using System.ComponentModel.DataAnnotations;

namespace CompanyManagementSystem.Web.ViewModels.Users
{
    public class CreateUserInputModel
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Range(typeof(decimal), "650", "100000")]
        public decimal Salary { get; set; }
    }
}
