using AspNetMvc.Api.Domains.Dtos.ContaCorrente;
using System;
using System.Linq;

namespace AspNetMvc.Api.Applications.Service.ContaCorrente
{
    public interface IContaCorrenteQueries
    {
        ContaCorrenteResponse GetAll(ContaCorrenteRequest limiteDisponivelFiltro);
        ContaCorrenteResponse Get(Int64 id);
    }
}
