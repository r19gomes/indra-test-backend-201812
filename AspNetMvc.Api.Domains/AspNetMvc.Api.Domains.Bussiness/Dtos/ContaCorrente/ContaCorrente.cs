using System;

namespace AspNetMvc.Api.Domains.Dtos.ContaCorrente
{
    public class ContaCorrente : Base
    {
        public ContaCorrente(Base dto = null) : base(dto) { }

        public ContaCorrente(ContaCorrente contaCorrente)
        {
            BancoId = contaCorrente.BancoId;
            AgenciaId = contaCorrente.AgenciaId;
            PessoaId = contaCorrente.PessoaId;
            Numero = contaCorrente.Numero;
            Digito = contaCorrente.Digito;
            GrupoContaCorrenteId = contaCorrente.GrupoContaCorrenteId;
            FlagStatus = contaCorrente.FlagStatus;
            CadastroDataHora = contaCorrente.CadastroDataHora;
            CadastroUsuarioId = contaCorrente.CadastroUsuarioId;
            AtualizacaoDataHora = contaCorrente.AtualizacaoDataHora;
            AtualizacaoUsuarioId = contaCorrente.AtualizacaoUsuarioId;
        }

        public long BancoId { get; set; }
        public long AgenciaId { get; set; }
        public long PessoaId { get; set; }
        public long Numero { get; set; }
        public int Digito { get; set; }
        public int GrupoContaCorrenteId { get; set; }
        public bool FlagStatus { get; set; }
        public DateTime CadastroDataHora { get; set; }
        public long CadastroUsuarioId { get; set; }
        public DateTime AtualizacaoDataHora { get; set; }
        public long AtualizacaoUsuarioId { get; set; }

    }
}
