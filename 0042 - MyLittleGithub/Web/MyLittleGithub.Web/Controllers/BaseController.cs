using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyLittleGithub.Web.Controllers;

[Authorize]
public class BaseController : Controller
{
}
