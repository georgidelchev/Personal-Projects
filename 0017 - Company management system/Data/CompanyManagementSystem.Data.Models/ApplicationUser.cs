// ReSharper disable VirtualMemberCallInConstructor

using System;
using System.Collections.Generic;

using CompanyManagementSystem.Data.Common.Models;
using Microsoft.AspNetCore.Identity;

namespace CompanyManagementSystem.Data.Models
{
    public class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            this.Id = Guid
                .NewGuid()
                .ToString();
        }

        public decimal Salary { get; set; }

        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }
            = new HashSet<IdentityUserRole<string>>();

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }
            = new HashSet<IdentityUserClaim<string>>();

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }
            = new HashSet<IdentityUserLogin<string>>();

        public virtual ICollection<ManagerEmployee> Employees { get; set; }
            = new HashSet<ManagerEmployee>();

        public virtual ICollection<EmployeeAssignment> Assignments { get; set; }
            = new HashSet<EmployeeAssignment>();
    }
}
