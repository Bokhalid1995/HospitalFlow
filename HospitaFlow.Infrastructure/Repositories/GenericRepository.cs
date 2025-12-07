using AutoMapper;
using HospitaFlow.Application.Interfaces.Common;
using HospitaFlow.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitaFlow.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly AppDbContext _context;
        protected readonly IMapper _mapper;
        protected readonly DbSet<T> _dbSet;

        public GenericRepository(AppDbContext dbContext, IMapper mapper)
        {
            _context = dbContext;
            _mapper = mapper;
            _dbSet = _context.Set<T>();
        }

        public IQueryable<T> Query() => _context.Set<T>().AsQueryable();

        public async Task<T?> GetByIdAsync(int id) => await _context.Set<T>().FindAsync(id);

        public async Task AddAsync(T entity) => await _context.Set<T>().AddAsync(entity);

        public void Update(T entity) => _context.Set<T>().Update(entity);

        public void Delete(T entity) => _context.Set<T>().Remove(entity);

      
        //public async Task<T> AddAsync(T entity)
        //{
        //    await _dbSet.AddAsync(entity);
        //    await _dbContext.SaveChangesAsync();
        //    return entity;
        //}

        //public async Task<bool> DeleteAsync(int Id)
        //{
        //    var entity = await _dbSet.FindAsync(Id);
        //    if (entity == null) return false;

        //    _dbSet.Remove(entity);
        //    return await _dbContext.SaveChangesAsync() > 0;
        //}

        //public IQueryable<T> GetAll()
        //{
        //    return _dbSet.AsQueryable();
        //}

        //public async Task<T?> GetByIdAsync(int Id)
        //{
        //    return await _dbSet.FindAsync(Id);
        //}

        //public async Task<T> UpdateAsync( T entity)
        //{    

        //    _dbSet.Update(entity);
        //    await _dbContext.SaveChangesAsync();
        //    return entity;
        //}
    }
}
