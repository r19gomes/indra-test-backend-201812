using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AspNetMvc.Api.Domains.Services.Base
{
    public interface IDomainServiceBase<T> where T : class
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includes);
        void Commit();
    }
}
