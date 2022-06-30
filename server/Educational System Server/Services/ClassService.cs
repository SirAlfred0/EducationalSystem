using Contracts.Domains;
using Contracts.Dtos;
using Domain.Entities;
using Domain.Entities.Enums;
using Domain.Respositories;
using Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    internal sealed class ClassService : IClassService
    {
        public IRepositoryManager _repositoryManager;

        public ClassService(IRepositoryManager respositoryManager) => _repositoryManager = respositoryManager;

        public async Task<ResultDto> CreateClass(CreateClassDomain domain)
        {
            var cls = new CreatedClass
            {
                Id = new Guid(),
                ClassId = domain.ClassId,
                TeacherId = domain.TeacherId,
                Location =  (Hall) domain.Location,
                Day =  (Time) domain.Day
            };

            await _repositoryManager.createdClassRepository.Insert(cls);

            foreach(var item in domain.StudentsList)
            {
                var cls2 = new ClassesStudents
                {
                    Id = new Guid(),
                    CreatedClassId = cls.Id,
                    StudentId = item,
                };
                await _repositoryManager.classesStudentsRepository.Insert(cls2);
            }

            return new ResultDto
            {
                Result = true,
            };
        }

        public async Task<ResultDto> DefineClass(DefineClassDomain domain)
        {

            var cls = new Class
            {
                Id = Guid.NewGuid(),
                Name = domain.Name,
                Capacity = domain.Capacity
            };

            await _repositoryManager.classRepository.Insert(cls);


            return new ResultDto
            {
                Result = true,
            };
        }

        public Task<List<ClassDto>> GetClasses()
        {
            var classes = _repositoryManager.classRepository.GetAllClassesAsync();

            return classes;
        }
    }
}
