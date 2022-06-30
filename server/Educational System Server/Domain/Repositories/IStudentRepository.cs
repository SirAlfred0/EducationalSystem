using Contracts.Dtos;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Respositories
{
    public interface IStudentRepository
    {
        public Task<List<StudentDto>> GetAllAsync();
    }
}
