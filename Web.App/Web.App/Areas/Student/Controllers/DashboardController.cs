using Microsoft.AspNetCore.Mvc;

namespace Web.App.Areas.Student.Controllers
{
    [Area("Student")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
