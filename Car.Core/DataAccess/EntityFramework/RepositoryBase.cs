using Car.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Car.Core.DataAccess.EntityFramework
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T:class,IEntity,new()
    {
        public DbContext _db;
        public DbSet<T> _set;
        public RepositoryBase(DbContext context)
        {
            _db = context;
            _set = _db.Set<T>();

        }
        public async Task Add(T entity)
        {
            _set.Add(entity);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            _set.Remove(entity);
            await _db.SaveChangesAsync();
        }

        public async Task<T> Get(Expression<Func<T, bool>> expression)
        {
            return await _set.FirstOrDefaultAsync(expression);
        }

        public async Task<List<T>> GetList(Expression<Func<T, bool>> expression = null)
        {
            return 
                expression == null ?
                await _set.ToListAsync() 
                : await _set.Where(expression).ToListAsync();
        }

        public async Task Update(T entity)
        {
            _set.Update(entity);
            await _db.SaveChangesAsync();
        }
    }
}
