using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace AspNetMvc.Api.Domains.Dtos
{
    public class ResponseBase
    {
        [JsonIgnore]
        public Resource Resource { get; set; }

        private int _ErrorCode;

        /// <summary>
        /// controla se o processo ocorreu com sucesso
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// codigo do erro gravado que retorna na Api (Resource)
        /// </summary>
        public int ErrorCode { get => _ErrorCode; set { _ErrorCode = value; this.ResourceCode = string.IsNullOrEmpty(this.ResourceCode) && Resource != null ? Resource.GetById(_ErrorCode) : this.ResourceCode; } }

        /// <summary>
        /// error id gravado no log
        /// </summary>
        public int ErrorId { get; set; }

        /// <summary>
        /// Mensagem amigavel
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Track para rastreamento - Código
        /// </summary>
        public string Track { get; set; }

        /// <summary>
        /// lista com erros ocorridos no processo
        /// </summary>
        public List<Error> Erros { get; set; }

        /// <summary>
        /// Codigo cadastrado no resorce do front, para mensagens em tela
        /// </summary>
        public string ResourceCode { get; set; }

        public ResponseBase()
        {
            Resource = new Resource();
            Erros = new List<Error>();
        }

        public ResponseBase(ResponseBase dto = null)
        {
            if (dto != null)
            {
                Resource = new Resource();
                this.ErrorId = dto.ErrorId;
                this.ErrorCode = dto.ErrorCode;
                this.ResourceCode = dto.ResourceCode;
                this.Message = dto.Message;
                this.Success = dto.Success;

                if (dto.Erros != null && dto.Erros.Any())
                    this.Erros = dto.Erros;
                else
                    Erros = new List<Error>();
            }
            else
            {
                Erros = new List<Error>();
            }
        }

        public ResponseBase ParseErrorDataResponse()
        {
            return new ResponseBase
            {
                Success = this.Success,
                Message = this.Message,
                ResourceCode = this.ResourceCode,
                ErrorCode = this.ErrorCode,
                ErrorId = this.ErrorId,
                Erros = this.Erros
            };
        }

        public ResponseBase ParseDataResponse()
        {
            return new ResponseBase
            {
                Success = this.Success,
                Message = this.Message,
                ResourceCode = this.ResourceCode,
                ErrorCode = this.ErrorCode,
            };
        }
    }
}
