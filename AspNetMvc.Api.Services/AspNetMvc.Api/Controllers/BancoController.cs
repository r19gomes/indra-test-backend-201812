using AspNetMvc.Api.Applications.Contract.Banco;
using AspNetMvc.Api.Domains.Dtos.Banco;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AspNetMvc.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BancoController : ControllerBase
    {
        private readonly IBancoAppService _bancoAppService;

        public BancoController(IBancoAppService bancoAppService) : base()
        {
            _bancoAppService = bancoAppService;
        }

        [Route("Get")]
        [HttpGet]
        public ActionResult<BancoResponse> Get()
        {
            var response = new BancoResponse();

            try
            {
                response = _bancoAppService.GetAll();

                if (response.Banco.Count == 0)
                {
                    response.Message = "Dados da Conta corrente não encontrado!";
                }
                return response;
            }
            catch (Exception ex)
            {
                response.ResourceCode = string.Empty;
                response.ErrorCode = 1;
                response.Message = "Erro ao obter a lista de Conta Corrente.";
                response.Erros.Add(new AspNetMvc.Api.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }

        [Route("Insert")]
        [HttpPost]
        public ActionResult<BancoResponse> Insert()
        {
            return null;
        }

        [Route("Update")]
        [HttpPut]
        public ActionResult<BancoResponse> Update()
        {
            return null;
        }

        [Route("SaveOrUpdate")]
        [HttpPost]
        public ActionResult<BancoResponse> SaveOrUpdate()
        {
            return null;
        }

        [Route("Delete")]
        [HttpDelete]
        public ActionResult<BancoResponse> Delete(long id)
        {
            return null;
        }
    }
}