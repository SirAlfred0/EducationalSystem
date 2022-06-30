using Domain.Entities;
using Domain.Respositories;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using persistence;

namespace Presistence.Repositories
{
    internal sealed class ClassesStudentsRepository : IClassesStudentsRepository
    {
        private RepositoryDbContext _dbContext;

        public ClassesStudentsRepository(RepositoryDbContext dbContext) => _dbContext = dbContext;

        public async Task<bool> Insert(ClassesStudents cls)
        {
            await _dbContext.ClassesStudents.AddAsync(cls);

            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
