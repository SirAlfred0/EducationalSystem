using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Student
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        //[Required]
        //public ICollection<ClassesStudents> classesStudents { get; set; }
    }
}
