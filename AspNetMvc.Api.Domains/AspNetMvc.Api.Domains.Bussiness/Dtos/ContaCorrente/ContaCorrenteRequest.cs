namespace AspNetMvc.Api.Domains.Dtos.ContaCorrente
{
    public class ContaCorrenteRequest : RequestBase
    {
        #region Properties | Fields

        public ContaCorrente ContaCorrente { get; set; }

        #endregion

        #region Builders

        public ContaCorrenteRequest()
        {
            ContaCorrente = new ContaCorrente();
        }

        #endregion
    }
}
