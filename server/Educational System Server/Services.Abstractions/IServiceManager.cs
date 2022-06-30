using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstractions
{
    public interface IServiceManager
    {
        public IClassService ClassService { get; }
        public ITeacherService TeacherService { get; }
        public IStudentService StudentService { get; }
    }
}
