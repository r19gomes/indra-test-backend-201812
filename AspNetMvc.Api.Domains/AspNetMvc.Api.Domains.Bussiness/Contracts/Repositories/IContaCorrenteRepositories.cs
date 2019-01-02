using AspNetMvc.Api.Domains.Dtos.ContaCorrente;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AspNetMvc.Api.Domains.Contracts.Repositories
{
    public interface IContaCorrenteRepositories
    {
        IList<ContaCorrente> GetAll();
        ContaCorrente Get(Int64 id);
    }
}
