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
    internal sealed class TeacherRepository : ITeacherRepository
    {
        private RepositoryDbContext _dbContext;
        public TeacherRepository(RepositoryDbContext dbContext) => _dbContext = dbContext;

        public Task<List<TeacherDto>> GetAllTeachersAsync()
        {
            var data = from cls in _dbContext.Teachers
                       select new
                       {
                           cls.Id,
                           cls.Name,
                       };


            List<TeacherDto> res = new();

            foreach (var item in data)
            {
                res.Add(new TeacherDto
                {
                    Id = item.Id,
                    Name = item.Name,
                });
            }

            return Task.FromResult(res);
        }
    }
}
