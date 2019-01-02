using System;
using System.Collections.Generic;

namespace AspNetMvc.Api.Infrastructures.DataAccess.Entities
{
    public partial class ContaCorrente
    {
        public long BancoId { get; set; }

        public long AgenciaId { get; set; }

        public long ContaCorrenteId { get; set; }

        public int TipoContaId { get; set; }

        public int Numero { get; set; }

        public byte Digito { get; set; }

        public string Titular { get; set; }

        public string TitularCnpjCpf { get; set; }

        public int TipoPessoaId { get; set; }

        public string Observacao { get; set; }

        public bool FlagStatus { get; set; }

        public long CadastroUsuarioId { get; set; }

        public DateTime CadastroDataHora { get; set; }

        public long AtualizacaoUsuarioId { get; set; }

        public DateTime AtualizacaoDataHora { get; set; }

        public virtual Agencia Agencia { get; set; }

        public virtual TipoConta TipoConta { get; set; }

        public virtual TipoPessoa TipoPessoa { get; set; }

        public virtual List<Lancamento> Lancamentos { get; set; }
    }
}
