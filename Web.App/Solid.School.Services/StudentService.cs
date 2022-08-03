using Solid.School.Models;
using Solid.School.Repository;
using Solid.School.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.School.Services
{
    public interface IStudentService
    {
        (bool, string) Create(StudentCreateViewModel model);

        List<StudentViewModel> GetAll();
    }

    public class StudentService : IStudentService
    {
        private readonly IStudentRepository studentRepository;

        public StudentService(
            IStudentRepository studentRepository
            )
        {
            this.studentRepository = studentRepository;
        }

        public List<StudentViewModel> GetAll()
        {
            var data = studentRepository.GetAll();
            var ret = data.Select(p => new StudentViewModel()
            {
                Id = p.Id,
                Email = p.Email,
                Name = p.Name,
                PhoneNumber = p.PhoneNumber,
                ClassId = p.ClassId,
                ClassName = p.Class == null ? "" : p.Class.Name
            }).ToList();

            return ret;
        }

        public (bool, string) Create(StudentCreateViewModel model)
        {
            try
            {
                var student = new Student()
                {
                    Name = model.Name,
                    Email = model.Email,
                    CreatedDate = DateTime.Now,
                    PhoneNumber = model.PhoneNumber,
                    ClassId = model.ClassId
                };

                return studentRepository.Create(student);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}