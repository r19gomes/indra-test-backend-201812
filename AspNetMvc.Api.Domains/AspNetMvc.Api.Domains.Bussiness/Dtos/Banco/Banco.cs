﻿using System;

namespace AspNetMvc.Api.Domains.Dtos.Banco
{
    public class Banco: Base
    {
        #region Builders

        public Banco(Base dto = null) : base(dto) { }

        public Banco(Banco banco)
        {
            BancoId = banco.BancoId;
            Codigo = banco.Codigo;
            Nome = banco.Nome;
            Apelido = banco.Apelido;
            NumeroCnpj = banco.NumeroCnpj;
            FlagStatus = banco.FlagStatus;
            CadastroUsuarioId = banco.CadastroUsuarioId;
            CadastroDataHora = banco.CadastroDataHora;
            AtualizacaoUsuarioId = banco.AtualizacaoUsuarioId;
            AtualizacaoDataHora = banco.AtualizacaoDataHora;
        }

        #endregion

        #region Properties | Fields

        public long BancoId { get; set; }

        public string Codigo { get; set; }

        public string Nome { get; set; }

        public string Apelido { get; set; }

        public string NumeroCnpj { get; set; }

        public bool FlagStatus { get; set; }

        public long CadastroUsuarioId { get; set; }

        public DateTime CadastroDataHora { get; set; }

        public long? AtualizacaoUsuarioId { get; set; }

        public DateTime? AtualizacaoDataHora { get; set; }

        #endregion
    }
}