
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class ClassesStudents
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        public Guid CreatedClassId { get; set; }

        [Required]
        public Guid StudentId { get; set; }

    }
}
