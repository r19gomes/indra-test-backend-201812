using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetMvc.Api.Infrastructures.DataAccess.Models
{
    public class ContaCorrente
    {
        [Key, ForeignKey("Agencias"), Column(Order = 0), Required]
        public long BancoId { get; set; }

        [Key, ForeignKey("Agencias"), Column(Order = 1), Required]
        public long AgenciaId { get; set; }

        [Key, Column(Order = 2), Required]
        public long ContaCorrenteId { get; set; }

        [ForeignKey("TiposContas"), Column(Order = 3), Required]
        public int TipoContaId { get; set; }

        [Column(Order = 4), Required]
        public string Numero { get; set; }

        [Column(Order = 5)]
        public string Digito { get; set; }

        [Column(Order = 6), Required]
        public string Titular { get; set; }

        [Column(Order = 7)]
        public string TitularCnpjCpf { get; set; }

        [ForeignKey("TiposPessoas")]
        [Column(Order = 8), Required]
        public int TipoPessoaId { get; set; }

        [Column(Order = 9)]
        public string Observacao { get; set; }

        [Column(Order = 10), Required]
        public bool FlagStatus { get; set; }

        [Column(Order = 11), Required]
        public long CadastroUsuarioId { get; set; }

        [Column(Order = 12), Required]
        public DateTime CadastroDataHora { get; set; }

        [Column(Order = 13)]
        public long AtualizacaoUsuarioId { get; set; }

        [Column(Order = 14)]
        public DateTime AtualizacaoDataHora { get; set; }

        [Column(Order = 15)]
        public Agencia Agencia { get; set; }

        public TipoConta TipoConta { get; set; }

        public TipoPessoa TipoPessoa { get; set; }

        public List<Lancamento> Lancamentos { get; set; }
    }
}