using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetMvc.Api.Infrastructures.DataAccess.Entities
{
    public class Lancamento
    {
        public long LancamentoId { get; set; }

        public long BancoId { get; set; }

        public long AgenciaId { get; set; }

        public long ContaCorrenteId { get; set; }

        public string TipoLancamento { get; set; }

        public string Titulo { get; set; }

        public string Conteudo { get; set; }

        public bool FlagStatus { get; set; }

        public long LancamentoPaiId { get; set; }

        public long CadastroUsuarioId { get; set; }

        public DateTime CadastroDataHora { get; set; }

        public long AtualizacaoUsuarioId { get; set; }

        public DateTime AtualizacaoDataHora { get; set; }

        public virtual ContaCorrente ContaCorrente { get; set; }

        public virtual Lancamento LancamentoPai { get; set; }

    }
}
