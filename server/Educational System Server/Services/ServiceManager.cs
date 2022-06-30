using Domain.Respositories;
using Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IClassService> _lazyClassService;
        private readonly Lazy<ITeacherService> _lazyTeacherService;
        private readonly Lazy<IStudentService> _lazyStudentService;

        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _lazyClassService = new Lazy<IClassService>(() => new ClassService(repositoryManager));
            _lazyTeacherService = new Lazy<ITeacherService>(() => new TeacherService(repositoryManager));
            _lazyStudentService = new Lazy<IStudentService>(() => new StudentService(repositoryManager));
        }

        public IClassService ClassService => _lazyClassService.Value;

        public ITeacherService TeacherService => _lazyTeacherService.Value;

        public IStudentService StudentService => _lazyStudentService.Value;
    }
}
