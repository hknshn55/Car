using Car.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Car.Core.DataAccess
{
    public interface IRepositoryBase<T> where T:class,IEntity,new()
    {
        Task<T> Get(Expression<Func<T,bool>> expression );
        Task<List<T>> GetList(Expression<Func<T, bool>> expression = null);
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
