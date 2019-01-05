using AspNetMvc.Api.Domains.Dtos.Banco;

namespace AspNetMvc.Api.Applications.Contract.Banco
{
    public interface IBancoQueries
    {
        BancoResponse GetAll();

        BancoResponse Get(long id);
    }
}
