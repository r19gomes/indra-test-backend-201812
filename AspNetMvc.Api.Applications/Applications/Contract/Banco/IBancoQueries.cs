using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetMvc.Api.Applications.Contract.Banco
{
    public interface IBancoQueries
    {
        void GetAll();

        void Get(long id);
    }
}
