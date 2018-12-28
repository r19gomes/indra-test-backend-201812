using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetMvc.Api.Infrastructures.DataAccess.Models
{
    public class Banco
    {
        [Key, Column(Order = 0)]
        public long BancoId { get; set; }

        [Column(Order = 1), Required]
        public string Codigo { get; set; }

        [Column(Order = 2), Required]
        public string Nome { get; set; }

        [Column(Order = 3)]
        public string Apelido { get; set; }

        [Column(Order = 4)]
        public string NumeroCnpj { get; set; }

        [Column(Order = 5), Required]
        public bool FlagStatus { get; set; }

        [Column(Order = 6), Required]
        public long CadastroUsuarioId { get; set; }

        [Column(Order = 7), Required]
        public DateTime CadastroDataHora { get; set; }

        [Column(Order = 8)]
        public long AtualizacaoUsuarioId { get; set; }

        [Column(Order = 9)]
        public DateTime AtualizacaoDataHora { get; set; }

        public List<Agencia> Agencias { get; set; }
    }
}
