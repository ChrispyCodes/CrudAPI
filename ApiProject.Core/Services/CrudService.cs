using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Core.Services
{
    using System;
    using System.Threading.Tasks;
    using ApiProject.Core.Services.Interfaces;
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;

    namespace MyAPI.Services
    {
        public class CrudService<TEntity, TCreateDto, TUpdateDto, TGetDto> : ICrudService<TEntity, TCreateDto, TUpdateDto, TGetDto>
           where TEntity : class
           where TCreateDto : class
           where TUpdateDto : class
           where TGetDto : class
        {
            protected readonly DbContext _dbContext;
            protected readonly IMapper _mapper;

            public CrudService(DbContext dbContext, IMapper mapper)
            {
                _dbContext = dbContext;
                _mapper = mapper;
            }

            public virtual async Task<TEntity> Create(TCreateDto createDto)
            {
                var entity = _mapper.Map<TEntity>(createDto);
                await _dbContext.Set<TEntity>().AddAsync(entity);
                await _dbContext.SaveChangesAsync();
                return entity;
            }

            public virtual async Task Delete(int id)
            {
                var entity = await _dbContext.Set<TEntity>().FindAsync(id);
                if (entity == null)
                {
                    throw new Exception("Entity not found");
                }

                _dbContext.Set<TEntity>().Remove(entity);
                await _dbContext.SaveChangesAsync();
            }

            public virtual async Task<TGetDto> Get(int id)
            {
                var entity = await _dbContext.Set<TEntity>().FindAsync(id);
                if (entity == null)
                {
                    throw new Exception("Entity not found");
                }

                return _mapper.Map<TGetDto>(entity);
            }

            public virtual async Task<IEnumerable<TGetDto>> GetAll()
            {
                var entities = await _dbContext.Set<TEntity>().ToListAsync();
                return _mapper.Map<IEnumerable<TGetDto>>(entities);
            }

            public virtual async Task<TEntity> Update(int id, TUpdateDto updateDto)
            {
                var entity = await _dbContext.Set<TEntity>().FindAsync(id);
                if (entity == null)
                {
                    throw new Exception("Entity not found");
                }

                _mapper.Map(updateDto, entity);
                await _dbContext.SaveChangesAsync();
                return entity;
            }
        }
    }

}
