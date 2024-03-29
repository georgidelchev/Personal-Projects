﻿using System.Security.Claims;

using MyLittleGithub.Common;

namespace MyLittleGithub.Web.Infrastructure.Extensions;

public static class ClaimsPrincipalExtensions
{
    public static string GetId(this ClaimsPrincipal user)
        => user.FindFirstValue(ClaimTypes.NameIdentifier);

    public static string GetEmail(this ClaimsPrincipal user)
        => user.FindFirstValue(ClaimTypes.Email);

    public static bool IsUserAuthenticated(this ClaimsPrincipal user)
        => user.Identity.IsAuthenticated;

    public static bool IsAdmin(this ClaimsPrincipal user)
        => user.IsInRole(GlobalConstants.AdministratorRoleName);
}
