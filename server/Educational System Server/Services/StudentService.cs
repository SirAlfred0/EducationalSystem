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
    internal sealed class StudentService : IStudentService
    {
        private IRepositoryManager _repositoryManager;

        public StudentService(IRepositoryManager repositoryManager) => _repositoryManager = repositoryManager;

        public Task<List<StudentDto>> GetStudents() => _repositoryManager.studentRepository.GetAllAsync();
    }
}
