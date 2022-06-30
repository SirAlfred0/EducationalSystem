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
    internal sealed class CreatedClassRepository : ICreatedClassRepository
    {
        private RepositoryDbContext _dbContext;

        public CreatedClassRepository(RepositoryDbContext dbContext) => _dbContext = dbContext;

        public async Task<bool> Insert(CreatedClass cls)
        {
            await _dbContext.CreatedClasses.AddAsync(cls);

            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
