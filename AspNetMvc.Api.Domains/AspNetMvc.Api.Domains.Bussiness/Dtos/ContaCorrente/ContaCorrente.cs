using System;

namespace AspNetMvc.Api.Domains.Dtos.ContaCorrente
{
    public class ContaCorrente : Base
    {
        public ContaCorrente(Base dto = null) : base(dto) { }

        public long Numero { get; set; }
        public int Digito { get; set; }
        public int GrupoContaCorrenteId { get; set; }
        public int BancoId { get; set; }
        public int AgenciaId { get; set; }
        public Int64 PessoaId { get; set; }
        public bool FlagStatus { get; set; }
        public DateTime CadastroDataHora { get; set; }
        public Int64 CadastroUsuarioId { get; set; }
        public DateTime AtualizacaoDataHora { get; set; }
        public Int64 AtualizacaoUsuarioId { get; set; }

    }
}
