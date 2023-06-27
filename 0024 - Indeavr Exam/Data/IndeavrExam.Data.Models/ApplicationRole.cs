// ReSharper disable VirtualMemberCallInConstructor

using System;
using System.ComponentModel.DataAnnotations;

using IndeavrExam.Data.Common.Models;
using Microsoft.AspNetCore.Identity;

namespace IndeavrExam.Data.Models
{
    public class ApplicationRole : IdentityRole, IAuditInfo, IDeletableEntity
    {
        public ApplicationRole()
            : this(null)
        {
        }

        public ApplicationRole(string name)
            : base(name)
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Required]
        public string FullName { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
