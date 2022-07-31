using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.App.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string? Phone { get; set; }

        public int? ClassId { get; set; }

        [ForeignKey("ClassId")]
        public virtual Classes? Classes { get; set; }
    }

}