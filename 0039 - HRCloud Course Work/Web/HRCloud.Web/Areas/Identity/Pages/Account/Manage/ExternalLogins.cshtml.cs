﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRCloud.Data.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HRCloud.Web.Areas.Identity.Pages.Account.Manage
{
    public class ExternalLoginsModel : PageModel
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public ExternalLoginsModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this._signInManager = signInManager;
        }

        public IList<UserLoginInfo> CurrentLogins { get; set; }

        public IList<AuthenticationScheme> OtherLogins { get; set; }

        public bool ShowRemoveButton { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await this.userManager.GetUserAsync(this.User);
            if (user == null)
            {
                return this.NotFound($"Unable to load user with ID 'user.Id'.");
            }

            this.CurrentLogins = await this.userManager.GetLoginsAsync(user);
            this.OtherLogins = (await this._signInManager.GetExternalAuthenticationSchemesAsync())
                .Where(auth => this.CurrentLogins.All(ul => auth.Name != ul.LoginProvider))
                .ToList();
            this.ShowRemoveButton = user.PasswordHash != null || this.CurrentLogins.Count > 1;
            return this.Page();
        }

        public async Task<IActionResult> OnPostRemoveLoginAsync(string loginProvider, string providerKey)
        {
            var user = await this.userManager.GetUserAsync(this.User);
            if (user == null)
            {
                return this.NotFound($"Unable to load user with ID 'user.Id'.");
            }

            var result = await this.userManager.RemoveLoginAsync(user, loginProvider, providerKey);
            if (!result.Succeeded)
            {
                this.StatusMessage = "The external login was not removed.";
                return this.RedirectToPage();
            }

            await this._signInManager.RefreshSignInAsync(user);
            this.StatusMessage = "The external login was removed.";
            return this.RedirectToPage();
        }

        public async Task<IActionResult> OnPostLinkLoginAsync(string provider)
        {
            // Clear the existing external cookie to ensure a clean login process
            await this.HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            // Request a redirect to the external login provider to link a login for the current user
            var redirectUrl = this.Url.Page("./ExternalLogins", pageHandler: "LinkLoginCallback");
            var properties = this._signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl, this.userManager.GetUserId(this.User));
            return new ChallengeResult(provider, properties);
        }

        public async Task<IActionResult> OnGetLinkLoginCallbackAsync()
        {
            var user = await this.userManager.GetUserAsync(this.User);
            if (user == null)
            {
                return this.NotFound($"Unable to load user with ID 'user.Id'.");
            }

            var info = await this._signInManager.GetExternalLoginInfoAsync(user.Id);
            if (info == null)
            {
                throw new InvalidOperationException($"Unexpected error occurred loading external login info for user with ID '{user.Id}'.");
            }

            var result = await this.userManager.AddLoginAsync(user, info);
            if (!result.Succeeded)
            {
                this.StatusMessage = "The external login was not added. External logins can only be associated with one account.";
                return this.RedirectToPage();
            }

            // Clear the existing external cookie to ensure a clean login process
            await this.HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            this.StatusMessage = "The external login was added.";
            return this.RedirectToPage();
        }
    }
}
