using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetMvc.Api.Infrastructures.DataAccess.Models
{
    public partial class Agencia
    {
        [Key, ForeignKey("Bancos"), Column(Order = 0), Required]
        public long BancoId { get; set; }

        [Key, Column(Order = 1), Required]
        public long AgendaId { get; set; }

        [Column(Order = 2), Required]
        public string Nome { get; set; }

        [Column(Order = 3), Required]
        public int Numero { get; set; }

        [Column(Order = 4)]
        public byte Digito { get; set; }

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

        public Banco Banco { get; set; }

        public List<ContaCorrente> ContasCorrentes { get; set; }
    }
}