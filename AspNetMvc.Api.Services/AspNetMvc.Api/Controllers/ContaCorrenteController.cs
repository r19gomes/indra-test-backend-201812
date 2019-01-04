using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetMvc.Api.Applications.Contract.ContaCorrente;
using AspNetMvc.Api.Domains.Dtos.ContaCorrente;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaCorrenteController : ControllerBase
    {
        private readonly IContaCorrenteAppService _contaCorrenteAppService;

        public ContaCorrenteController(IContaCorrenteAppService contaCorrenteAppService): base()
        {
            _contaCorrenteAppService = contaCorrenteAppService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<ContaCorrenteResponse> Get()
        {
            var response = new ContaCorrenteResponse();

            try
            {
                response = _contaCorrenteAppService.GetAll();

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
                response.Erros.Add(new AspNetMvc.Api.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
