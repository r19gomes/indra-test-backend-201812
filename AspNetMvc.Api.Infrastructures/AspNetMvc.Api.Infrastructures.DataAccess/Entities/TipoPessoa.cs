using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetMvc.Api.Infrastructures.DataAccess.Entities
{
    public class TipoPessoa
    {
        public int TipoPessoaId { get; set; }

        public string Nome { get; set; }

        public string Apelido { get; set; }

        public string Sigla { get; set; }

        public long CadastroUsuarioId { get; set; }

        public DateTime CadastroDataHora { get; set; }

        public long AtualizacaoUsuarioId { get; set; }

        public DateTime AtualizacaoDataHora { get; set; }

        public virtual List<ContaCorrente> ContasCorrentes { get; set; }
    }
}
