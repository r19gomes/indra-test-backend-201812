using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetMvc.Api.Domains.Dtos.Banco
{
    public class BancoResponse : ResponseBase
    {
        #region Properties | Fields

        public IList<Banco> Banco { get; set; }

        #endregion

        #region Builders

        public BancoResponse()
        {
            Banco = new List<Banco>();
        }

        #endregion
    }
}
