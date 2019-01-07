using AspNetMvc.Api.Domains.Dtos.Banco;

namespace AspNetMvc.Api.Applications.Contract.Banco
{
    public interface IBancoCommand
    {
        BancoResponse Insert(BancoRequest request);
    }
}
