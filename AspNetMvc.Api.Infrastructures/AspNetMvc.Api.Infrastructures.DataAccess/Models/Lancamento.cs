using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetMvc.Api.Infrastructures.DataAccess.Models
{
    public class Lancamento
    {
        [Key, Column(Order = 0), Required]
        public long LancamentoId { get; set; }

        [ForeignKey("ContasCorrentes"), Column(Order = 1), Required]
        public long BancoId { get; set; }
        
        [ForeignKey("ContasCorrentes"), Column(Order = 2), Required]
        public long AgenciaId { get; set; }

        [ForeignKey("ContasCorrentes"), Column(Order = 3), Required]
        public long ContaCorrenteId { get; set; }

        [Column(Order = 4), Required]
        public string TipoLancamento { get; set; }

        [Column(Order = 5), Required]
        public string Titulo { get; set; }

        [Column(Order = 6)]
        public string Conteudo { get; set; }

        [Column(Order = 7), Required]
        public bool FlagStatus { get; set; }

        [ForeignKey("Lancamentos"), Column(Order = 8)]
        public long LancamentoPaiId { get; set; }

        [Column(Order = 9), Required]
        public long CadastroUsuarioId { get; set; }

        [Column(Order = 10), Required]
        public DateTime CadastroDataHora { get; set; }

        [Column(Order = 11), Required]
        public long AtualizacaoUsuarioId { get; set; }

        [Column(Order = 12), Required]
        public DateTime AtualizacaoDataHora { get; set; }

        public ContaCorrente ContaCorrente { get; set; }

        public Lancamento LancamentoPai { get; set; }

    }
}