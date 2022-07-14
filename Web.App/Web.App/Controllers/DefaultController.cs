using Microsoft.AspNetCore.Mvc;

namespace Web.App.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View("~/Views/Home/Privacy.cshtml");
        }
    }
}