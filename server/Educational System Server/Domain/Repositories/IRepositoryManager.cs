using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Respositories
{
    public interface IRepositoryManager
    {
        public IClassRepository classRepository { get; }
        public IStudentRepository studentRepository { get; }
        public ITeacherRepository teacherRepository { get; }
        public IClassesStudentsRepository classesStudentsRepository { get; }
        public ICreatedClassRepository createdClassRepository { get; }
    }
}
