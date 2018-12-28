using AspNetMvc.Api.Applications.Service.ContaCorrente;
using AspNetMvc.Api.Domains.Dtos.ContaCorrente;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AspNetMvc.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaCorrenteController : ControllerBase
    {
        private readonly IContaCorrenteAppService _contaCorrenteAppService;
        public ContaCorrenteController(IContaCorrenteAppService contaCorrenteAppService)
        {
            _contaCorrenteAppService = contaCorrenteAppService;
        }

        public ContaCorrenteResponse Get(ContaCorrenteRequest request)
        {
            var response = new ContaCorrenteResponse();

            try
            {
                //response = _contaCorrenteAppService.Get(null);

                if (response.ContaCorrente.Count == 0)
                {
                    response.Message = "Dados da Conta corrente não encontrado!";
                }
                return null;
            }
            catch (Exception ex)
            {
                response.ResourceCode = string.Empty;
                response.ErrorCode = 1;
                response.Message = "Erro ao obter a lista de Conta Corrente.";
                response.Erros.Add(new Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }
    }
}