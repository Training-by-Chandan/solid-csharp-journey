using Solid.School.Data;
using Solid.School.Models;

namespace Solid.School.Repository
{
    public interface IClassRepository
    {
        (bool, string) Create(Class model);

        (bool, string) Delete(Class model);

        (bool, string) Edit(Class model);

        IQueryable<Class> GetAll();

        Class GetById(int id);
    }

    public class ClassRepository : IClassRepository
    {
        private readonly ApplicationDbContext db;

        public ClassRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IQueryable<Class> GetAll()
        {
            return db.Classes.Where(p => !p.IsDeleted);
        }

        public Class GetById(int id)
        {
            return db.Classes.FirstOrDefault(p => !p.IsDeleted && p.Id == id);
        }

        public (bool, string) Create(Class model)
        {
            try
            {
                db.Classes.Add(model);
                db.SaveChanges();

                return (true, "Added Successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public (bool, string) Edit(Class model)
        {
            try
            {
                db.Classes.Update(model);
                db.SaveChanges();

                return (true, "Updated Successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public (bool, string) Delete(Class model)
        {
            try
            {
                db.Classes.Remove(model);
                db.SaveChanges();

                return (true, "Deleted Successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}