using Microsoft.AspNetCore.Mvc;
using Solid.School.Services;

namespace Solid.School.Controllers
{
    public class ClassController : Controller
    {
        private readonly IClassService classService;

        public ClassController(
            IClassService classService
            )
        {
            this.classService = classService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}