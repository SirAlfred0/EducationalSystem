using Contracts.Dtos;
using Domain.Entities;
using Domain.Respositories;
using persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presistence.Repositories
{
    internal sealed class ClassRepository : IClassRepository
    {
        private RepositoryDbContext _dbContext;
        public ClassRepository(RepositoryDbContext dbContext) => _dbContext = dbContext;

        public Task<List<ClassDto>> GetAllClassesAsync()
        {
            var data = from cls in _dbContext.Classes select new {
                cls.Id,
                cls.Name,
                cls.Capacity
            };


            List<ClassDto> res = new();

            foreach(var item in data)
            {
                res.Add(new ClassDto { 
                    Id = item.Id,
                    Name = item.Name,
                    Capacity = item.Capacity
                });
            }

            return Task.FromResult(res);
        }

        public async Task<bool> Insert(Class cls)
        {
            await _dbContext.Classes.AddAsync(cls);

            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
