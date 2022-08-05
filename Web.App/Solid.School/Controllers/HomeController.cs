using Microsoft.AspNetCore.Mvc;
using Solid.School.Services;
using Solid.School.ViewModel;
using System.Diagnostics;

namespace Solid.School.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStudentService studentService;

        public HomeController(
            ILogger<HomeController> logger,
            IStudentService studentService
            )
        {
            _logger = logger;
            this.studentService = studentService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult CookieSet(string key, string value)
        {
            Response.Cookies.Append(key, value, new CookieOptions()
            {
                // Expires = DateTime.Now.AddSeconds(20),
                //Path = "/Home/Privacy",
                Domain = ".chandanbhagat.com.np",
            });
            return View();
        }

        public IActionResult SessionSet(string key, string value)
        {
            HttpContext.Session.SetString(key, value);
            return View();
        }

        public IActionResult SessionGet()
        {
            return View();
        }

        public IActionResult ListStudents()
        {
            var data = studentService.GetAll();
            return View(data);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}