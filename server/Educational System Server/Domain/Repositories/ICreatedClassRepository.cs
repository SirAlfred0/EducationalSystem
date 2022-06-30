using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Respositories
{
    public interface ICreatedClassRepository
    {
        public Task<bool> Insert(CreatedClass cls);
    }
}
