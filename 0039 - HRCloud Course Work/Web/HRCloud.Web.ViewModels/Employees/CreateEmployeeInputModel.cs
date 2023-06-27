using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRCloud.Web.ViewModels.Employees
{
    public class CreateEmployeeInputModel
    {
        [Required(ErrorMessage = "First name field is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Sur name field is required.")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Last name field is required.")]
        public string LastName { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email field is required.")]
        [Remote(
            action: "DoesEmailExists",
            controller: "Employees",
            HttpMethod = "GET",
            ErrorMessage = "Email address already exists. Please enter a different Email address.")]
        public string Email { get; set; }

        public string Password
            => Guid.NewGuid().ToString();

        [Phone]
        [Required(ErrorMessage = "Phone number field is required.")]
        public string PhoneNumber { get; set; }

        [Required]
        [Range(0.01, 100000, ErrorMessage = "Salary should be bigger than 0 and less than 100000.")]
        [Remote(
            action: "IsSalaryValid",
            controller: "Employees",
            HttpMethod = "GET",
            ErrorMessage = "Salary is out of given range.",
            AdditionalFields = "JobId")]
        public decimal Salary { get; set; }

        [Required(ErrorMessage = "Image field is required.")]
        public IFormFile Image { get; set; }

        [Required(ErrorMessage = "Welcome card field is required.")]
        public IFormFile WelcomeCard { get; set; }

        [Required(ErrorMessage = "Department name field is required.")]
        public string DepartmentName { get; set; }

        public IEnumerable<KeyValuePair<int, string>> Jobs { get; set; }

        [Required(ErrorMessage = "Job field is required.")]
        public int JobId { get; set; }

        public IEnumerable<KeyValuePair<string, string>> Mentors { get; set; }

        public string MentorId { get; set; }
    }
}
