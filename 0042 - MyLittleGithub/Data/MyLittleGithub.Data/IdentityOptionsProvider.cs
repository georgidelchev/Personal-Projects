using Microsoft.AspNetCore.Identity;

namespace MyLittleGithub.Data;

public static class IdentityOptionsProvider
{
    public static void GetIdentityOptions(IdentityOptions options)
    {
        options.Password.RequireDigit = true;
        options.Password.RequireLowercase = false;
        options.Password.RequireUppercase = false;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequiredLength = 6;
        options.Password.RequiredUniqueChars = 0;
    }
}
