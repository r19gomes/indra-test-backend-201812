using AspNetMvc.Api.Domains.Dtos.ContaCorrente;
using System;

namespace AspNetMvc.Api.Domains.Contracts.Services
{
    public interface IContaCorrenteServices
    {
        #region Methods

        ContaCorrenteResponse GetAll();

        ContaCorrenteResponse Get(Int64 id);

        #endregion
    }
}
