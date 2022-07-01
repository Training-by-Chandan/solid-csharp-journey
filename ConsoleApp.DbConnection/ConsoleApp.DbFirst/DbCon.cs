using ConsoleApp.DbFirst.Data;
using ConsoleApp.DbFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp.DbFirst
{
    public static class DbCon
    {
        private static DefaultContext db = new DefaultContext();

        public static void GetAll()
        {
            var data = db.Students.Include(p => p.Teachers).ToList();
            foreach (var item in data)
            {
                //var teacher = db.Teachers.Find(item.TeacherId);
                Console.WriteLine($"Id : {item.Id}");
                Console.WriteLine($"Name : {item.Name}");
                Console.WriteLine($"Email : {item.Email}");
                Console.WriteLine($"Phone : {item.Phone}");
                Console.WriteLine($"Teacher : {item.Teachers.Name}");
                Console.WriteLine("========================================");
            }
        }

        public static void GetById()
        {
            Console.WriteLine("Enter the id");
            var id = Convert.ToInt32(Console.ReadLine());
            var item = db.Students.Find(id);

            Console.WriteLine($"Id : {item.Id}");
            Console.WriteLine($"Name : {item.Name}");
            Console.WriteLine($"Email : {item.Email}");
            Console.WriteLine($"Phone : {item.Phone}");
            Console.WriteLine("========================================");
        }

        public static void Create()
        {
            var student = new Student();
            Console.WriteLine("Enter the name");
            student.Name = Console.ReadLine();
            Console.WriteLine("Enter the email");
            student.Email = Console.ReadLine();
            Console.WriteLine("Enter the phone");
            student.Phone = Console.ReadLine();

            db.Students.Add(student);
            db.SaveChanges();
        }

        public static void Edit()
        {
            Console.WriteLine("Enter the id");
            var id = Convert.ToInt32(Console.ReadLine());
            var existing = db.Students.Find(id);
            if (existing != null)
            {
                Console.WriteLine("Enter the name");
                existing.Name = Console.ReadLine();
                Console.WriteLine("Enter the email");
                existing.Email = Console.ReadLine();
                Console.WriteLine("Enter the phone");
                existing.Phone = Console.ReadLine();

                db.Students.Update(existing);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("Record not found");
            }
        }

        public static void Delete()
        {
            Console.WriteLine("Enter the id");
            var id = Convert.ToInt32(Console.ReadLine());
            var existing = db.Students.Find(id);
            if (existing != null)
            {
                db.Students.Remove(existing);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("Record not found");
            }
        }

        public static void GetTeachers()
        {
            var teachers = db.Teachers.Include(p => p.Students).ToList();
            foreach (var item in teachers)
            {
                Console.WriteLine($"Id : {item.Id}");
                Console.WriteLine($"Name : {item.Name}");
                Console.WriteLine($"Email : {item.Email}");
                Console.WriteLine($"Number of Students : {item.Students.Count}");
            }
        }
    }
}