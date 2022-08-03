using Microsoft.AspNetCore.Mvc.Rendering;
using Solid.School.Models;
using Solid.School.Repository;
using Solid.School.ViewModel;

namespace Solid.School.Services
{
    public interface IClassService
    {
        (bool, string) Create(ClassViewModel model);

        (bool, string) Delete(int id);

        (bool, string) Edit(ClassViewModel model);

        List<ClassViewModel> GetAll();

        ClassViewModel GetById(int id);

        IEnumerable<SelectListItem> GetDropDownItems();

        (bool, string) SoftDelete(int id);
    }

    public class ClassService : IClassService
    {
        private readonly IClassRepository classRepository;

        public ClassService(
            IClassRepository classRepository
            )
        {
            this.classRepository = classRepository;
        }

        public List<ClassViewModel> GetAll()
        {
            var data = classRepository.GetAll().Select(p => new ClassViewModel()
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description
            });

            return data.ToList();
        }

        public ClassViewModel GetById(int id)
        {
            var data = classRepository.GetById(id);
            if (data == null)
            {
                return null;
            }
            var ret = new ClassViewModel()
            {
                Id = data.Id,
                Name = data.Name,
                Description = data.Description
            };
            return ret;
        }

        public (bool, string) Create(ClassViewModel model)
        {
            try
            {
                var cls = new Class()
                {
                    Name = model.Name,
                    Description = model.Description
                };
                return classRepository.Create(cls);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public (bool, string) Edit(ClassViewModel model)
        {
            try
            {
                var existing = classRepository.GetById(model.Id);
                if (existing == null) return (false, "Record not found");

                existing.Name = model.Name;
                existing.Description = model.Description;

                return classRepository.Edit(existing);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public (bool, string) Delete(int id)
        {
            var existing = classRepository.GetById(id);
            if (existing == null) return (false, "Record Not found");

            return classRepository.Delete(existing);
        }

        public (bool, string) SoftDelete(int id)
        {
            try
            {
                var existing = classRepository.GetById(id);
                if (existing == null) return (false, "Record Not found");

                existing.IsDeleted = true;
                return classRepository.Edit(existing);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public IEnumerable<SelectListItem> GetDropDownItems()
        {
            return classRepository.GetAll().Select(p => new SelectListItem() { Text = p.Name, Value = p.Id.ToString() }).AsEnumerable();
        }
    }
}