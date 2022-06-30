using Domain.Entities.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class CreatedClass
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        public Guid ClassId { get; set; }

        [Required]
        public Guid TeacherId { get; set; }

        [Required]
        public Hall Location { get; set; }

        [Required]
        public Time Day { get; set; }

        //[Required]
        //public ICollection<ClassesStudents> classesStudents { get; set; }
    }
}
