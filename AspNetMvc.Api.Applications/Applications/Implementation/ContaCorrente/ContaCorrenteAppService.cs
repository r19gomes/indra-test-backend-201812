using AspNetMvc.Api.Applications.Contract.ContaCorrente;
using AspNetMvc.Api.Domains.Contracts.Services;
using AspNetMvc.Api.Domains.Dtos.ContaCorrente;
using System;

namespace AspNetMvc.Api.Applications.Implementation.ContaCorrente
{
    public class ContaCorrenteAppService : IContaCorrenteAppService
    {
        #region Properties | Fields

        private readonly IContaCorrenteServices _contaCorrenteService;

        #endregion

        #region Builders

        public ContaCorrenteAppService()
        {

        }
        public ContaCorrenteAppService(IContaCorrenteServices contaCorrenteService) : base()
        {
            _contaCorrenteService = contaCorrenteService;
        }

        #endregion

        #region Methods

        public ContaCorrenteResponse GetAll()
        {
            return _contaCorrenteService.GetAll();
        }

        public ContaCorrenteResponse Get(Int64 id)
        {
            return _contaCorrenteService.Get(id);
        }

        #endregion
    }
}