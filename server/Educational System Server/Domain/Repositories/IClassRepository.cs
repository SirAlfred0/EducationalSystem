using Contracts.Dtos;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Respositories
{
    public interface IClassRepository
    {
        public Task<bool> Insert(Class cls);

        public Task<List<ClassDto>> GetAllClassesAsync();
    }
}
