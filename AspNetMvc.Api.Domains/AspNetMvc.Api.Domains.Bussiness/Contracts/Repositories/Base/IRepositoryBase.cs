using System;
using System.Linq;
using System.Linq.Expressions;

namespace AspNetMvc.Api.Domains.Contracts.Repositories.Base
{
    public interface IRepositoryBase<T> where T : class
    {
        void Inserir(T entity);
        void Alterar(T entity);
        void Excluir(T entity);
        T ObterPorId(int id);
        IQueryable<T> SelecionarTodos(params Expression<Func<T, object>>[] includes);
        IQueryable<T> Selecionar(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);
        void Commit();
        //void Commit(string usuario);
    }
}
