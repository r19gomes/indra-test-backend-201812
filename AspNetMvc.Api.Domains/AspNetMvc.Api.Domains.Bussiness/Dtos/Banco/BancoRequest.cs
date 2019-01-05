using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetMvc.Api.Domains.Dtos.Banco
{
    public class BancoRequest : RequestBase
    {
        #region Properties | Fields

        public Banco Banco { get; set; }

        #endregion

        #region Builders

        public BancoRequest()
        {
            Banco = new Banco();
        }

        #endregion
    }
}
