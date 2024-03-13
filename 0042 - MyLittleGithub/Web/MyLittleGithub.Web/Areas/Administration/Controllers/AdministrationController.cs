using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyLittleGithub.Common;
using MyLittleGithub.Web.Controllers;

namespace MyLittleGithub.Web.Areas.Administration.Controllers;

[Area("Administration")]
[Authorize(Roles = GlobalConstants.AdministratorRoleName)]
public class AdministrationController : BaseController
{
}
