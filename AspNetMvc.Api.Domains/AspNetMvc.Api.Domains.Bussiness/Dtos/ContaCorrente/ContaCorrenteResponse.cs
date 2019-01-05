using System.Collections.Generic;

namespace AspNetMvc.Api.Domains.Dtos.ContaCorrente
{
    public class ContaCorrenteResponse : ResponseBase
    {
        #region Properties | Fields

        public IList<ContaCorrente> ContaCorrente { get; set; }

        #endregion

        #region Builders

        public ContaCorrenteResponse()
        {
            ContaCorrente = new List<ContaCorrente>();
        }

        #endregion
    }
}
