using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Solid.School.Areas.Admin.Controllers
{
    [Area(StrConst.Roles.Admin)]
    [Authorize(Roles = StrConst.Roles.Admin)]
    public class Home : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}