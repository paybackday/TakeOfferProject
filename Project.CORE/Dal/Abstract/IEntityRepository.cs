using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.CORE.Dal.Abstract
{
    public interface IEntityRepository<T> where T : class,new()
    {
        Task<T> GetAsync(Expression<Func<T,bool>> predicate);
        Task<IList<T>> GetAllAsync(Expression<Func<T,bool>> predicate=null);

        Task<T> AddAsync(T entity); // Entity will come as a parameter and we will add and return. Reason of return is for the we can give toaster or info message to the user.
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        Task<int> CountAsync(Expression<Func<T, bool>> predicate);


    }
}
