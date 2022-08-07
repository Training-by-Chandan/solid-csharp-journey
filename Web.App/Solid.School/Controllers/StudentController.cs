using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Solid.School.Services;
using Solid.School.ViewModel;

namespace Solid.School.Controllers
{
    [Authorize(Roles = StrConst.Roles.Admin)]
    public class StudentController : Controller
    {
        private readonly IStudentService studentService;
        private readonly IClassService classService;

        public StudentController(
            IStudentService studentService,
            IClassService classService
            )
        {
            this.studentService = studentService;
            this.classService = classService;
        }

        public IActionResult Index()
        {
            var data = studentService.GetAll();
            return View(data);
        }

        public IActionResult Create()
        {
            ViewBag.classlist = classService.GetDropDownItems();
            return View();
        }

        [HttpPost]
        public IActionResult Create(StudentCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var res = studentService.Create(model);
                if (res.Item1)
                    return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
    }
}