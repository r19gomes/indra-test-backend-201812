using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetMvc.Api.Infrastructures.DataAccess.Models
{
    public class TipoConta
    {
        [Key, Required, Column(Order = 0)]
        public int TipoContaId { get; set; }

        [Required, Column(Order = 1)]
        public string Nome { get; set; }

        [Required, Column(Order = 2)]
        public bool FlagStatus { get; set; }

        [Required, Column(Order = 3)]
        public long CadastroUsuarioId { get; set; }

        [Required, Column(Order = 4)]
        public DateTime CadastroDataHora { get; set; }

        [Column(Order = 5)]
        public long AtualizacaoUsuarioId { get; set; }

        [Column(Order = 6)]
        public DateTime AtualizacaoDataHora { get; set; }

        public List<ContaCorrente> ContasCorrentes { get; set; }
    }
}