using AspNetMvc.Api.Domains.Contracts.Repositories.Base;
using AspNetMvc.Api.Infrastructures.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace AspNetMvc.Api.Infrastructures.DataAccess.Repositories.Base
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected Contexts.DbContext DbContext;

        private bool disposed = false;

        public RepositoryBase() { }

        protected RepositoryBase(Contexts.DbContext dbContext): base()
        {
            DbContext = dbContext;
        }

        public virtual void Inserir(T entity)
        {
            DbContext.Set<T>().Add(entity);
        }

        public virtual void Alterar(T entity)
        {
            DbContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Excluir(T entity)
        {
            DbContext.Set<T>().Remove(entity);
        }

        public virtual T ObterPorId(int id)
        {
            return DbContext.Set<T>().Find(id);
        }

        public IQueryable<T> Selecionar(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
        {
            var query = DbContext.Set<T>().AsQueryable();

            if (includes != null)
                query = includes.Aggregate(query, (current, include) => current.Include(include));

            return query.Where(predicate);
        }

        public IQueryable<T> SelecionarTodos(params Expression<Func<T, object>>[] includes)
        {
            var query = DbContext.Set<T>().AsQueryable();
            if (includes != null)
                query = includes.Aggregate(query, (current, include) => current.Include(include));
            return query;
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }

        //public void Commit(string usuario)
        //{
        //    DbContext.SaveChanges(usuario);
        //}

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                if (!Equals(DbContext, null))
                {
                    DbContext.Dispose();
                }
            }

            disposed = true;
        }

    }
}