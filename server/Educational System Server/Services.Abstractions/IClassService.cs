using Contracts.Domains;
using Contracts.Dtos;
using Domain.Entities.Enums;


namespace Services.Abstractions
{
    public interface IClassService
    {
        Task<List<ClassDto>> GetClasses();

        Task<ResultDto> DefineClass(DefineClassDomain domain);

        Task<ResultDto> CreateClass(CreateClassDomain domain);
    }
}
