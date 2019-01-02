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

        public virtual void Inserir(T entity)
        {
            _repositoryBase.Inserir(entity);
        }

        public virtual void Alterar(T entity)
        {
            _repositoryBase.Alterar(entity);
        }

        public virtual void Excluir(T entity)
        {
            _repositoryBase.Excluir(entity);
        }


        public virtual IEnumerable<T> SelecionarTodos(params Expression<Func<T, object>>[] includes)
        {
            return _repositoryBase.SelecionarTodos(includes);
        }

        public virtual IEnumerable<T> SelecionarTodosSomenteLeitura(params Expression<Func<T, object>>[] includes)
        {
            return SelecionarTodosSomenteLeitura(includes);
        }

        public void Commit()
        {
            _repositoryBase.Commit();
        }

    }
}
