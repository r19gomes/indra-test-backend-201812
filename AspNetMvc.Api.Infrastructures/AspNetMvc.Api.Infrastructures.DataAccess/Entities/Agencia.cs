using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AspNetMvc.Api.Infrastructures.DataAccess.Entities
{
    [Table("Agencias")]
    public partial class Agencia
    {
        public long BancoId { get; set; }

        public long AgendaId { get; set; }

        public string Nome { get; set; }

        public int Numero { get; set; }

        public byte Digito { get; set; }

        public bool FlagStatus { get; set; }

        public long CadastroUsuarioId { get; set; }

        public DateTime CadastroDataHora { get; set; }

        public long AtualizacaoUsuarioId { get; set; }

        public DateTime AtualizacaoDataHora { get; set; }

        public virtual Banco Banco { get; set; }

        public virtual List<ContaCorrente> ContasCorrentes { get; set; }
    }
}
