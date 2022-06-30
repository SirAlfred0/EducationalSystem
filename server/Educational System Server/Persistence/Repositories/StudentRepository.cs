using Contracts.Dtos;
using Domain.Respositories;
using persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presistence.Repositories
{
    internal sealed class StudentRepository : IStudentRepository
    {
        private RepositoryDbContext _dbContext;

        public StudentRepository(RepositoryDbContext dbContext) => _dbContext = dbContext;

        public Task<List<StudentDto>> GetAllAsync()
        {
            var data = from cls in _dbContext.Students
                       select new
                       {
                           cls.Id,
                           cls.Name,
                       };


            List<StudentDto> res = new();

            foreach (var item in data)
            {
                res.Add(new StudentDto
                {
                    Id = item.Id,
                    Name = item.Name,
                });
            }

            return Task.FromResult(res);
        }
    }
}
