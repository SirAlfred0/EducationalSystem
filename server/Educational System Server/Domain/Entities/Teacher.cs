using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Teacher
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        //[Required]
        //public ICollection<CreatedClass> createdClasses { get;  set; }
    }
}
