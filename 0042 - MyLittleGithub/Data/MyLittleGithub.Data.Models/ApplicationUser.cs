// ReSharper disable VirtualMemberCallInConstructor
using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Identity;
using MyLittleGithub.Data.Common.Models;

namespace MyLittleGithub.Data.Models;

public class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
{
    public ApplicationUser()
    {
        this.Id = Guid.NewGuid().ToString();
    }

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

    public virtual ICollection<Repository> Repositories { get; set; }
        = new HashSet<Repository>();

    public virtual ICollection<Issue> Issues { get; set; }
        = new HashSet<Issue>();
}
