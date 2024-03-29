﻿// ReSharper disable VirtualMemberCallInConstructor
using System;

using Microsoft.AspNetCore.Identity;
using MyLittleGithub.Data.Common.Models;

namespace MyLittleGithub.Data.Models;

public class ApplicationRole : IdentityRole, IAuditInfo, IDeletableEntity
{
    public ApplicationRole(string name)
        : base(name)
    {
        this.Id = Guid.NewGuid().ToString();
    }

    public DateTime CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? DeletedOn { get; set; }
}
