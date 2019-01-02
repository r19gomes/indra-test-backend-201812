using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AspNetMvc.Api.Domains.Services.Base
{
    public interface IDomainServiceBase<T> where T : class
    {
        void Inserir(T entity);
        void Alterar(T entity);
        void Excluir(T entity);
        IEnumerable<T> SelecionarTodos(params Expression<Func<T, object>>[] includes);
        IEnumerable<T> SelecionarTodosSomenteLeitura(params Expression<Func<T, object>>[] includes);
        void Commit();
    }
}
