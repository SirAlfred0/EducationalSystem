using Contracts.Dtos;
using Domain.Respositories;
using Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    internal sealed class TeacherService : ITeacherService
    {
        private IRepositoryManager _repositoryManager;

        public TeacherService(IRepositoryManager respositoryManager) => _repositoryManager = respositoryManager;

        public Task<List<TeacherDto>> GetTeachers() => _repositoryManager.teacherRepository.GetAllTeachersAsync();
    }
}
