using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetMvc.Api.Domains.Dtos.ContaCorrente
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
