using AspNetMvc.Api.Domains.Dtos.ContaCorrente;
using System;

namespace AspNetMvc.Api.Applications.Contract.ContaCorrente
{
    public interface IContaCorrenteQueries
    {
        ContaCorrenteResponse GetAll();

        ContaCorrenteResponse Get(Int64 id);
    }
}
