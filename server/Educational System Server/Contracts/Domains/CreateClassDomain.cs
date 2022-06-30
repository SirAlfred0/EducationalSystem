using Domain.Entities.Enums;

namespace Contracts.Domains
{
    public class CreateClassDomain
    {
        public Guid TeacherId { get; set; }
        public Guid ClassId { get; set; }
        public int Location { get; set; }
        public int Day { get; set; }
        public Guid[] StudentsList { get; set; }
    }
}
