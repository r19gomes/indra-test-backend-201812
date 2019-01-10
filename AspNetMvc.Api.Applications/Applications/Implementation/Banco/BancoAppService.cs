using AspNetMvc.Api.Applications.Contract.Banco;
using AspNetMvc.Api.Domains.Contracts.Services;
using AspNetMvc.Api.Domains.Dtos.Banco;

namespace AspNetMvc.Api.Applications.Implementation.Banco
{
    public class BancoAppService: IBancoAppService
    {
        #region Properties | Fields

        private readonly IBancoServices _bancoService;

        #endregion

        #region Builders

        public BancoAppService()
        {

        }

        public BancoAppService(IBancoServices bancoService) : base()
        {
            _bancoService = bancoService;
        }

        #endregion

        #region Methods

        public BancoResponse Get(long id)
        {
            return _bancoService.Get(id);
        }

        public BancoResponse GetAll()
        {
            return _bancoService.GetAll();
        }

        public BancoResponse Insert(BancoRequest request)
        {
            return _bancoService.Insert(request);
        }

        public BancoResponse Update(BancoRequest request)
        {
            return _bancoService.Update(request);
        }

        #endregion

    }
}
