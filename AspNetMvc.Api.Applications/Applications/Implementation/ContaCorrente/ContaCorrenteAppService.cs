using AspNetMvc.Api.Applications.Service.ContaCorrente;
using AspNetMvc.Api.Domains.Contracts;
using AspNetMvc.Api.Domains.Contracts.Services;
using AspNetMvc.Api.Domains.Dtos.ContaCorrente;
using System;

namespace AspNetMvc.Api.Applications.Implementation.ContaCorrente
{
    public class ContaCorrenteAppService : IContaCorrenteAppService
    {
        private readonly IContaCorrenteServices _contaCorrenteService;
        public ContaCorrenteAppService(IContaCorrenteServices contaCorrenteService)
        {
            _contaCorrenteService = contaCorrenteService;
        }

        public ContaCorrenteResponse GetAll(ContaCorrenteRequest request)
        {
            return _contaCorrenteService.GetAll();
        }

        public ContaCorrenteResponse Get(Int64 id)
        {
            return _contaCorrenteService.Get(id);
        }
    }
}