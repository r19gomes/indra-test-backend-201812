using System;
using System.Linq;
using System.Linq.Expressions;

namespace AspNetMvc.Api.Domains.Contracts.Repositories.Base
{
    public interface IRepositoryBase<T> where T : class
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);
        IQueryable<T> GetAll(params Expression<Func<T, object>>[] includes);
        IQueryable<T> Get(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);
        void Commit();
        //void Commit(string usuario);
    }
}
