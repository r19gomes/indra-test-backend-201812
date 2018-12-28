using System.Collections.Generic;

namespace AspNetMvc.Api.Domains.Dtos.ContaCorrente
{
    public class ContaCorrenteResponse : ResponseBase
    {
        public ContaCorrenteResponse()
        {
            ContaCorrente = new List<ContaCorrente>();
        }

        public List<ContaCorrente> ContaCorrente { get; set; }
    }
}
