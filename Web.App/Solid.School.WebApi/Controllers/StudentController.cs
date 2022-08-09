using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Solid.School.Services;
using Solid.School.ViewModel;

namespace Solid.School.WebApi.Controllers
{
    [Route("api/student")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(
            IStudentService studentService
            )
        {
            _studentService = studentService;
        }
        [HttpGet]
        [Route("get-all")]
        [Authorize]
        public List<StudentViewModel> GetAll()
        {
            return _studentService.GetAll();
        }

        [HttpPost]
        [Route("create-student")]
        public ResponseViewModel CreateStudent(StudentCreateViewModel model)
        {
            var res=_studentService.Create(model);
            return new ResponseViewModel()
            {
                Status=res.Item1, 
                Message=res.Item2
            };
        }
    }
}
