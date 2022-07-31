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
                PhoneNumber = p.PhoneNumber
            }).ToList();

            return ret;
        }
    }
}