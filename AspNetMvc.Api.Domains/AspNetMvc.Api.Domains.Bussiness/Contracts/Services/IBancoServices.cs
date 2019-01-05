using AspNetMvc.Api.Domains.Dtos.Banco;

namespace AspNetMvc.Api.Domains.Contracts.Services
{
    public interface IBancoServices
    {
        #region Methods

        BancoResponse GetAll();

        BancoResponse Get(long id);

        #endregion
    }
}
