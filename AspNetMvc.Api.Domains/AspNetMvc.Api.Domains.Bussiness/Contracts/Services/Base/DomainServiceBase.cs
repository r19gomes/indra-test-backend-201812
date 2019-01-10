using AspNetMvc.Api.Domains.Contracts.Repositories.Base;
using AspNetMvc.Api.Domains.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AspNetMvc.Api.Domains.Contracts.Services.Base
{
    public abstract class DomainServiceBase<T> : IDomainServiceBase<T> where T : class
    {
        private readonly IRepositoryBase<T> _repositoryBase;

        public DomainServiceBase(IRepositoryBase<T> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public virtual void Insert(T entity)
        {
            _repositoryBase.Insert(entity);
        }

        public virtual void Update(T entity)
        {
            _repositoryBase.Update(entity);
        }

        public virtual void Delete(T entity)
        {
            _repositoryBase.Delete(entity);
        }


        public virtual IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includes)
        {
            return _repositoryBase.GetAll(includes);
        }

        public void Commit()
        {
            _repositoryBase.Commit();
        }

    }
}
