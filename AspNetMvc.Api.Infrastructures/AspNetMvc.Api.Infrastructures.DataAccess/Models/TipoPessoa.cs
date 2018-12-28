using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetMvc.Api.Infrastructures.DataAccess.Models
{
    public class TipoPessoa
    {
        [Key, Column(Order = 0), Required]
        public int TipoPessoaId { get; set; }

        [Column(Order = 1), Required]
        public string Nome { get; set; }

        [Column(Order = 2)]
        public string Apelido { get; set; }

        [Column(Order = 3), Required]
        public string Sigla { get; set; }

        [Column(Order = 4), Required]
        public long CadastroUsuarioId { get; set; }

        [Column(Order = 5), Required]
        public DateTime CadastroDataHora { get; set; }

        [Column(Order = 6)]
        public long AtualizacaoUsuarioId { get; set; }

        [Column(Order = 7)]
        public DateTime AtualizacaoDataHora { get; set; }

        public List<ContaCorrente> ContasCorrentes { get; set; }
    }
}
