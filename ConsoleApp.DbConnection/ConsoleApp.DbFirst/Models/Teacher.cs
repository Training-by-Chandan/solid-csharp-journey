namespace ConsoleApp.DbFirst.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}