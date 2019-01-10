using AspNetMvc.Api.Applications.Contract.Banco;
using AspNetMvc.Api.Domains.Dtos;
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
        public ActionResult<BancoResponse> Get(long id)
        {
            var response = new BancoResponse();

            try
            {
                response = _bancoAppService.Get(id);

                if (response.Banco.Count == 0)
                {
                    response.Message = "Dados do Banco não encontrado!";
                }
                return response;
            }
            catch (Exception ex)
            {
                response.ResourceCode = string.Empty;
                response.ErrorCode = 1;
                response.Message = "Erro ao obter a lista dos Bancos.";
                response.Erros.Add(new AspNetMvc.Api.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }

        [Route("GetAll")]
        [HttpGet]
        public ActionResult<BancoResponse> GetAll()
        {
            var response = new BancoResponse();

            try
            {
                response = _bancoAppService.GetAll();

                if (response.Banco.Count == 0)
                {
                    response.Erros.Add(new Error
                    {
                        ErrorCode = "30004",
                        ErrorMessage = "Dados do Banco não encontrado!"
                    });
                    response.Success = false;
                };
                return response;
            }
            catch (Exception ex)
            {
                response.ResourceCode = string.Empty;
                response.ErrorCode = 1;
                response.Message = "Erro ao obter a lista dos Bancos.";
                response.Erros.Add(new AspNetMvc.Api.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }

        [Route("Insert")]
        [HttpPost]
        public ActionResult<BancoResponse> Insert(BancoRequest request)
        {
            var response = new BancoResponse();

            try
            {
                var messages = request.Validate();
                if (messages.Count.Equals(0))
                {
                    response = _bancoAppService.Insert(request);
                    if (response.Banco.Count == 0)
                    {
                        response.Erros.Add(new Error
                        {
                            ErrorCode = "30000",
                            ErrorMessage = "Dados do Banco salvo não encontrado!"
                        });
                        response.Success = false;
                    };
                    return response;
                }
                else
                {
                    response.Erros = messages;
                }
            }
            catch (Exception ex)
            {
                response.ResourceCode = string.Empty;
                response.ErrorCode = 1;
                response.Message = "Erro ao obter a lista dos Bancos.";
                response.Erros.Add(new AspNetMvc.Api.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }

        [Route("Update")]
        [HttpPut]
        public ActionResult<BancoResponse> Update(BancoRequest request)
        {
            var response = new BancoResponse();

            try
            {
                var messages = request.Validate();
                if (messages.Count.Equals(0))
                {
                    response = _bancoAppService.Update(request);
                    if (response.Banco.Count == 0)
                    {
                        response.Erros.Add(new Error
                        {
                            ErrorCode = "30001",
                            ErrorMessage = "Dados do Banco salvo não encontrado!"
                        });
                        response.Success = false;
                    };
                    return response;
                }
                else
                {
                    response.Erros = messages;
                }
            }
            catch (Exception ex)
            {
                response.ResourceCode = string.Empty;
                response.ErrorCode = 1;
                response.Message = "Erro ao obter a lista dos Bancos.";
                response.Erros.Add
                    (new AspNetMvc.Api.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }

        [Route("SaveOrUpdate")]
        [HttpPost]
        public ActionResult<BancoResponse> SaveOrUpdate(BancoRequest request)
        {
            var response = new BancoResponse();

            try
            {
                var messages = request.Validate();
                if (messages.Count.Equals(0))
                {
                    if (request.Banco.BancoId == 0)
                    {
                        response = _bancoAppService.Insert(request);
                    } else
                    {
                        response = _bancoAppService.Update(request);
                    }
                    if (response.Banco.Count == 0)
                    {
                        response.Erros.Add(new Error
                        {
                            ErrorCode = "30002",
                            ErrorMessage = "Dados do Banco salvo não encontrado!"
                        });
                        response.Success = false;
                    };
                    return response;
                }
                else
                {
                    response.Erros = messages;
                }
            }
            catch (Exception ex)
            {
                response.ResourceCode = string.Empty;
                response.ErrorCode = 1;
                response.Message = "Erro ao obter a lista dos Bancos.";
                response.Erros.Add(new AspNetMvc.Api.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }

        [Route("Delete")]
        [HttpDelete]
        public ActionResult<BancoResponse> Delete(long id)
        {
            return null;
        }
    }
}