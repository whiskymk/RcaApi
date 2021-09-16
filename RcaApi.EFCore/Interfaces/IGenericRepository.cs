using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RcaApi.EFCore
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);

        Task<T> CreateAsync(T _object);
        void Add(T entity);
        void Update(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveById(int id);
        void RemoveRange(IEnumerable<T> entities);
    }
}
