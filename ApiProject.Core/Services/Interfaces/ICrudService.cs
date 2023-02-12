using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Core.Services.Interfaces
{
    public interface ICrudService<TEntity, TCreateDto, TUpdateDto, TGetDto>
       where TEntity : class
       where TCreateDto : class
       where TUpdateDto : class
       where TGetDto : class
    {
        Task<TGetDto> Get(int id);
        Task<IEnumerable<TGetDto>> GetAll();
        Task<TEntity> Create(TCreateDto createDto);
        Task<TEntity> Update(int id, TUpdateDto updateDto);
        Task Delete(int id);
    }
}
