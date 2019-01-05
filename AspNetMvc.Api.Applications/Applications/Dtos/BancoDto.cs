using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetMvc.Api.Applications.Dtos
{
    public class BancoDto
    {
        public long BancoId { get; set; }

        public string Codigo { get; set; }

        public string Nome { get; set; }

        public string Apelido { get; set; }

        public string NumeroCnpj { get; set; }

        public bool FlagStatus { get; set; }

        public long CadastroUsuarioId { get; set; }

        public DateTime CadastroDataHora { get; set; }

        public long? AtualizacaoUsuarioId { get; set; }

        public long? AtualizacaoDataHora { get; set; }
    }
}
