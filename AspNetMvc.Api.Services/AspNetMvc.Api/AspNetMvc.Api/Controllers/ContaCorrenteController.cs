using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AspNetMvc.Api.CrossCutting.Dtos;

namespace AspNetMvc.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaCorrenteController : ControllerBase
    {
        public CrossCutting.Dtos.ContaCorrente.ContaCorrenteResponse 
            Get(CrossCutting.Dtos.ContaCorrente.ContaCorrenteRequest request)
        {
            var response = new CrossCutting.Dtos.ContaCorrente.ContaCorrenteResponse();

            try
            {
                var teste = new Domains.Bussiness.ContaCorrente.ContaCorrenteBussiness();
                teste.Get();

                return null;
            }
            catch (Exception ex)
            {
                response.ResourceCode = string.Empty;
                response.ErrorCode = 1;
                response.Message = "Erro ao obter a lista de Conta Corrente.";
                response.Erros.Add(new CrossCutting.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }
    }
}