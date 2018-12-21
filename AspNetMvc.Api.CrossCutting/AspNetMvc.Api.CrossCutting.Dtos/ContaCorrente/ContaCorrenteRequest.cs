using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetMvc.Api.CrossCutting.Dtos.ContaCorrente
{
    public class ContaCorrenteRequest : RequestBase
    {
        public ContaCorrenteRequest()
        {
            ContaCorrente = new ContaCorrente();
        }

        public ContaCorrente ContaCorrente { get; set; }
    }
}
