using AspNetMvc.Api.Domains.Dtos.Banco;
using System.Collections.Generic;

namespace AspNetMvc.Api.Domains.Contracts.Repositories
{
    public interface IBancoRepositories
    {
        #region Methods

        IList<Banco> GetAll();

        Banco Get(long id);

        Banco Insert(BancoRequest request);

        Banco Update(BancoRequest request);

        #endregion
    }
}
