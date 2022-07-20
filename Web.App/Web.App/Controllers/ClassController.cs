using Microsoft.AspNetCore.Mvc;
using Web.App.Data;
using Web.App.Models;

namespace Web.App.Controllers
{
    public class ClassController : Controller
    {
        private readonly ApplicationDbContext db;

        public ClassController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var data = db.Classes.ToList();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Classes model)
        {
            db.Classes.Add(model);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var existing = db.Classes.Find(id);
            return View(existing);
        }

        [HttpPost]
        public IActionResult Edit(Classes model)
        {
            db.Classes.Update(model);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var existing = db.Classes.Find(id);
            return View(existing);
        }

        [HttpPost]
        public IActionResult Delete(Classes model)
        {
            var existing = db.Classes.Find(model.Id);
            db.Classes.Remove(existing);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}