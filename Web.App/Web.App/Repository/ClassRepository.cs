using Web.App.Data;
using Web.App.Models;

namespace Web.App.Repository
{
    public interface IClassRepository
    {
        (bool, string) Create(Classes model);

        (bool, string) Delete(Classes model);

        IQueryable<Classes> GetAll();

        Classes GetById(int id);

        (bool, string) Update(Classes model);
    }

    public class ClassRepository : IClassRepository
    {
        private readonly ApplicationDbContext db;

        public ClassRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IQueryable<Classes> GetAll()
        {
            return db.Classes;
        }

        public Classes GetById(int id)
        {
            return db.Classes.Find(id);
        }

        public (bool, string) Create(Classes model)
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

        public (bool, string) Update(Classes model)
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

        public (bool, string) Delete(Classes model)
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