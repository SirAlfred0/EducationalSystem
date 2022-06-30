
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Class
    {
        [Required]
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public uint Capacity { get; set; }
        //[Required]
        //public ICollection<CreatedClass> createdClasses { get; set; }
    }
}
