using System;
using System.Collections.Generic;

namespace AspNetMvc.Api.Domains.Dtos.Banco
{
    public class BancoRequest : RequestBase
    {
        #region Properties | Fields

        public Banco Banco { get; set; }

        #endregion

        #region Builders

        public BancoRequest()
        {
            Banco = new Banco();
        }

        public List<Error> Validate()
        {
            var messages = new List<Error>();

            if (!string.IsNullOrEmpty(Banco.Codigo))
            {
                var error = new Error()
                {
                    ErrorCode = "00001",
                    ErrorMessage = "Código do Banco é obrigatório!"
                };
                messages.Add(error);
            }

            if (!string.IsNullOrEmpty(Banco.Nome))
            {
                var error = new Error()
                {
                    ErrorCode = "00002",
                    ErrorMessage = "Nome do Banco é obrigatório!"
                };
                messages.Add(error);
            }

            if (Banco.CadastroUsuarioId == 0)
            {
                var error = new Error()
                {
                    ErrorCode = "00003",
                    ErrorMessage = "Usuário responsável pelo cadastro é obrigatório!"
                };
                messages.Add(error);
            }

            if (Banco.CadastroDataHora == null)
            {
                var error = new Error()
                {
                    ErrorCode = "00004",
                    ErrorMessage = "Data e hora de cadastro e obrigatório!"
                };
                messages.Add(error);
            }

            return messages;
        }

        #endregion
    }
}
