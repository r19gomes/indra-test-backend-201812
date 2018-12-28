using AspNetMvc.Api.Domains.Dtos.ContaCorrente;
using System;
using System.Linq;

namespace AspNetMvc.Api.Domains.Contracts.Repositories
{
    public interface IContaCorrenteRepositories
    {
        IQueryable<ContaCorrente> GetAll();
        ContaCorrente Get(Int64 id);
    }
}
