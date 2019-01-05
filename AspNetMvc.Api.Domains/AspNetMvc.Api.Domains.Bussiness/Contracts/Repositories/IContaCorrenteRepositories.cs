using AspNetMvc.Api.Domains.Dtos.ContaCorrente;
using System.Collections.Generic;

namespace AspNetMvc.Api.Domains.Contracts.Repositories
{
    public interface IContaCorrenteRepositories
    {
        #region Methods

        IList<ContaCorrente> GetAll();

        ContaCorrente Get(long id);

        #endregion
    }
}
