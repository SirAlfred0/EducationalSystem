using Domain.Respositories;
using persistence;

namespace Presistence.Repositories
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly Lazy<IClassRepository> _lazyClassRepository;
        private readonly Lazy<ITeacherRepository> _lazyTeacherRepository;
        private readonly Lazy<IStudentRepository> _lazyStudentRepository;
        private readonly Lazy<ICreatedClassRepository> _lazyCreatedClassRepository;
        private readonly Lazy<IClassesStudentsRepository> _lazyClassesStudentsRepository;

        public RepositoryManager(RepositoryDbContext dbContext)
        {
            _lazyClassRepository = new Lazy<IClassRepository>(() => new ClassRepository(dbContext));
            _lazyTeacherRepository = new Lazy<ITeacherRepository>(() => new TeacherRepository(dbContext));
            _lazyStudentRepository = new Lazy<IStudentRepository>(() => new StudentRepository(dbContext));
            _lazyCreatedClassRepository = new Lazy<ICreatedClassRepository>(() => new CreatedClassRepository(dbContext));
            _lazyClassesStudentsRepository = new Lazy<IClassesStudentsRepository>(() => new ClassesStudentsRepository(dbContext));
        }

        public IClassRepository classRepository => _lazyClassRepository.Value;

        public IStudentRepository studentRepository => _lazyStudentRepository.Value;

        public ITeacherRepository teacherRepository => _lazyTeacherRepository.Value;

        public IClassesStudentsRepository classesStudentsRepository => _lazyClassesStudentsRepository.Value;

        public ICreatedClassRepository createdClassRepository => _lazyCreatedClassRepository.Value;

    
    }
}
