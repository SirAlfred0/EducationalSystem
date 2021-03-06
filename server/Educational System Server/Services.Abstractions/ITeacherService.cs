using Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstractions
{
    public interface ITeacherService
    {
        Task<List<TeacherDto>> GetTeachers();
    }
}
