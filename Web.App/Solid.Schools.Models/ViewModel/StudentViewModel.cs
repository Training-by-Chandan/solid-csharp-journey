using System.ComponentModel.DataAnnotations;

namespace Solid.School.ViewModel
{
    public class StudentViewModel : StudentCreateViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Class Name")]
        public string ClassName { get; set; }
    }

    public class StudentCreateViewModel
    {
        public string Name { get; set; }

        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Display(Name = "Mobile Number")]
        public string PhoneNumber { get; set; }

        public int ClassId { get; set; }
    }
}