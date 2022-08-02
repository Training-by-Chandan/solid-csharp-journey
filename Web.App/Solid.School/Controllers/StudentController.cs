using Microsoft.AspNetCore.Mvc;
using Solid.School.Services;
using Solid.School.ViewModel;

namespace Solid.School.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService studentService;

        public StudentController(
            IStudentService studentService
            )
        {
            this.studentService = studentService;
        }

        public IActionResult Index()
        {
            var data = studentService.GetAll();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(StudentCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var res = studentService.Create(model);
                if (res.Item1)
                    return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}