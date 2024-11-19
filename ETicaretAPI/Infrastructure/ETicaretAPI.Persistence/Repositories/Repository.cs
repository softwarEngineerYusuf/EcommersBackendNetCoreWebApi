using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ETicaretDbContext _context;

        private readonly DbSet<T> _dbSet;
        public Repository(ETicaretDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }


        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }

        public async Task<T> FindSingleAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.FirstOrDefaultAsync(predicate);
        }
        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }

        public async Task UpdateAsync(T entity)
        {
           _dbSet.Update(entity);  //?
        }

        public async Task UpdateRangeAsync(IEnumerable<T> entities)  
        {
            _dbSet.UpdateRange(entities);
        }

        public async Task DeleteAsync(T entity)
        {
            _dbSet.Remove(entity); //?
        }

        public async Task RemoveRangeAsync(IEnumerable<T> entities)  
        {
            _dbSet.RemoveRange(entities);
        }

        public async Task DeleteByIdAsync(Guid id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
                _dbSet.Remove(entity);
        }




        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }


    }

}
