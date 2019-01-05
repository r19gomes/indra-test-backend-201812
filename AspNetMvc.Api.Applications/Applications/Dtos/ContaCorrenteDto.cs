using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetMvc.Api.Applications.Dtos
{
    public class ContaCorrenteDto
    {
        public long ContaCorrenteId { get; set; }

        public long Numero { get; set; }

        public int Digito { get; set; }

        public int GrupoContaCorrenteId { get; set; }

        public int BancoId { get; set; }

        public int AgenciaId { get; set; }

        public long PessoaId { get; set; }

        public bool FlagStatus { get; set; }

        public DateTime CadastroDataHora { get; set; }

        public long CadastroUsuarioId { get; set; }

        public DateTime? AtualizacaoDataHora { get; set; }

        public long? AtualizacaoUsuarioId { get; set; }
    }
}
