using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetMvc.Api.Infrastructures.DataAccess.Entities
{
    [Table("Bancos")]
    public partial class Banco
    {
        [Key]
        public long BancoId { get; set; }

        public string Codigo { get; set; }

        public string Nome { get; set; }

        public string Apelido { get; set; }

        public string NumeroCnpj { get; set; }

        public string WebSiteOficial { get; set; }

        public bool FlagStatus { get; set; }

        public long CadastroUsuarioId { get; set; }

        public DateTime CadastroDataHora { get; set; }

        public long? AtualizacaoUsuarioId { get; set; }

        public DateTime? AtualizacaoDataHora { get; set; }

        public virtual List<Agencia> Agencias { get; set; }
    }
}
